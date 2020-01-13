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
    public partial class SelecrtBaoFei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = RejectManger.select();
            this.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            string type = this.DropDownList1.SelectedItem .Text;
            this.Repeater1.DataSource = RejectManger.select(name,type);
            this.DataBind();
        }
    }
}