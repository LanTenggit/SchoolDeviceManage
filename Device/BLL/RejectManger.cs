using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;
using DAL;
using System.Data.Sql;

namespace BLL
{
  public  class RejectManger
    {
      public static bool insert(Reject re){
          string sql = string.Format(" insert into Reject values({0},{1},'{2}','{3}','{4}')",re.ShebeiID,re.Type,re.Money,re.RejectData,re.RejectReason);
       return DBHelper.ExecutNonQuery(sql);
      
      }

      public static List<Reject> select() {
          string sql = string.Format(" select * from Reject,SheBeiType,Shebei where Reject.ShebeiID=Shebei.ID and SheBeiType.TypeId=Shebei.Typeid ");

          DataTable dt = DBHelper.ExecutReader(sql);
          List<Reject> list = new List<Reject>();
          foreach (DataRow dr in dt.Rows)
          {
              Reject sc = new Reject();
              sc.Name = dr["Name"].ToString();
              sc.TypeName = dr["TypeName"].ToString();
              sc.ShebeiID = (int)dr["ShebeiID"];
              sc.Type =(int) dr["ShebeiID"];
              sc.Money = dr["Money"].ToString();
              sc.RejectData = dr["RejectData"].ToString();
              sc.RejectReason = dr["RejectReason"].ToString();
              
              list.Add(sc);
          }
          return list;
      
      }
      public static List<Reject> select(string name,string typename)
      {
          string sql = string.Format(" select * from Reject,SheBeiType,Shebei where Reject.ShebeiID=Shebei.ID and SheBeiType.TypeId=Shebei.Typeid ");
          if (name!="")
          {
              sql += string.Format("and name='{0}'", name);
          }
          if (typename!="---请选择---")
          {
               sql += string.Format("and TypeName='{0}'", typename);
          }
          
         
          DataTable dt = DBHelper.ExecutReader(sql);
          List<Reject> list = new List<Reject>();
          foreach (DataRow dr in dt.Rows)
          {
              Reject sc = new Reject();
              sc.Name = dr["Name"].ToString();
              sc.TypeName = dr["TypeName"].ToString();
              sc.ShebeiID = (int)dr["ShebeiID"];
              sc.Type = (int)dr["ShebeiID"];
              sc.Money = dr["Money"].ToString();
              sc.RejectData = dr["RejectData"].ToString();
              sc.RejectReason = dr["RejectReason"].ToString();

              list.Add(sc);
          }
          return list;

      }
    }
}
