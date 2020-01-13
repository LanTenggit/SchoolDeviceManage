using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Device
{
    public partial class DeleteType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id =int.Parse(Request["Id"]) ;
            TypeManger.delete(id);
            Response.Redirect("GuanliDevice.aspx");
        }
    }
}