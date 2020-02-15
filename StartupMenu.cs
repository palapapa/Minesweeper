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
    public partial class StartupMenu : Form
    {
        public static Minesweeper @Ref { get; set; }
        public StartupMenu()
        {
            InitializeComponent();
        }
        public StartupMenu(Minesweeper @ref)
        {
            InitializeComponent();
            @Ref = @ref;//get the instance of the main form
        }

        private void XCustomizer_ValueChanged(object sender, EventArgs e)
        {
            MinesCustomizer.Maximum = (XCustomizer.Value - 1) * (YCustomizer.Value - 1);//adjust number of mines allowed
        }

        private void YCustomizer_ValueChanged(object sender, EventArgs e)
        {
            MinesCustomizer.Maximum = (XCustomizer.Value - 1) * (YCustomizer.Value - 1);//adjust number of mines allowed
        }

        private void DifficultySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = DifficultySelector.GetItemText(DifficultySelector.SelectedItem);
            if (selectedOption == "Custom")
            {
                DifficultyCustomizer.Enabled = true;
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            string selectedOption = DifficultySelector.GetItemText(DifficultySelector.SelectedItem);
            bool noOptionSelected = false;
            switch (selectedOption)
            {
                case "Easy 8*8 (10 mines)":
                    GameInfo.BoardX = 8;
                    GameInfo.BoardY = 8;
                    GameInfo.TotalMineCount = 10;
                    break;
                case "Normal 16*16 (40 mines)":
                    GameInfo.BoardX = 16;
                    GameInfo.BoardY = 16;
                    GameInfo.TotalMineCount = 40;
                    break;
                case "Hard 30*16 (99 mines)":
                    GameInfo.BoardX = 30;
                    GameInfo.BoardY = 16;
                    GameInfo.TotalMineCount = 99;
                    break;
                case "Custom":
                    GameInfo.BoardX = (int)XCustomizer.Value;
                    GameInfo.BoardY = (int)YCustomizer.Value;
                    GameInfo.TotalMineCount = (int)MinesCustomizer.Value;
                    break;
                default://no item is selected
                    noOptionSelected = true;
                    break;
            }
            if (noOptionSelected == false)
            {
                this.Hide();//hide startup menu
                @Ref.Show();
                GameInfo.GameStarted = true;
            }
        }
    }
}
