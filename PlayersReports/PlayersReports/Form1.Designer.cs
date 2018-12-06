namespace PlayersReports
{
    partial class Form1
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
            this.PlayerStats = new System.Windows.Forms.Button();
            this.TeamReport = new System.Windows.Forms.Button();
            this.ArenaReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerStats
            // 
            this.PlayerStats.Location = new System.Drawing.Point(12, 12);
            this.PlayerStats.Name = "PlayerStats";
            this.PlayerStats.Size = new System.Drawing.Size(710, 81);
            this.PlayerStats.TabIndex = 0;
            this.PlayerStats.Text = "Отчет по статистике игрока";
            this.PlayerStats.UseVisualStyleBackColor = true;
            this.PlayerStats.Click += new System.EventHandler(this.PlayerStats_Click);
            // 
            // TeamReport
            // 
            this.TeamReport.Location = new System.Drawing.Point(12, 99);
            this.TeamReport.Name = "TeamReport";
            this.TeamReport.Size = new System.Drawing.Size(710, 81);
            this.TeamReport.TabIndex = 1;
            this.TeamReport.Text = "Отчет по статистике команды";
            this.TeamReport.UseVisualStyleBackColor = true;
            this.TeamReport.Click += new System.EventHandler(this.TeamReport_Click);
            // 
            // ArenaReport
            // 
            this.ArenaReport.Location = new System.Drawing.Point(12, 186);
            this.ArenaReport.Name = "ArenaReport";
            this.ArenaReport.Size = new System.Drawing.Size(710, 81);
            this.ArenaReport.TabIndex = 3;
            this.ArenaReport.Text = "Отчет по статистике арены";
            this.ArenaReport.UseVisualStyleBackColor = true;
            this.ArenaReport.Click += new System.EventHandler(this.ArenaReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 276);
            this.Controls.Add(this.ArenaReport);
            this.Controls.Add(this.TeamReport);
            this.Controls.Add(this.PlayerStats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayerStats;
        private System.Windows.Forms.Button TeamReport;
        private System.Windows.Forms.Button ArenaReport;
    }
}

