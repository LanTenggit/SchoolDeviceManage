using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
  public class ShebeiManger
    {
      public static List<shebei> select() {
          string sql = string.Format("select * from Shebei,SheBeiType where Shebei.typeid=SheBeiType.TypeId");
          DataTable dt = DBHelper.ExecutReader(sql);
          List<shebei> list = new List<shebei>();
          foreach (DataRow dr in dt.Rows)
          {
              
              shebei sb = new shebei();
              sb.ID = (int)dr["ID"];
              sb.Name = dr["Name"].ToString();
              sb.TypeName = dr["TypeName"].ToString();
              sb.State = dr["State"].ToString();
              sb.XulieNumber = dr["XulieNumber"].ToString();
              sb.Xinghao = dr["Xinghao"].ToString();
              sb.Pinpai = dr["Pinpai"].ToString();
              sb.Shopdata = dr["Shopdata"].ToString();
              sb.Factory = dr["Factory"].ToString();
              sb.Outdata = dr["Outdata"].ToString();
              sb.Url = dr["Url"].ToString();
              sb.Beizu =dr["Beizu"].ToString();
              list.Add(sb) ;
             
          }
          return list;
      
      }
      public static List<shebei> selectlist(string name,string typename,string datatime) {
          string sql = string.Format("select * from Shebei,SheBeiType where Shebei.typeid=SheBeiType.TypeId ");
          if (name!="")
          {
               sql += string.Format("and Name='{0}'",name);
          }
          if (typename != "----请选择类型----")
          {
              sql += string.Format("and TypeName='{0}'", typename);
          }
          if (datatime!="")
          {
               sql += string.Format("and Shopdata>='{0}'", datatime);
          }

          DataTable dt = DBHelper.ExecutReader(sql);
          List<shebei> list = new List<shebei>();
          foreach (DataRow dr in dt.Rows)
          {
              shebei sb = new shebei();
              sb.ID = (int)dr["ID"];
              sb.Name = dr["Name"].ToString();
              sb.TypeName = dr["TypeName"].ToString();
              sb.State = dr["State"].ToString();
              sb.XulieNumber = dr["XulieNumber"].ToString();
              sb.Xinghao = dr["Xinghao"].ToString();
              sb.Pinpai = dr["Pinpai"].ToString();
              sb.Shopdata = dr["Shopdata"].ToString();
              sb.Factory = dr["Factory"].ToString();
              sb.Outdata = dr["Outdata"].ToString();
              sb.Url = dr["Url"].ToString();
              sb.Beizu = dr["Beizu"].ToString();
              list.Add(sb);
          }
       return list;
      }
      public static List<shebei> select(string name) {
          string sql = string.Format("select ID from Shebei where  name='{0}'", name);
          DataTable dt = DBHelper.ExecutReader(sql);
          List<shebei> list = new List<shebei>();
          foreach (DataRow dr in dt.Rows)
          {
              shebei sb = new shebei();

              sb.ID = (int)dr["ID"];
              //sb.Name = dr["Name"].ToString();
              //sb.TypeName = dr["TypeName"].ToString();
              //sb.State = dr["State"].ToString();
              //sb.XulieNumber = dr["XulieNumber"].ToString();
              //sb.Xinghao = dr["Xinghao"].ToString();
              //sb.Pinpai = dr["Pinpai"].ToString();
              //sb.Shopdata = dr["Shopdata"].ToString();
              //sb.Factory = dr["Factory"].ToString();
              //sb.Outdata = dr["Outdata"].ToString();
              //sb.Url = dr["Url"].ToString();
              //sb.Beizu = dr["Beizu"].ToString();
              list.Add(sb);
          }
          return list;
      
      }

      public static bool insert(shebei sb) {
          string sql = string.Format("insert into Shebei values('{0}',{1},'空闲','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", sb.Name, sb.Typeid, sb.XulieNumber, sb.Xinghao, sb.Pinpai, sb.Shopdata, sb.Factory, sb.Outdata, sb.Url, sb.Beizu);
             
        return  DBHelper.ExecutNonQuery(sql);
        
      }
      public static bool update(shebei sb) {
          string sql = string.Format("update  Shebei set Name='{0}',Typeid={1},State='{2}',XulieNumber='{3}',Xinghao='{4}',Pinpai='{5}',Shopdata='{6}',Factory='{7}',Outdata='{8}',Url='{9}',Beizu='{10}' where Name='{11}'"
              ,sb.Name,sb.Typeid,sb.State,sb.XulieNumber,sb.Xinghao,sb.Pinpai,sb.Shopdata,sb.Factory,sb.Outdata,sb.Url,sb.Beizu,sb.Name);
          return DBHelper.ExecutNonQuery(sql);
      
      }

    }
}
