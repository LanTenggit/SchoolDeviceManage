using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
  public   class ReturnsManger
    {
      public static bool insert(Returns re) {
          string sql = string.Format("insert into Returns values({0},{1},'{2}','{3}',{4},'{5}','{6}')",re.SheBeiID,re.typeId,re.Worker,re.BorrowDepartment,re.BorrowTime,re.BorrowData,re.ReturnData);
          return DBHelper.ExecutNonQuery(sql);

      
      }


    }
}
