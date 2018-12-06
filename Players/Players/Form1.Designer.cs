namespace Players
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
            this.AddTeam = new System.Windows.Forms.Button();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.AddCoach = new System.Windows.Forms.Button();
            this.AddGame = new System.Windows.Forms.Button();
            this.UpdatePlayer = new System.Windows.Forms.Button();
            this.UpdateCoach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTeam
            // 
            this.AddTeam.Location = new System.Drawing.Point(15, 34);
            this.AddTeam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(528, 42);
            this.AddTeam.TabIndex = 0;
            this.AddTeam.Text = "Регистрация команды";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(15, 88);
            this.AddPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(528, 42);
            this.AddPlayer.TabIndex = 1;
            this.AddPlayer.Text = "Регистрация игрока";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // AddCoach
            // 
            this.AddCoach.Location = new System.Drawing.Point(15, 196);
            this.AddCoach.Margin = new System.Windows.Forms.Padding(6);
            this.AddCoach.Name = "AddCoach";
            this.AddCoach.Size = new System.Drawing.Size(528, 42);
            this.AddCoach.TabIndex = 2;
            this.AddCoach.Text = "Регистрация тренера";
            this.AddCoach.UseVisualStyleBackColor = true;
            this.AddCoach.Click += new System.EventHandler(this.AddCoach_Click);
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(15, 304);
            this.AddGame.Margin = new System.Windows.Forms.Padding(6);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(528, 42);
            this.AddGame.TabIndex = 3;
            this.AddGame.Text = "Регистрация игры";
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // UpdatePlayer
            // 
            this.UpdatePlayer.Location = new System.Drawing.Point(15, 142);
            this.UpdatePlayer.Margin = new System.Windows.Forms.Padding(6);
            this.UpdatePlayer.Name = "UpdatePlayer";
            this.UpdatePlayer.Size = new System.Drawing.Size(528, 42);
            this.UpdatePlayer.TabIndex = 4;
            this.UpdatePlayer.Text = "Перевод игрока";
            this.UpdatePlayer.UseVisualStyleBackColor = true;
            this.UpdatePlayer.Click += new System.EventHandler(this.UpdatePlayer_Click);
            // 
            // UpdateCoach
            // 
            this.UpdateCoach.Location = new System.Drawing.Point(15, 250);
            this.UpdateCoach.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateCoach.Name = "UpdateCoach";
            this.UpdateCoach.Size = new System.Drawing.Size(528, 42);
            this.UpdateCoach.TabIndex = 5;
            this.UpdateCoach.Text = "Перевод тренера";
            this.UpdateCoach.UseVisualStyleBackColor = true;
            this.UpdateCoach.Click += new System.EventHandler(this.UpdateCoach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 376);
            this.Controls.Add(this.UpdateCoach);
            this.Controls.Add(this.UpdatePlayer);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.AddCoach);
            this.Controls.Add(this.AddPlayer);
            this.Controls.Add(this.AddTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Button AddCoach;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button UpdatePlayer;
        private System.Windows.Forms.Button UpdateCoach;


    }
}

