using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Players
{
    public partial class AddPlayer : Form
    {

        private List<int> TeamIDS = new List<int>();

        public AddPlayer()
        {
            InitializeComponent();

            PlayerRole.SelectedIndex = 0;

            UpdateDGV();
            UpdateDropDown();
        }

        private void UpdateDropDown()
        {
            PlayerTeam.Items.Clear();
            TeamIDS.Clear();

            DataTable DT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            for (int i = 0; i < DT.Rows.Count; i++) {

                PlayerTeam.Items.Add(DT.Rows[i]["name"]);
                TeamIDS.Add(Convert.ToInt32(DT.Rows[i]["id"]));
            }

            if (PlayerTeam.Items.Count != 0)
                PlayerTeam.SelectedIndex = 0;

            AddPlayerButton.Enabled = PlayerTeam.Items.Count != 0;

        }

        private void UpdateDGV()
        {
            PlayerList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT * FROM PLAYER");
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (PlayerName.Text == "" || PlayerSurname.Text == "" || PlayerCitizenship.Text == "")
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int PlayerID = Convert.ToInt32(Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(MAX(id), 0) + 1 AS id FROM PLAYER").Rows[0]["id"]);
    
            Server.UpdateDB(Server.CONSTR, "INSERT INTO PLAYER VALUES(" + PlayerID.ToString() + ", '" +
                                           PlayerSurname.Text + "', '" + PlayerName.Text + "', '" + PlayerFathername.Text + "', TO_DATE('" +
                                           PlayerBirth.Value.ToShortDateString() + "', 'DD.MM.YYYY'), '" + PlayerCitizenship.Text + "', " +
                                           PlayerHeight.Value.ToString() + ", " + PlayerWeight.Value.ToString() + ", '" +
                                           PlayerRole.Items[PlayerRole.SelectedIndex].ToString() + "', " + PlayerNum.Value.ToString() + ", " +
                                           TeamIDS[PlayerTeam.SelectedIndex] + ")");

            Server.UpdateDB(Server.CONSTR, "INSERT INTO EX_PLAYER VALUES(" + PlayerID.ToString() + ", " +
                                           TeamIDS[PlayerTeam.SelectedIndex] + ", TO_DATE('" + 
                                           DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY'), NULL)");

            UpdateDGV();
            MessageBox.Show("Игрок успешно добавлен!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
