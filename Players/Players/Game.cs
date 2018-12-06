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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            UpdateDGV();
            UpdateDropDown();
        }

        private List<int> TeamIDS = new List<int>();

        private void AddGame_Click(object sender, EventArgs e)
        {
            if (Place.Text == "" || OwnerTeam.SelectedIndex == GuestTeam.SelectedIndex)
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int GameID = Convert.ToInt32(Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(MAX(id), 0) + 1 AS id FROM GAME").Rows[0]["id"]);

            Server.UpdateDB(Server.CONSTR, "INSERT INTO GAME VALUES(" + GameID.ToString() + ", " + TeamIDS[OwnerTeam.SelectedIndex] + ", " +
                                                                          TeamIDS[GuestTeam.SelectedIndex] + ", '" + Place.Text + "', TO_DATE('" +
                                                                          Date.Value.ToShortDateString() + "', 'DD.MM.YYYY'), " +
                                                                          "TO_TIMESTAMP('" + Time.Value.ToShortTimeString() + "', 'HH24:MI'), " +
                                                                          "'" + OwnerScore.Value.ToString() + ":" + GuestScore.Value.ToString() + "')");

            UpdateDGV();

            PlayerGame PG = new PlayerGame(GameID);

            do
            {
                PG.ShowDialog();
            }
            while (!PG.OKEY);

            MessageBox.Show("Игра успешно добавлена!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDropDown()
        {
            OwnerTeam.Items.Clear();
            GuestTeam.Items.Clear();
            TeamIDS.Clear();

            DataTable DT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            for (int i = 0; i < DT.Rows.Count; i++) {

                OwnerTeam.Items.Add(DT.Rows[i]["name"]);
                GuestTeam.Items.Add(DT.Rows[i]["name"]);
                TeamIDS.Add(Convert.ToInt32(DT.Rows[i]["id"]));
            }

            if (OwnerTeam.Items.Count != 0)
                OwnerTeam.SelectedIndex = 0;

            if (GuestTeam.Items.Count != 0)
                GuestTeam.SelectedIndex = 0;

            AddGame.Enabled = OwnerTeam.Items.Count != 0 && GuestTeam.Items.Count != 0;

        }

        private void UpdateDGV()
        {
            GameList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT G.id, (SELECT name FROM TEAM T WHERE T.id = G.owner_team_id) AS OWNER_TEAM, " + 
                                                                                "(SELECT name FROM TEAM T WHERE T.id = G.guest_team_id) AS GUEST_TEAM, " +
                                                                                "G.place, G.game_date, G.scores FROM GAME G");
        }
    }
}
