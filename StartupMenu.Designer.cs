namespace Minesweeper
{
    partial class StartupMenu
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
            this.DifficultySelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyCustomizer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MinesCustomizer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.YCustomizer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.XCustomizer = new System.Windows.Forms.NumericUpDown();
            this.StartGame = new System.Windows.Forms.Button();
            this.DifficultyCustomizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinesCustomizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCustomizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCustomizer)).BeginInit();
            this.SuspendLayout();
            // 
            // DifficultySelector
            // 
            this.DifficultySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultySelector.FormattingEnabled = true;
            this.DifficultySelector.Items.AddRange(new object[] {
            "Easy 8*8 (10 mines)",
            "Normal 16*16 (40 mines)",
            "Hard 30*16 (99 mines)",
            "Custom"});
            this.DifficultySelector.Location = new System.Drawing.Point(12, 46);
            this.DifficultySelector.Name = "DifficultySelector";
            this.DifficultySelector.Size = new System.Drawing.Size(203, 26);
            this.DifficultySelector.TabIndex = 0;
            this.DifficultySelector.SelectedIndexChanged += new System.EventHandler(this.DifficultySelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Difficulty";
            // 
            // DifficultyCustomizer
            // 
            this.DifficultyCustomizer.Controls.Add(this.label4);
            this.DifficultyCustomizer.Controls.Add(this.MinesCustomizer);
            this.DifficultyCustomizer.Controls.Add(this.label3);
            this.DifficultyCustomizer.Controls.Add(this.YCustomizer);
            this.DifficultyCustomizer.Controls.Add(this.label2);
            this.DifficultyCustomizer.Controls.Add(this.XCustomizer);
            this.DifficultyCustomizer.Enabled = false;
            this.DifficultyCustomizer.Location = new System.Drawing.Point(221, 13);
            this.DifficultyCustomizer.Name = "DifficultyCustomizer";
            this.DifficultyCustomizer.Size = new System.Drawing.Size(200, 121);
            this.DifficultyCustomizer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(100, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mines";
            // 
            // MinesCustomizer
            // 
            this.MinesCustomizer.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinesCustomizer.Location = new System.Drawing.Point(6, 81);
            this.MinesCustomizer.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.MinesCustomizer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinesCustomizer.Name = "MinesCustomizer";
            this.MinesCustomizer.Size = new System.Drawing.Size(88, 31);
            this.MinesCustomizer.TabIndex = 4;
            this.MinesCustomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinesCustomizer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(100, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // YCustomizer
            // 
            this.YCustomizer.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YCustomizer.Location = new System.Drawing.Point(6, 44);
            this.YCustomizer.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.YCustomizer.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.YCustomizer.Name = "YCustomizer";
            this.YCustomizer.Size = new System.Drawing.Size(88, 31);
            this.YCustomizer.TabIndex = 2;
            this.YCustomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YCustomizer.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.YCustomizer.ValueChanged += new System.EventHandler(this.YCustomizer_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // XCustomizer
            // 
            this.XCustomizer.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XCustomizer.Location = new System.Drawing.Point(6, 8);
            this.XCustomizer.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.XCustomizer.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.XCustomizer.Name = "XCustomizer";
            this.XCustomizer.Size = new System.Drawing.Size(88, 31);
            this.XCustomizer.TabIndex = 0;
            this.XCustomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XCustomizer.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.XCustomizer.ValueChanged += new System.EventHandler(this.XCustomizer_ValueChanged);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartGame.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartGame.Location = new System.Drawing.Point(13, 161);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(408, 121);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "START!";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // StartupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.DifficultyCustomizer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DifficultySelector);
            this.Name = "StartupMenu";
            this.Text = "New Game";
            this.DifficultyCustomizer.ResumeLayout(false);
            this.DifficultyCustomizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinesCustomizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCustomizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XCustomizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DifficultySelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DifficultyCustomizer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MinesCustomizer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown YCustomizer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown XCustomizer;
        private System.Windows.Forms.Button StartGame;
    }
}