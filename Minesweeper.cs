using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        public Minesweeper()
        {
            InitializeComponent();
            StartupMenu startupMenu = new StartupMenu(this);
            startupMenu.FormClosing += new FormClosingEventHandler(StartupMenu_Closing);
            startupMenu.ShowDialog();//show startup menu
            while (!GameInfo.GameStarted);//wait until start button is pressed
            //<draw mine field>
            int mineCellWidth = 25;
            int mineCellLength = 25;
            int mineCellDistance = 5;
            Random rnd = new Random();
            for (int x = 0; x < GameInfo.BoardX; x++)//generate mine cells
            {
                for (int y = 0; y < GameInfo.BoardY; y++)
                {
                    MineCell currentDrawing = new MineCell()
                    {
                        Size = new Size(mineCellWidth, mineCellLength),
                        Location = new Point(x * mineCellWidth + mineCellDistance, y * mineCellLength + mineCellDistance),
                        Name = Convert.ToString(x, 10) + "," + Convert.ToString(y, 10),
                        BackColor = SystemColors.ControlLight
                    };
                    MineField.Controls.Add(currentDrawing);
                    currentDrawing.MouseDown += new MouseEventHandler(MineCell_MouseDown);
                }
            }
            for (; ; )//generate mines
            {
                int randomXCoord = rnd.Next(0, GameInfo.BoardX);
                int randomYCoord = rnd.Next(0, GameInfo.BoardY);
                string SelectedMineCellName = Convert.ToString(randomXCoord) + "," + Convert.ToString(randomYCoord);//the name of the mine cell selected
                MineCell selectedMineCell = (MineCell)MineField.Controls.Find(SelectedMineCellName, true)[0];
                if (selectedMineCell.HasMine == false)
                {
                    selectedMineCell.HasMine = true;
                    GameInfo.CurrentMineCount++;
                }
                else//if the selected mine cell already has mine in it
                {
                    continue;
                }
                if (GameInfo.CurrentMineCount == GameInfo.TotalMineCount)//when generation is complete
                {
                    break;
                }
            }
            for (int x = 0; x < GameInfo.BoardX; x++)//calculate `ProxMineCount`
            {
                for (int y = 0; y < GameInfo.BoardY; y++)
                {
                    string selectedMineCellName = Convert.ToString(x) + "," + Convert.ToString(y);//the name of the mine cell selected
                    string proxCellName;//the name of the proximity mine cell
                    int[,] proxCoords = {
                        { x + 1, y - 1 },//all 8 adjacent coordinates of `selectedCell`
                        { x + 1, y },
                        { x + 1, y + 1 },
                        { x - 1, y - 1 },
                        { x - 1, y },
                        { x - 1, y + 1 },
                        { x, y - 1 },
                        { x, y + 1 }
                    };
                    MineCell selectedCell = (MineCell)MineField.Controls.Find(selectedMineCellName, true)[0];
                    MineCell proxCell;
                    for (int i = 0; i < 8; i++)//cycle through all 8 adjacent cells
                    {
                        proxCellName = Convert.ToString(proxCoords[i, 0]) + "," + Convert.ToString(proxCoords[i, 1]);
                        proxCell = (MineCell)MineField.Controls.Find(proxCellName, true).FirstOrDefault();
                        if (proxCell != null && proxCell.HasMine)
                        {
                            selectedCell.ProxMineCount++;
                        }
                    }
                }
            }
            //</draw mine field>
        }
        private void StartupMenu_Closing(object sender, EventArgs e)
        {
            this.Visible = true;
            GameInfo.GameStarted = true;//force the game to start
        }
        private void MineCell_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MineCell mineCell = (MineCell)sender;
                if (mineCell.IsFlagged == false)
                {
                    RevealMineCell((MineCell)sender);
                    CheckIfWon(false);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                MineCell mineCell = (MineCell)sender;
                if (mineCell.IsFlagged == false)
                {
                    mineCell.BackColor = Color.Red;
                    mineCell.IsFlagged = true;
                }
                else//if already flagged
                {
                    mineCell.BackColor = SystemColors.ControlLight;
                    mineCell.IsFlagged = false;
                }
                CheckIfWon(true);
            }
        }
        private void RevealMineCell(MineCell revealingMineCell)
        {
            string[] parsedCoords = revealingMineCell.Name.ToString().Split(',');
            int proxXCoord = Convert.ToInt32(parsedCoords[0]);
            int proxYCoord = Convert.ToInt32(parsedCoords[1]);
            string proxCellName;//the name of the proximity mine cell
            MineCell proxCell;//the proximity mine cell
            int[,] proxCoords = {
                { proxXCoord + 1, proxYCoord - 1 },//all 8 adjacent coordinates of `revealingMineCell`
                { proxXCoord + 1, proxYCoord },
                { proxXCoord + 1, proxYCoord + 1 },
                { proxXCoord - 1, proxYCoord - 1 },
                { proxXCoord - 1, proxYCoord },
                { proxXCoord - 1, proxYCoord + 1 },
                { proxXCoord, proxYCoord - 1 },
                { proxXCoord, proxYCoord + 1 }
            };
            if (revealingMineCell.HasMine)//if the mine cell revealed has mine in it
            {
                MineField.Enabled = false;
                GameOverSign.Visible = true;
            }
            else if (revealingMineCell.ProxMineCount == 0)//if the mine cell revealed is empty
            {
                revealingMineCell.Enabled = false;
                revealingMineCell.BackColor = SystemColors.ControlDark;
                revealingMineCell.IsRevealed = true;
                for (int i = 0; i < 8; i++)
                {
                    proxCellName = Convert.ToString(proxCoords[i, 0]) + "," + Convert.ToString(proxCoords[i, 1]);
                    proxCell = (MineCell)MineField.Controls.Find(proxCellName, true).FirstOrDefault();
                    if (proxCell != null && proxCell.IsRevealed == false && proxCell.IsFlagged)
                    {
                        proxCell.IsFlagged = false;
                        proxCell.BackColor = SystemColors.ControlDark;
                        RevealMineCell(proxCell);
                    }
                    else if (proxCell != null && proxCell.IsRevealed == false)//reminder: `proxCell` is impossible to have a mine in it as `revealingMineCell` is empty in the first place
                    {
                        RevealMineCell(proxCell);//repeat the process until all adjacent empty mine cells are all revealed
                    }
                }
            }
            else
            {
                revealingMineCell.Enabled = false;
                revealingMineCell.Text = Convert.ToString(revealingMineCell.ProxMineCount);
                revealingMineCell.BackColor = SystemColors.ControlDark;
                revealingMineCell.IsRevealed = true;
            }
        }
        private void CheckIfWon(bool byFlaging)
        {
            int totalMineFound = 0;
            int totalRevealedCell = 0;
            int flaggedCount = 0;
            int flaggedMineCount = 0;
            foreach (MineCell mineCell in MineField.Controls)
            {
                if (mineCell.HasMine && mineCell.IsRevealed == false)
                {
                    totalMineFound++;
                }
                if (mineCell.IsRevealed)
                {
                    totalRevealedCell++;
                }
                if (byFlaging == true)
                {
                    if (mineCell.IsFlagged && mineCell.HasMine)
                    {
                        flaggedMineCount++;
                    }
                    if (mineCell.IsFlagged)
                    {
                        flaggedCount++;
                    }
                }
            }
            if (totalMineFound == GameInfo.TotalMineCount && totalRevealedCell == (GameInfo.BoardX * GameInfo.BoardY) - GameInfo.TotalMineCount)//check if all non-mine cells have been revealed
            {
                MineField.Enabled = false;
                WinSign.Visible = true;
            }
            else if (flaggedCount == flaggedMineCount && flaggedCount == GameInfo.TotalMineCount && byFlaging)//if all mines have been flagged and no excess flag was used
            {
                MineField.Enabled = false;
                WinSign.Visible = true;
            }
        }
    }
    public class MineCell : Button
    {
        private int _ProxMineCount;
        public int ProxMineCount//if ==0 then the cell is empty(no number)
        {
            get
            {
                return _ProxMineCount;
            }
            set
            {
                if (value > 9 || value < 0)//if value is invalid
                {
                    _ProxMineCount = 0;
                }
                else
                {
                    _ProxMineCount = value;
                }
            }
        }
        public bool HasMine { get; set; } = false;
        public bool IsRevealed { get; set; } = false;
        public bool IsFlagged { get; set; } = false;
        public MineCell(int proxMineCount, bool hasMine)
        {
            ProxMineCount = proxMineCount;
            HasMine = hasMine;
        }
        public MineCell()
        {
            ProxMineCount = 0;
            HasMine = false;
            IsRevealed = false;
            IsFlagged = false;
        }
    }
    public static class GameInfo
    {
        public static int BoardX { get; set; } = 8;//width
        public static int BoardY { get; set; } = 8;//length
        public static int TotalMineCount { get; set; } = 10;
        public static int CurrentMineCount { get; set; } = 0;//this property should eventually match `TotalMineCount`
        public static bool GameStarted { get; set; } = false;
    }
}

