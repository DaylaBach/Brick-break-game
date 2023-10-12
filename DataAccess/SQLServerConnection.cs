using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreak.DataAccess
{
    class SQLServerConnection
    {
        private static string strcon = "server=localhost;database=BrickBreak;uid=bach;pwd=654321;MultipleActiveResultSets=true";
        public static string StringConnection
        {
            get
            {
                return strcon;
            }
        }
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                return con;
            }
        }
    }
}
