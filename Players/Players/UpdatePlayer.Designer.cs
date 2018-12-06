namespace Players
{
    partial class UpdatePlayer
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
            this.PlayerName = new System.Windows.Forms.ComboBox();
            this.PlayerNewTeam = new System.Windows.Forms.ComboBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExPlayerList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExPlayerList)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerName.FormattingEnabled = true;
            this.PlayerName.Location = new System.Drawing.Point(117, 12);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(264, 32);
            this.PlayerName.TabIndex = 30;
            // 
            // PlayerNewTeam
            // 
            this.PlayerNewTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerNewTeam.FormattingEnabled = true;
            this.PlayerNewTeam.Location = new System.Drawing.Point(117, 50);
            this.PlayerNewTeam.Name = "PlayerNewTeam";
            this.PlayerNewTeam.Size = new System.Drawing.Size(264, 32);
            this.PlayerNewTeam.TabIndex = 31;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(12, 88);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(369, 69);
            this.AddPlayerButton.TabIndex = 32;
            this.AddPlayerButton.Text = "Перевести игрока";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Команда: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Игрок: ";
            // 
            // ExPlayerList
            // 
            this.ExPlayerList.AllowUserToAddRows = false;
            this.ExPlayerList.AllowUserToDeleteRows = false;
            this.ExPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExPlayerList.Location = new System.Drawing.Point(390, 12);
            this.ExPlayerList.Margin = new System.Windows.Forms.Padding(6);
            this.ExPlayerList.Name = "ExPlayerList";
            this.ExPlayerList.ReadOnly = true;
            this.ExPlayerList.RowHeadersVisible = false;
            this.ExPlayerList.Size = new System.Drawing.Size(454, 145);
            this.ExPlayerList.TabIndex = 33;
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 172);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.PlayerNewTeam);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExPlayerList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UpdatePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePlayer";
            ((System.ComponentModel.ISupportInitialize)(this.ExPlayerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlayerName;
        private System.Windows.Forms.ComboBox PlayerNewTeam;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ExPlayerList;
    }
}