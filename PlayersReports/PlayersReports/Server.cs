using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace PlayersReports
{
    public static class Server
    {
        public static string CONSTR = "Data Source = (DESCRIPTION = " +
                                                "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                                                "(CONNECT_DATA = " +
                                                    "(SERVER = DEDICATED)" +
                                                    "(SERVICE_NAME = orcl)" +
                                                ")" +
                                          ");User Id=SYSTEM;password=Player228;";

        public static DataTable GetDataTable(string CSTR, string QUERY)
        {
            OracleConnection OC = new OracleConnection(CONSTR);
            OC.Open();

            OracleDataAdapter ODA = new OracleDataAdapter();
            ODA.SelectCommand = new OracleCommand(QUERY, OC);

            DataTable DT = new DataTable();
            ODA.Fill(DT);

            OC.Close();

            return DT;
        }

        public static void UpdateDB(string CSTR, string QUERY)
        {
            OracleConnection OC = new OracleConnection(CONSTR);
            OC.Open();

            OracleCommand OCMD = new OracleCommand(QUERY, OC);
            OCMD.CommandType = CommandType.Text;

            OCMD.ExecuteNonQuery();

            OC.Close();
        }
    }
}
