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
    public partial class UpdateCoach : Form
    {
        private List<int> CoachIDS = new List<int>();
        private List<int> TeamIDS = new List<int>();

        public UpdateCoach()
        {
            InitializeComponent();

            UpdateDGV();
            UpdateDropDown();
        }

        private void AddCoachButton_Click(object sender, EventArgs e)
        {
            Server.UpdateDB(Server.CONSTR, "UPDATE EX_COACH SET date_finish = TO_DATE('" + DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY') " +
                                                             "WHERE coach_id = " + CoachIDS[CoachName.SelectedIndex] +
                                                             " AND team_id = (SELECT team_id FROM Coach WHERE id = " + CoachIDS[CoachName.SelectedIndex] + ")" +
                                                             " AND date_finish IS NULL");

            Server.UpdateDB(Server.CONSTR, "UPDATE COACH SET team_id = " + TeamIDS[CoachNewTeam.SelectedIndex] + " WHERE id = " + CoachIDS[CoachName.SelectedIndex]);

            Server.UpdateDB(Server.CONSTR, "INSERT INTO EX_COACH VALUES(" + CoachIDS[CoachName.SelectedIndex] + ", " +
                                                                             TeamIDS[CoachNewTeam.SelectedIndex] + ", " +
                                                                             "TO_DATE('" + DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY'), NULL)");

            UpdateDGV();
            MessageBox.Show("Игрок успешно переведен!");
        }

        private void UpdateDropDown() {

            CoachNewTeam.Items.Clear();
            TeamIDS.Clear();

            DataTable DT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            for (int i = 0; i < DT.Rows.Count; i++) {

                CoachNewTeam.Items.Add(DT.Rows[i]["name"]);
                TeamIDS.Add(Convert.ToInt32(DT.Rows[i]["id"]));
            }

            if (CoachNewTeam.Items.Count != 0)
                CoachNewTeam.SelectedIndex = 0;


            CoachName.Items.Clear();
            CoachIDS.Clear();

            DataTable DTP = Server.GetDataTable(Server.CONSTR, "SELECT id, name, surname, team_id FROM COACH");

            for (int i = 0; i < DTP.Rows.Count; i++) {

                CoachName.Items.Add(DTP.Rows[i]["surname"] + " " + DTP.Rows[i]["name"] + " FROM " + CoachNewTeam.Items[Convert.ToInt32(DTP.Rows[i]["team_id"]) - 1].ToString());
                CoachIDS.Add(Convert.ToInt32(DTP.Rows[i]["id"]));
            }

            if (CoachName.Items.Count != 0)
                CoachName.SelectedIndex = 0;

            AddCoachButton.Enabled = CoachName.Items.Count != 0 && CoachNewTeam.Items.Count != 0;
        }

        private void UpdateDGV()
        {
            ExCoachList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT (SELECT CONCAT(CONCAT(P.surname, ' '), P.name) FROM COACH P WHERE P.id = EC.coach_id) AS NAME, " + 
                                                                         "(SELECT T.name FROM TEAM T WHERE T.id = EC.team_id) AS TEAM, " +
                                                                         "EC.date_start AS DS, EC.date_finish AS DF FROM EX_COACH EC");
        }
    }
}
