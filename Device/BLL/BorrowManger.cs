using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;


namespace BLL
{
 public   class BorrowManger
    {

     public static bool insert(Borrow br) {
         string sql = string.Format("insert into Borrow values({0},{1},'{2}','{3}','{4}',{5})",br.SheBeiID,br.TypeID ,br.Borrower,br.BorrowDepartment,br.BorrowData,br.BorrowTime);

         return DBHelper.ExecutNonQuery(sql);

     
     }
     public static List<Borrow> select() {
         string sql = string.Format("select Name ,TypeName,BorrowDepartment,Borrower,BorrowData,BorrowTime from Shebei,SheBeiType,Borrow where Shebei.Typeid=SheBeiType.TypeId and Borrow.SheBeiID=Shebei.ID");
         DataTable dt = DBHelper.ExecutReader(sql);
         List<Borrow> list = new List<Borrow>();
         foreach (DataRow dr in dt.Rows)
         {
             Borrow br = new Borrow();
             br.Name = dr["Name"].ToString();
             br.TypeName = dr["TypeName"].ToString();
             br.Borrower = dr["Borrower"].ToString();
             br.BorrowDepartment = dr["BorrowDepartment"].ToString();
             br.BorrowTime = dr["BorrowTime"].ToString();
             br.BorrowData = dr["BorrowData"].ToString();
             list.Add(br);
         }
         return list;
     
     }
     public static List<Borrow> select(string name,string typename)
     {
        
         string sql = string.Format("select Name ,TypeName,BorrowDepartment,Borrower,BorrowData,BorrowTime from Shebei,SheBeiType,Borrow where Shebei.Typeid=SheBeiType.TypeId and Borrow.SheBeiID=Shebei.ID  ", name);
         if (name!="")
         {
              sql += string.Format(" and name='{0}'",name);
         }
        if (typename!="---请选择---")
	{
		    sql += string.Format("and TypeName='{0}'", typename);


	}
         
         DataTable dt = DBHelper.ExecutReader(sql);
         List<Borrow> list = new List<Borrow>();
         foreach (DataRow dr in dt.Rows)
         {
             Borrow br = new Borrow();
             br.Name = dr["Name"].ToString();
             br.TypeName = dr["TypeName"].ToString();
             br.Borrower = dr["Borrower"].ToString();
             br.BorrowDepartment = dr["BorrowDepartment"].ToString();
             br.BorrowTime = dr["BorrowTime"].ToString();
             br.BorrowData = dr["BorrowData"].ToString();
             list.Add(br);
         }
         return list;

     }
 }

}
