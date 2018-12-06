namespace Players
{
    partial class AddPlayer
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
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerCitizenship = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerList = new System.Windows.Forms.DataGridView();
            this.PlayerFathername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayerSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayerHeight = new System.Windows.Forms.NumericUpDown();
            this.PlayerWeight = new System.Windows.Forms.NumericUpDown();
            this.PlayerNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerTeam = new System.Windows.Forms.ComboBox();
            this.PlayerRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(16, 369);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(397, 69);
            this.AddPlayerButton.TabIndex = 11;
            this.AddPlayerButton.Text = "Добавить игрока";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Команда: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Вес: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Рост: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Амплуа: ";
            // 
            // PlayerCitizenship
            // 
            this.PlayerCitizenship.Location = new System.Drawing.Point(204, 152);
            this.PlayerCitizenship.MaxLength = 100;
            this.PlayerCitizenship.Name = "PlayerCitizenship";
            this.PlayerCitizenship.Size = new System.Drawing.Size(209, 34);
            this.PlayerCitizenship.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Гражданство: ";
            // 
            // PlayerBirth
            // 
            this.PlayerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PlayerBirth.Location = new System.Drawing.Point(204, 117);
            this.PlayerBirth.Name = "PlayerBirth";
            this.PlayerBirth.Size = new System.Drawing.Size(209, 34);
            this.PlayerBirth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Дата рождения: ";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(204, 12);
            this.PlayerName.MaxLength = 100;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(209, 34);
            this.PlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя: ";
            // 
            // PlayerList
            // 
            this.PlayerList.AllowUserToAddRows = false;
            this.PlayerList.AllowUserToDeleteRows = false;
            this.PlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerList.Location = new System.Drawing.Point(422, 12);
            this.PlayerList.Margin = new System.Windows.Forms.Padding(6);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.ReadOnly = true;
            this.PlayerList.RowHeadersVisible = false;
            this.PlayerList.Size = new System.Drawing.Size(809, 426);
            this.PlayerList.TabIndex = 16;
            // 
            // PlayerFathername
            // 
            this.PlayerFathername.Location = new System.Drawing.Point(204, 82);
            this.PlayerFathername.MaxLength = 100;
            this.PlayerFathername.Name = "PlayerFathername";
            this.PlayerFathername.Size = new System.Drawing.Size(209, 34);
            this.PlayerFathername.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Отчество: ";
            // 
            // PlayerSurname
            // 
            this.PlayerSurname.Location = new System.Drawing.Point(204, 47);
            this.PlayerSurname.MaxLength = 100;
            this.PlayerSurname.Name = "PlayerSurname";
            this.PlayerSurname.Size = new System.Drawing.Size(209, 34);
            this.PlayerSurname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Фамилия: ";
            // 
            // PlayerHeight
            // 
            this.PlayerHeight.Location = new System.Drawing.Point(204, 188);
            this.PlayerHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.PlayerHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PlayerHeight.Name = "PlayerHeight";
            this.PlayerHeight.Size = new System.Drawing.Size(209, 34);
            this.PlayerHeight.TabIndex = 6;
            this.PlayerHeight.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // PlayerWeight
            // 
            this.PlayerWeight.Location = new System.Drawing.Point(204, 223);
            this.PlayerWeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.PlayerWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.PlayerWeight.Name = "PlayerWeight";
            this.PlayerWeight.Size = new System.Drawing.Size(209, 34);
            this.PlayerWeight.TabIndex = 7;
            this.PlayerWeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // PlayerNum
            // 
            this.PlayerNum.Location = new System.Drawing.Point(204, 296);
            this.PlayerNum.Name = "PlayerNum";
            this.PlayerNum.Size = new System.Drawing.Size(209, 34);
            this.PlayerNum.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Номер: ";
            // 
            // PlayerTeam
            // 
            this.PlayerTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerTeam.FormattingEnabled = true;
            this.PlayerTeam.Location = new System.Drawing.Point(204, 331);
            this.PlayerTeam.Name = "PlayerTeam";
            this.PlayerTeam.Size = new System.Drawing.Size(209, 37);
            this.PlayerTeam.TabIndex = 10;
            // 
            // PlayerRole
            // 
            this.PlayerRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerRole.FormattingEnabled = true;
            this.PlayerRole.Items.AddRange(new object[] {
            "Point Guard",
            "Shooting Guard",
            "Center",
            "Power Forward",
            "Small Forward"});
            this.PlayerRole.Location = new System.Drawing.Point(204, 258);
            this.PlayerRole.Name = "PlayerRole";
            this.PlayerRole.Size = new System.Drawing.Size(209, 37);
            this.PlayerRole.TabIndex = 8;
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 447);
            this.Controls.Add(this.PlayerRole);
            this.Controls.Add(this.PlayerTeam);
            this.Controls.Add(this.PlayerNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PlayerWeight);
            this.Controls.Add(this.PlayerHeight);
            this.Controls.Add(this.PlayerFathername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlayerSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayerCitizenship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlayerCitizenship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PlayerBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PlayerList;
        private System.Windows.Forms.TextBox PlayerFathername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PlayerSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PlayerHeight;
        private System.Windows.Forms.NumericUpDown PlayerWeight;
        private System.Windows.Forms.NumericUpDown PlayerNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PlayerTeam;
        private System.Windows.Forms.ComboBox PlayerRole;
    }
}