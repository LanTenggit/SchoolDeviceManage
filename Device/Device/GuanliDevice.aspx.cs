using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace Device
{
    public partial class GuanliDevice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        this.Label1.Text=""+Session["Name"];

        this.Repeater1.DataSource = BLL.TypeManger.select();
        this.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string s = this.TextBox1.Text;
           TypeManger.insert(s);
           Response.Redirect("GuanliDevice.aspx");
        }
    }
}