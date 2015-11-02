using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DatabaseLayer
    {
        private string conn = ConfigurationManager.ConnectionStrings["scheduler_database"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();
        }
    }
}
