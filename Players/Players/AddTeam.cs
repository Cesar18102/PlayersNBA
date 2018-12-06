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
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
            TeamList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (TeamName.Text == "" || TeamCountry.Text == "" || TeamCity.Text == "" ||
               TeamConf.Text == "" || TeamArena.Text == "" || TeamColors.Text == "")
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Server.UpdateDB(Server.CONSTR, "INSERT INTO TEAM VALUES((SELECT COALESCE(MAX(id), 0) + 1 AS id FROM TEAM), '" + TeamName.Text + 
                                                                     "', TO_DATE('" + TeamDateStart.Value.ToShortDateString() + "', 'DD.MM.YYYY'), '" + 
                                                                     TeamCountry.Text + "', '" + TeamCity.Text + "', '" + TeamConf.Text + "', '" + 
                                                                     TeamArena.Text + "', '" + TeamColors.Text + "')");

            TeamList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            MessageBox.Show("Команда успешно добавлена!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
