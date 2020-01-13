using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class adminManger
    {
        public static List<admin> pipei(string  name) {
            string sql = string.Format("select * from admin where name='{0}'", name);
            DataTable dt = DBHelper.ExecutReader(sql);
            List<admin>list=new List<admin>();
            foreach (DataRow dr in dt.Rows)
            {
                admin ad = new admin();
                ad.ID = (int)dr["ID"];
                ad.Age = (int)dr["Age"];
                ad.Name = dr["Name"].ToString();
                ad.Pwd = dr["Pwd"].ToString();
                ad.Sex = dr["Sex"].ToString();
                list.Add(ad);
            }

            return list;
        }


        public static bool updata(string a,string b){
            string sql = string.Format("update admin set pwd='{0}'where name='{1}'",a,b);
        return DBHelper.ExecutNonQuery(sql);
        }

    }
}
