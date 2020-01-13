using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr1"].ConnectionString;

        private static SqlConnection conn = null;

        public static SqlConnection Conn
        {
            get 
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connStr);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                return DBHelper.conn; 
            }
        }

        //查
        public static DataTable ExecutReader(string sql)
        {
            DataTable dt = new DataTable();

            new SqlDataAdapter(new SqlCommand(sql, Conn)).Fill(dt);

            return dt;
        }
        //增删改
        public static bool ExecutNonQuery(string sql)
        {
            return new SqlCommand(sql, Conn).ExecuteNonQuery() > 0;
        }
    }
}
