namespace Players
{
    partial class Game
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
            this.OwnerTeam = new System.Windows.Forms.ComboBox();
            this.AddGame = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GameList = new System.Windows.Forms.DataGridView();
            this.GuestTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.OwnerScore = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.GuestScore = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestScore)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerTeam
            // 
            this.OwnerTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerTeam.FormattingEnabled = true;
            this.OwnerTeam.Location = new System.Drawing.Point(291, 12);
            this.OwnerTeam.Name = "OwnerTeam";
            this.OwnerTeam.Size = new System.Drawing.Size(209, 37);
            this.OwnerTeam.TabIndex = 48;
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(17, 263);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(483, 69);
            this.AddGame.TabIndex = 49;
            this.AddGame.Text = "Добавить игру";
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Команда #1: ";
            // 
            // GameList
            // 
            this.GameList.AllowUserToAddRows = false;
            this.GameList.AllowUserToDeleteRows = false;
            this.GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameList.Location = new System.Drawing.Point(509, 12);
            this.GameList.Margin = new System.Windows.Forms.Padding(6);
            this.GameList.Name = "GameList";
            this.GameList.ReadOnly = true;
            this.GameList.RowHeadersVisible = false;
            this.GameList.Size = new System.Drawing.Size(857, 320);
            this.GameList.TabIndex = 50;
            // 
            // GuestTeam
            // 
            this.GuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuestTeam.FormattingEnabled = true;
            this.GuestTeam.Location = new System.Drawing.Point(291, 50);
            this.GuestTeam.Name = "GuestTeam";
            this.GuestTeam.Size = new System.Drawing.Size(209, 37);
            this.GuestTeam.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Команда #2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "Место проведения: ";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(291, 123);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(209, 34);
            this.Date.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "Дата: ";
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(291, 158);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(209, 34);
            this.Time.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Время: ";
            // 
            // OwnerScore
            // 
            this.OwnerScore.Location = new System.Drawing.Point(291, 193);
            this.OwnerScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.OwnerScore.Name = "OwnerScore";
            this.OwnerScore.Size = new System.Drawing.Size(209, 34);
            this.OwnerScore.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 29);
            this.label10.TabIndex = 67;
            this.label10.Text = "Счет команды #1: ";
            // 
            // GuestScore
            // 
            this.GuestScore.Location = new System.Drawing.Point(291, 228);
            this.GuestScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GuestScore.Name = "GuestScore";
            this.GuestScore.Size = new System.Drawing.Size(209, 34);
            this.GuestScore.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Счет команды #2: ";
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(291, 88);
            this.Place.MaxLength = 100;
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(209, 34);
            this.Place.TabIndex = 60;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 350);
            this.Controls.Add(this.GuestScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OwnerScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GuestTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwnerTeam);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GameList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OwnerTeam;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GameList;
        private System.Windows.Forms.ComboBox GuestTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown OwnerScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown GuestScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Place;
    }
}