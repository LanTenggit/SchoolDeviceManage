using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
 public   class SericeManger
    {
        public static List<shebei> getlist(int id) {
            string sql = string.Format("select * from Shebei where typeid={0}", id);
            DataTable dt = DBHelper.ExecutReader(sql);
            List<shebei> list = new List<shebei>();
            foreach (DataRow dr in dt.Rows)
            {
                shebei sb = new shebei();
                sb.ID = (int)dr["ID"];
                sb.Name = dr["Name"].ToString();
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
        public static bool add(Serice sc )
        {
            string sql = string.Format("insert into Serice values({0},{1},'{2}','{3}','{4}','{5}','{6}','null','null','null')", sc.shebeiID, sc.DeviceType, sc.Weixiuer, sc.Area, sc.Guzhang, sc.WeixiuData, sc.Beizu);
              
            return DBHelper.ExecutNonQuery(sql);
        
        }
        public static List<Serice> select()
        {
            string sql = string.Format(" select Shebei.Name,SheBeiType.TypeName,Area,Weixiuer,WeixiuData,Guzhang from Shebei,SheBeiType,Serice where Shebei.Typeid=SheBeiType.TypeId and Serice.shibeiID=Shebei.ID");
            DataTable dt = DBHelper.ExecutReader(sql);
            List<Serice> list = new List<Serice>();
            foreach (DataRow dr in dt.Rows)
            {
                Serice sc = new Serice();
                sc.Name = dr["Name"].ToString();
                sc.TypeName = dr["TypeName"].ToString();
                sc.Area = dr["Area"].ToString();
                sc.Weixiuer = dr["Weixiuer"].ToString();
                sc.WeixiuData = dr["WeixiuData"].ToString();
                sc.Guzhang = dr["Guzhang"].ToString();
                list.Add(sc);
            }
            return list;
        }
        public static List<Serice> select(string name ,string type)
        {
            string sql = string.Format(" select Shebei.Name,SheBeiType.TypeName,Area,Weixiuer,WeixiuData,Guzhang from Shebei,SheBeiType,Serice where Shebei.Typeid=SheBeiType.TypeId and  Serice.shibeiID=Shebei.ID ");
            if (name!="")
            {
                  sql +=string.Format("and Shebei.Name='{0}'",name);
            }
            if (type == "----请选择类型----")
            {
               
            }
            else { 
             sql += string.Format("and SheBeiType.TypeName='{0}'", type);
            
            }
          
            DataTable dt = DBHelper.ExecutReader(sql);
            List<Serice> list = new List<Serice>();
            foreach (DataRow dr in dt.Rows)
            {
                Serice sc = new Serice();
                sc.Name = dr["Name"].ToString();
                sc.TypeName = dr["TypeName"].ToString();
                sc.Area = dr["Area"].ToString();
                sc.Weixiuer = dr["Weixiuer"].ToString();
                sc.WeixiuData = dr["WeixiuData"].ToString();
                sc.Guzhang = dr["Guzhang"].ToString();
                list.Add(sc);
            }
            return list;
        }
        public static bool insert(Serice sc) {
            string sql = string.Format("insert into Serice values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", sc.DeviceType,sc.Weixiuer,sc.Area,sc.Guzhang,sc.WeixiuData,sc.Beizu,sc.Url,sc.UseTime,sc.Money);
            return DBHelper.ExecutNonQuery(sql);
        
        }
    }
}
