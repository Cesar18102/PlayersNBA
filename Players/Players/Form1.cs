using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Players
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            AddTeam AT = new AddTeam();
            AT.ShowDialog();
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer AP = new AddPlayer();
            AP.ShowDialog();
        }

        private void UpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayer UP = new UpdatePlayer();
            UP.ShowDialog();
        }

        private void AddCoach_Click(object sender, EventArgs e)
        {
            AddCoach AC = new AddCoach();
            AC.ShowDialog();
        }

        private void UpdateCoach_Click(object sender, EventArgs e)
        {
            UpdateCoach UC = new UpdateCoach();
            UC.ShowDialog();
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            Game G = new Game();
            G.ShowDialog();
        }
    }
}
