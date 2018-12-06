namespace Players
{
    partial class AddCoach
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
            this.CoachTeam = new System.Windows.Forms.ComboBox();
            this.CoachFathername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CoachSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddCoachButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CoachCitizenship = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoachBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CoachName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoachList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CoachList)).BeginInit();
            this.SuspendLayout();
            // 
            // CoachTeam
            // 
            this.CoachTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoachTeam.FormattingEnabled = true;
            this.CoachTeam.Location = new System.Drawing.Point(204, 190);
            this.CoachTeam.Name = "CoachTeam";
            this.CoachTeam.Size = new System.Drawing.Size(209, 32);
            this.CoachTeam.TabIndex = 48;
            // 
            // CoachFathername
            // 
            this.CoachFathername.Location = new System.Drawing.Point(204, 85);
            this.CoachFathername.MaxLength = 100;
            this.CoachFathername.Name = "CoachFathername";
            this.CoachFathername.Size = new System.Drawing.Size(209, 29);
            this.CoachFathername.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Отчество: ";
            // 
            // CoachSurname
            // 
            this.CoachSurname.Location = new System.Drawing.Point(204, 50);
            this.CoachSurname.MaxLength = 100;
            this.CoachSurname.Name = "CoachSurname";
            this.CoachSurname.Size = new System.Drawing.Size(209, 29);
            this.CoachSurname.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 58;
            this.label9.Text = "Фамилия: ";
            // 
            // AddCoachButton
            // 
            this.AddCoachButton.Location = new System.Drawing.Point(16, 228);
            this.AddCoachButton.Name = "AddCoachButton";
            this.AddCoachButton.Size = new System.Drawing.Size(397, 69);
            this.AddCoachButton.TabIndex = 49;
            this.AddCoachButton.Text = "Добавить тренера";
            this.AddCoachButton.UseVisualStyleBackColor = true;
            this.AddCoachButton.Click += new System.EventHandler(this.AddCoachButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Команда: ";
            // 
            // CoachCitizenship
            // 
            this.CoachCitizenship.Location = new System.Drawing.Point(204, 155);
            this.CoachCitizenship.MaxLength = 100;
            this.CoachCitizenship.Name = "CoachCitizenship";
            this.CoachCitizenship.Size = new System.Drawing.Size(209, 29);
            this.CoachCitizenship.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Гражданство: ";
            // 
            // CoachBirth
            // 
            this.CoachBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CoachBirth.Location = new System.Drawing.Point(204, 120);
            this.CoachBirth.Name = "CoachBirth";
            this.CoachBirth.Size = new System.Drawing.Size(209, 29);
            this.CoachBirth.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Дата рождения: ";
            // 
            // CoachName
            // 
            this.CoachName.Location = new System.Drawing.Point(204, 15);
            this.CoachName.MaxLength = 100;
            this.CoachName.Name = "CoachName";
            this.CoachName.Size = new System.Drawing.Size(209, 29);
            this.CoachName.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Имя: ";
            // 
            // CoachList
            // 
            this.CoachList.AllowUserToAddRows = false;
            this.CoachList.AllowUserToDeleteRows = false;
            this.CoachList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoachList.Location = new System.Drawing.Point(422, 15);
            this.CoachList.Margin = new System.Windows.Forms.Padding(6);
            this.CoachList.Name = "CoachList";
            this.CoachList.ReadOnly = true;
            this.CoachList.RowHeadersVisible = false;
            this.CoachList.Size = new System.Drawing.Size(576, 282);
            this.CoachList.TabIndex = 50;
            // 
            // AddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 308);
            this.Controls.Add(this.CoachTeam);
            this.Controls.Add(this.CoachFathername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CoachSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddCoachButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CoachCitizenship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoachBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoachName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoachList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddCoach";
            this.Text = "AddCoach";
            ((System.ComponentModel.ISupportInitialize)(this.CoachList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoachTeam;
        private System.Windows.Forms.TextBox CoachFathername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CoachSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddCoachButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CoachCitizenship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CoachBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoachName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CoachList;

    }
}