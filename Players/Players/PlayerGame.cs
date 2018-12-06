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
    public partial class PlayerGame : Form
    {
        private int OTID, GTID;

        private int GID;

        private ComboBox[] OwnerComboBox;
        private ComboBox[] GuestComboBox;

        private NumericUpDown[][] OwnerSets;
        private NumericUpDown[][] GuestSets;

        private List<int> OwnerPlayerIDS = new List<int>();
        private List<int> GuestSPlayerIDS = new List<int>();

        public bool OKEY = false;

        public PlayerGame(int game_id)
        {
            this.GID = game_id;

            InitializeComponent();

            DataRow ODR = Server.GetDataTable(Server.CONSTR, "SELECT T.id, T.name FROM TEAM T, GAME G WHERE T.id = G.owner_team_id").Rows[0];
            OwnerTeam.Text = ODR["name"].ToString();
            OTID = Convert.ToInt32(ODR["id"]);

            DataRow GDR = Server.GetDataTable(Server.CONSTR, "SELECT T.id, T.name FROM TEAM T, GAME G WHERE T.id = G.guest_team_id").Rows[0];
            GuestTeam.Text = GDR["name"].ToString();
            GTID = Convert.ToInt32(GDR["id"]);

            OwnerComboBox = new ComboBox[] { comboBox0, comboBox1, comboBox2, comboBox3, comboBox4 };
            GuestComboBox = new ComboBox[] { comboBox5, comboBox6, comboBox7, comboBox8, comboBox9 };

            OwnerSets = new NumericUpDown[5][] { new NumericUpDown[] { numericUpDown0, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7 },
                                                 new NumericUpDown[] { numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15 },
                                                 new NumericUpDown[] { numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23 },
                                                 new NumericUpDown[] { numericUpDown24, numericUpDown25, numericUpDown26, numericUpDown27, numericUpDown28, numericUpDown29, numericUpDown30, numericUpDown31 },
                                                 new NumericUpDown[] { numericUpDown32, numericUpDown33, numericUpDown34, numericUpDown35, numericUpDown36, numericUpDown37, numericUpDown38, numericUpDown39 }
            };

            GuestSets = new NumericUpDown[5][] { new NumericUpDown[] { numericUpDown40, numericUpDown41, numericUpDown42, numericUpDown43, numericUpDown44, numericUpDown45, numericUpDown46, numericUpDown47 },
                                                 new NumericUpDown[] { numericUpDown48, numericUpDown49, numericUpDown50, numericUpDown51, numericUpDown52, numericUpDown53, numericUpDown54, numericUpDown55 },
                                                 new NumericUpDown[] { numericUpDown56, numericUpDown57, numericUpDown58, numericUpDown59, numericUpDown60, numericUpDown61, numericUpDown62, numericUpDown63 },
                                                 new NumericUpDown[] { numericUpDown64, numericUpDown65, numericUpDown66, numericUpDown67, numericUpDown68, numericUpDown69, numericUpDown70, numericUpDown71 },
                                                 new NumericUpDown[] { numericUpDown72, numericUpDown73, numericUpDown74, numericUpDown75, numericUpDown76, numericUpDown77, numericUpDown78, numericUpDown79 }
            };

            UpdateDropDown();
        }

        private void GOON_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OwnerComboBox.Length; i++)
                for (int j = 0; j < OwnerComboBox.Length; j++ )
                    if (i != j && OwnerComboBox[i].SelectedIndex == OwnerComboBox[j].SelectedIndex)
                    {
                        MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

            for (int i = 0; i < GuestComboBox.Length; i++)
                for (int j = 0; j < GuestComboBox.Length; j++)
                    if (i != j && GuestComboBox[i].SelectedIndex == GuestComboBox[j].SelectedIndex)
                    {
                        MessageBox.Show("Введены некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

            for (int i = 0; i < OwnerComboBox.Length; i++)
            {
                string CMD = "INSERT INTO PLAYER_GAME VALUES(" + OwnerPlayerIDS[OwnerComboBox[i].SelectedIndex] + ", " + GID.ToString();
                foreach (NumericUpDown NUD in OwnerSets[i])
                    CMD += ", " + NUD.Value.ToString();
                CMD += ")";
                Server.UpdateDB(Server.CONSTR, CMD);
            }

            for (int i = 0; i < GuestSets.Length; i++)
            {
                string CMD = "INSERT INTO PLAYER_GAME VALUES(" + GuestSPlayerIDS[GuestComboBox[i].SelectedIndex] + ", " + GID.ToString();
                foreach (NumericUpDown NUD in OwnerSets[i])
                    CMD += ", " + NUD.Value.ToString();
                CMD += ")";
                Server.UpdateDB(Server.CONSTR, CMD);
            }

            OKEY = true;
            this.Close();
        }

        private void UpdateDropDown()
        {
            foreach (ComboBox CB in OwnerComboBox)
                CB.Items.Clear();

            foreach (ComboBox CB in GuestComboBox)
                CB.Items.Clear();

            OwnerPlayerIDS.Clear();
            GuestSPlayerIDS.Clear();

            DataTable DTO = Server.GetDataTable(Server.CONSTR, "SELECT * FROM PLAYER WHERE team_id = " + OTID);
            DataTable DTG = Server.GetDataTable(Server.CONSTR, "SELECT * FROM PLAYER WHERE team_id = " + GTID);

            bool OK = true;

            for (int i = 0; i < DTO.Rows.Count; i++) {

                OwnerPlayerIDS.Add(Convert.ToInt32(DTO.Rows[i]["id"]));
                foreach (ComboBox CB in OwnerComboBox) {

                    CB.Items.Add(DTO.Rows[i]["surname"] + " " + DTO.Rows[i]["name"]);
                    if (CB.Items.Count != 0)
                        CB.SelectedIndex = 0;
                    else
                        OK = false;
                }
            }

            for (int i = 0; i < DTG.Rows.Count; i++) {

                GuestSPlayerIDS.Add(Convert.ToInt32(DTG.Rows[i]["id"]));
                foreach (ComboBox CB in GuestComboBox) {

                    CB.Items.Add(DTG.Rows[i]["surname"] + " " + DTG.Rows[i]["name"]);
                    if (CB.Items.Count != 0)
                        CB.SelectedIndex = 0;
                    else
                        OK = false;
                }
            }
        }
    }
}
