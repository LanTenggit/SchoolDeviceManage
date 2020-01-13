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
    public partial class SelectGuiHuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownList1.Items.Insert(0,"---请选择---");
            }
            this.Repeater1.DataSource = BorrowManger.select();
            this.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            string type = this.DropDownList1.SelectedItem.Text;
            this.Repeater1.DataSource = BorrowManger.select(name,type);
            this.DataBind();
        }
    }
}