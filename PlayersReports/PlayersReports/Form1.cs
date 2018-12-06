using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System.IO;

namespace PlayersReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Word.Application Application;
        private Word.Document Document;
        private Word.Range R;
        private Word.Table T;
        private Word.Paragraph P;
        private Object missingObj = System.Reflection.Missing.Value;
        private Object trueObj = true;
        private Object falseObj = false;

        public delegate string ValueAt<Q>(Q SP, int i);

        private void PlayerStats_Click(object sender, EventArgs e) {

            PrintWord(Server.GetDataTable(Server.CONSTR, "SELECT (SELECT CONCAT(CONCAT(PL.surname, ' '), PL.name) FROM PLAYER PL WHERE PL.id = P.id) AS NAME, " +
                                                                "AVG(PG.throws) AS AVG_THROWS, AVG(PG.points) AS AVG_POINTS, " + 
                                                                "AVG(PG.passes) AS AVG_PASSES, AVG(PG.pickups) AS AVG_PICKUPS, " + 
                                                                "AVG(PG.blockshots) AS AVG_BLOCKSHOTS, AVG(PG.intercepts) AS AVG_INTERCEPTS, " + 
                                                                "AVG(PG.faults) AS AVG_FAULTS, AVG(PG.misses) AS AVG_MISSES " + 
                                                                "FROM PLAYER P, PLAYER_GAME PG WHERE P.id = PG.player_id GROUP BY P.id"), "Статистика по игрокам");
        }

        private void TeamReport_Click(object sender, EventArgs e) {

            DataTable DTT = Server.GetDataTable(Server.CONSTR, "SELECT * FROM TEAM");

            DataTable TSTAT = new DataTable();
            TSTAT.Columns.Add("TEAM_NAME");
            TSTAT.Columns.Add("WINS");
            TSTAT.Columns.Add("LOSES");
            TSTAT.Columns.Add("DRAWS");

            for (int i = 0; i < DTT.Rows.Count; i++)
            {
                string id = DTT.Rows[i]["id"].ToString();
                string name = DTT.Rows[i]["name"].ToString();

                DataTable DTWIN = Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(COUNT(G.id), 0) AS WINS " +
                                                                     "FROM GAME G " +
                                                                     "WHERE (G.owner_team_id = " + id + " AND " +
                                                                     "SUBSTR(G.scores, 0, INSTR(G.scores, ':') - 1) > SUBSTR(G.scores, INSTR(G.scores, ':') + 1)) OR " + 
                                                                     "(G.guest_team_id = " + id + " AND " +
                                                                     "SUBSTR(G.scores, 0, INSTR(G.scores, ':') - 1) < SUBSTR(G.scores, INSTR(G.scores, ':') + 1))");

                DataTable DTLOSE = Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(COUNT(G.id), 0) AS LOSES " +
                                                                      "FROM GAME G " +
                                                                      "WHERE (G.owner_team_id = " + id + " AND " +
                                                                      "SUBSTR(G.scores, 0, INSTR(G.scores, ':') - 1) < SUBSTR(G.scores, INSTR(G.scores, ':') + 1)) OR " +
                                                                      "(G.guest_team_id = " + id + " AND " +
                                                                      "SUBSTR(G.scores, 0, INSTR(G.scores, ':') - 1) > SUBSTR(G.scores, INSTR(G.scores, ':') + 1))");

                DataTable DTDRAW = Server.GetDataTable(Server.CONSTR, "SELECT COALESCE(COUNT(G.id), 0) AS DRAWS " +
                                                                      "FROM GAME G " +
                                                                      "WHERE (G.owner_team_id = " + id + " OR " +
                                                                      "G.guest_team_id = " + id + ") AND " +
                                                                      "SUBSTR(G.scores, 0, INSTR(G.scores, ':') - 1) = SUBSTR(G.scores, INSTR(G.scores, ':') + 1)");

                TSTAT.Rows.Add(name, DTWIN.Rows[0]["WINS"].ToString(), DTLOSE.Rows[0]["LOSES"].ToString(), DTDRAW.Rows[0]["DRAWS"]);
            }

            PrintWord(TSTAT, "Статистика по командам");
        }

        private void ArenaReport_Click(object sender, EventArgs e) {

            PrintWord(Server.GetDataTable(Server.CONSTR, "SELECT G.place, SUM(PG.throws) AS SUM_THROWS, SUM(PG.points) AS SUM_POINTS, " +
                                                                          "SUM(PG.passes) AS SUM_PASSES, SUM(PG.pickups) AS SUM_PICKUPS, " +
                                                                          "SUM(PG.blockshots) AS SUM_BLOCKSHOTS, SUM(PG.intercepts) AS SUM_INTERCEPTS, " +
                                                                          "SUM(PG.faults) AS SUM_FAULTS, SUM(PG.misses) AS SUM_MISSES " + 
                                                                          "FROM GAME G, PLAYER_GAME PG " +
                                                                          "WHERE PG.game_id = G.id " + 
                                                                          "GROUP BY G.place"), "Статистика по аренам");
        }

        private void PrintWord(DataTable DT, string head) {

            this.UseWaitCursor = true;
            FileStream FS = File.Create(Environment.CurrentDirectory + "/Print.doc");
            FS.Close();

            Application = new Word.Application();
            Object PrintPath = Environment.CurrentDirectory + "/Print.doc";

            Document = Application.Documents.Add(ref PrintPath, ref missingObj, ref missingObj, ref missingObj);
            Document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            R = Document.Sections[1].Range;

            T = Document.Tables.Add(R, DT.Rows.Count + 2, DT.Columns.Count, missingObj, missingObj);
            T.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            T.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            T.Rows[1].Cells.Merge();
            T.Rows[1].Cells[1].Width = 698;
            T.Rows[1].Cells[1].Range.Text = head;
            T.Rows[1].Cells[1].Range.Font.Size = 18;
            T.Rows[1].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            T.Rows[1].Cells[1].Range.Borders.Enable = 0;

            for (int i = 1; i <= DT.Columns.Count; i++) {

                T.Rows[2].Cells[i].Width = 700 / DT.Columns.Count;
                T.Rows[2].Cells[i].Range.Text = DT.Columns[i - 1].ColumnName;

                T.Rows[2].Cells[i].Range.Font.Size = 14;
                T.Rows[2].Cells[i].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (int i = 0; i < DT.Rows.Count; i++)
                for (int j = 0; j < DT.Columns.Count; j++) {

                    T.Rows[i + 3].Cells[j + 1].Width = 700 / DT.Columns.Count;
                    T.Rows[i + 3].Cells[j + 1].Range.Text = DT.Rows[i][j].ToString();

                    if (i % 2 == 0)
                        T.Rows[i + 3].Cells[j + 1].Shading.BackgroundPatternColor = Word.WdColor.wdColorGray20;
                }

            Document.Save();
            Document.Close(missingObj, missingObj, missingObj);
            this.UseWaitCursor = false;
        }
    }
}
