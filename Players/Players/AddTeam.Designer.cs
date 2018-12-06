namespace Players
{
    partial class AddTeam
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
            this.TeamList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamCountry = new System.Windows.Forms.TextBox();
            this.TeamCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamConf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamArena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TeamColors = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddTeamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamList
            // 
            this.TeamList.AllowUserToAddRows = false;
            this.TeamList.AllowUserToDeleteRows = false;
            this.TeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamList.Location = new System.Drawing.Point(422, 6);
            this.TeamList.Margin = new System.Windows.Forms.Padding(6);
            this.TeamList.Name = "TeamList";
            this.TeamList.ReadOnly = true;
            this.TeamList.RowHeadersVisible = false;
            this.TeamList.Size = new System.Drawing.Size(809, 314);
            this.TeamList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название: ";
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(204, 6);
            this.TeamName.MaxLength = 100;
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(209, 29);
            this.TeamName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата образования: ";
            // 
            // TeamDateStart
            // 
            this.TeamDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TeamDateStart.Location = new System.Drawing.Point(204, 41);
            this.TeamDateStart.Name = "TeamDateStart";
            this.TeamDateStart.Size = new System.Drawing.Size(209, 29);
            this.TeamDateStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Страна: ";
            // 
            // TeamCountry
            // 
            this.TeamCountry.Location = new System.Drawing.Point(204, 76);
            this.TeamCountry.MaxLength = 100;
            this.TeamCountry.Name = "TeamCountry";
            this.TeamCountry.Size = new System.Drawing.Size(209, 29);
            this.TeamCountry.TabIndex = 6;
            // 
            // TeamCity
            // 
            this.TeamCity.Location = new System.Drawing.Point(204, 111);
            this.TeamCity.MaxLength = 100;
            this.TeamCity.Name = "TeamCity";
            this.TeamCity.Size = new System.Drawing.Size(209, 29);
            this.TeamCity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Город: ";
            // 
            // TeamConf
            // 
            this.TeamConf.Location = new System.Drawing.Point(204, 146);
            this.TeamConf.MaxLength = 100;
            this.TeamConf.Name = "TeamConf";
            this.TeamConf.Size = new System.Drawing.Size(209, 29);
            this.TeamConf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конференция: ";
            // 
            // TeamArena
            // 
            this.TeamArena.Location = new System.Drawing.Point(204, 181);
            this.TeamArena.MaxLength = 100;
            this.TeamArena.Name = "TeamArena";
            this.TeamArena.Size = new System.Drawing.Size(209, 29);
            this.TeamArena.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Арена: ";
            // 
            // TeamColors
            // 
            this.TeamColors.Location = new System.Drawing.Point(204, 216);
            this.TeamColors.MaxLength = 512;
            this.TeamColors.Name = "TeamColors";
            this.TeamColors.Size = new System.Drawing.Size(209, 29);
            this.TeamColors.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Цвета: ";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(16, 251);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(397, 69);
            this.AddTeamButton.TabIndex = 15;
            this.AddTeamButton.Text = "Добавить команду";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 332);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.TeamColors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeamArena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TeamConf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeamCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeam";
            ((System.ComponentModel.ISupportInitialize)(this.TeamList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeamList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TeamDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TeamCountry;
        private System.Windows.Forms.TextBox TeamCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TeamConf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TeamArena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TeamColors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddTeamButton;
    }
}