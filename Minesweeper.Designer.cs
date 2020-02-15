namespace Minesweeper
{
    partial class Minesweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MineField = new System.Windows.Forms.Panel();
            this.GameOverSign = new System.Windows.Forms.Label();
            this.WinSign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MineField
            // 
            this.MineField.AutoSize = true;
            this.MineField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MineField.Location = new System.Drawing.Point(12, 12);
            this.MineField.Name = "MineField";
            this.MineField.Size = new System.Drawing.Size(0, 0);
            this.MineField.TabIndex = 0;
            // 
            // GameOverSign
            // 
            this.GameOverSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOverSign.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameOverSign.ForeColor = System.Drawing.Color.Red;
            this.GameOverSign.Location = new System.Drawing.Point(13, 13);
            this.GameOverSign.Name = "GameOverSign";
            this.GameOverSign.Size = new System.Drawing.Size(775, 428);
            this.GameOverSign.TabIndex = 1;
            this.GameOverSign.Text = "Game Over";
            this.GameOverSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverSign.Visible = false;
            // 
            // WinSign
            // 
            this.WinSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinSign.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WinSign.ForeColor = System.Drawing.Color.Red;
            this.WinSign.Location = new System.Drawing.Point(13, 13);
            this.WinSign.Name = "WinSign";
            this.WinSign.Size = new System.Drawing.Size(775, 428);
            this.WinSign.TabIndex = 2;
            this.WinSign.Text = "You Win";
            this.WinSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinSign.Visible = false;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WinSign);
            this.Controls.Add(this.GameOverSign);
            this.Controls.Add(this.MineField);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper by palapapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MineField;
        private System.Windows.Forms.Label GameOverSign;
        private System.Windows.Forms.Label WinSign;
    }
}

