namespace Players
{
    partial class UpdateCoach
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
            this.CoachName = new System.Windows.Forms.ComboBox();
            this.CoachNewTeam = new System.Windows.Forms.ComboBox();
            this.AddCoachButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExCoachList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExCoachList)).BeginInit();
            this.SuspendLayout();
            // 
            // CoachName
            // 
            this.CoachName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoachName.FormattingEnabled = true;
            this.CoachName.Location = new System.Drawing.Point(117, 12);
            this.CoachName.Name = "CoachName";
            this.CoachName.Size = new System.Drawing.Size(264, 32);
            this.CoachName.TabIndex = 36;
            // 
            // CoachNewTeam
            // 
            this.CoachNewTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoachNewTeam.FormattingEnabled = true;
            this.CoachNewTeam.Location = new System.Drawing.Point(117, 50);
            this.CoachNewTeam.Name = "CoachNewTeam";
            this.CoachNewTeam.Size = new System.Drawing.Size(264, 32);
            this.CoachNewTeam.TabIndex = 37;
            // 
            // AddCoachButton
            // 
            this.AddCoachButton.Location = new System.Drawing.Point(12, 88);
            this.AddCoachButton.Name = "AddCoachButton";
            this.AddCoachButton.Size = new System.Drawing.Size(369, 69);
            this.AddCoachButton.TabIndex = 38;
            this.AddCoachButton.Text = "Перевести игрока";
            this.AddCoachButton.UseVisualStyleBackColor = true;
            this.AddCoachButton.Click += new System.EventHandler(this.AddCoachButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Команда: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Тренер: ";
            // 
            // ExCoachList
            // 
            this.ExCoachList.AllowUserToAddRows = false;
            this.ExCoachList.AllowUserToDeleteRows = false;
            this.ExCoachList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExCoachList.Location = new System.Drawing.Point(390, 12);
            this.ExCoachList.Margin = new System.Windows.Forms.Padding(6);
            this.ExCoachList.Name = "ExCoachList";
            this.ExCoachList.ReadOnly = true;
            this.ExCoachList.RowHeadersVisible = false;
            this.ExCoachList.Size = new System.Drawing.Size(454, 145);
            this.ExCoachList.TabIndex = 39;
            // 
            // UpdateCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 170);
            this.Controls.Add(this.CoachName);
            this.Controls.Add(this.CoachNewTeam);
            this.Controls.Add(this.AddCoachButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExCoachList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UpdateCoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCoach";
            ((System.ComponentModel.ISupportInitialize)(this.ExCoachList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoachName;
        private System.Windows.Forms.ComboBox CoachNewTeam;
        private System.Windows.Forms.Button AddCoachButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ExCoachList;
    }
}