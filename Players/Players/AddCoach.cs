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
    public partial class AddCoach : Form
    {
        private List<int> TeamIDS = new List<int>();

        public AddCoach()
        {
            InitializeComponent();

            UpdateDGV();
            UpdateDropDown();
        }

        private void AddCoachButton_Click(object sender, EventArgs e)
        {
            if (CoachName.Text == "" || CoachSurname.Text == "" || CoachCitizenship.Text == "")
            {
                MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CoachID = Convert.ToInt32(Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(MAX(id), 0) + 1 AS id FROM COACH").Rows[0]["id"]);

            Server.UpdateDB(Server.CONSTR, "INSERT INTO Coach VALUES(" + CoachID.ToString() + ", '" +
                                           CoachSurname.Text + "', '" + CoachName.Text + "', '" + CoachFathername.Text + "', TO_DATE('" +
                                           CoachBirth.Value.ToShortDateString() + "', 'DD.MM.YYYY'), '" + CoachCitizenship.Text + "', " +
                                           TeamIDS[CoachTeam.SelectedIndex] + ")");

            Server.UpdateDB(Server.CONSTR, "INSERT INTO EX_COACH VALUES(" + CoachID.ToString() + ", " +
                                           TeamIDS[CoachTeam.SelectedIndex] + ", TO_DATE('" +
                                           DateTime.Now.ToShortDateString() + "', 'DD.MM.YYYY'), NULL)");

            UpdateDGV();
            MessageBox.Show("Тренер успешно добавлен!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDropDown()
        {
            CoachTeam.Items.Clear();
            TeamIDS.Clear();

            DataTable DT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            for (int i = 0; i < DT.Rows.Count; i++)
            {

                CoachTeam.Items.Add(DT.Rows[i]["name"]);
                TeamIDS.Add(Convert.ToInt32(DT.Rows[i]["id"]));
            }

            if (CoachTeam.Items.Count != 0)
                CoachTeam.SelectedIndex = 0;

            AddCoachButton.Enabled = CoachTeam.Items.Count != 0;

        }

        private void UpdateDGV()
        {
            CoachList.DataSource = Server.GetDataTable(Server.CONSTR, "SELECT * FROM COACH");
        }
    }
}
