using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
using DAL;
using System.Data;

namespace BLL
{
   public class TypeManger
    {
       public static List<SheBeiType> select() {

           string sql = "select * from SheBeiType";
        DataTable dt = DBHelper.ExecutReader(sql);
        List<SheBeiType> list = new List<SheBeiType>();
        foreach (DataRow dr in dt.Rows)
        {
            SheBeiType ty = new SheBeiType();
            ty.TypeId = (int)dr["TypeId"];
            ty.Typename = dr["Typename"].ToString();
            list.Add(ty);
        }
        return list;

       }

       public static bool insert(string  st) {
           string sql = string.Format("insert  into SheBeiType values('{0}')",st);
           return DBHelper.ExecutNonQuery(sql);
       }
       public static bool delete(int id) {
           string sql = string.Format("delete from SheBeiType where TypeId={0}",id);
           return DBHelper.ExecutNonQuery(sql);
       
       
       
       }

       public static bool update(string name,int id)
       {
           string sql = string.Format("update  SheBeiType set TypeName='{0}'where TypeId={1}", name,id);
           return DBHelper.ExecutNonQuery(sql);
       }  

    }
}
