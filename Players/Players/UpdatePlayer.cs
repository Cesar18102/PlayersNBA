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
    public partial class UpdatePlayer : Form
    {
        public UpdatePlayer()
        {
            InitializeComponent();

            UpdateDGV();
            UpdateDropDown();
        }

        private List<int> PlayerIDS = new List<int>();
        private List<int> TeamIDS = new List<int>();

        private void UpdateDropDown() {

            PlayerNewTeam.Items.Clear();
            TeamIDS.Clear();

            DataTable DT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            for (int i = 0; i < DT.Rows.Count; i++) {

                PlayerNewTeam.Items.Add(DT.Rows[i]["name"]);
                TeamIDS.Add(Convert.ToInt32(DT.Rows[i]["id"]));
            }

            if (PlayerNewTeam.Items.Count != 0)
                PlayerNewTeam.SelectedIndex = 0;


            PlayerName.Items.Clear();
            PlayerIDS.Clear();

            DataTable DTP = Server.GetDataTable(Server.CONSTR, "SELECT id, name, surname, team_id FROM PLAYER");

            for (int i = 0; i < DTP.Rows.Count; i++) {

                PlayerName.Items.Add(DTP.Rows[i]["surname"] + " " + DTP.Rows[i]["name"] + " FROM " + PlayerNewTeam.Items[Convert.ToInt32(DTP.Rows[i]["team_id"]) - 1].ToString());
                PlayerIDS.Add(Convert.ToInt32(DTP.Rows[i]["id"]));
            }

            if (PlayerName.Items.Count != 0)
                PlayerName.SelectedIndex = 0;

            AddPlayerButton.Enabled = PlayerName.Items.Count != 0 && PlayerNewTeam.Items.Count != 0;
        }

        private void UpdateDGV()
        {
            ExPlayerList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT (SELECT CONCAT(CONCAT(P.surname, ' '), P.name) FROM PLAYER P WHERE P.id = EP.player_id) AS NAME, " + 
                                                                         "(SELECT T.name FROM TEAM T WHERE T.id = EP.team_id) AS TEAM, " + 
                                                                         "EP.date_start AS DS, EP.date_finish AS DF FROM EX_PLAYER EP");
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            Server.UpdateDB(Server.CONSTR, "UPDATE EX_PLAYER SET date_finish = TO_DATE('" + DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY') " + 
                                                             "WHERE player_id = " + PlayerIDS[PlayerName.SelectedIndex] + 
                                                             " AND team_id = (SELECT team_id FROM PLAYER WHERE id = " + PlayerIDS[PlayerName.SelectedIndex] + ")" + 
                                                             " AND date_finish IS NULL");

            Server.UpdateDB(Server.CONSTR, "UPDATE PLAYER SET team_id = " + TeamIDS[PlayerNewTeam.SelectedIndex] + " WHERE id = " + PlayerIDS[PlayerName.SelectedIndex]);

            Server.UpdateDB(Server.CONSTR, "INSERT INTO EX_PLAYER VALUES(" + PlayerIDS[PlayerName.SelectedIndex] + ", " +
                                                                             TeamIDS[PlayerNewTeam.SelectedIndex] + ", " +
                                                                             "TO_DATE('" + DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY'), NULL)");

            UpdateDGV();
            MessageBox.Show("Игрок успешно переведен!");
        }
    }
}
