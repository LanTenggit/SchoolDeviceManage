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
    public partial class SelectWeiXiu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Label1.Text=""+Session["Name"].ToString();
            this.Repeater1.DataSource = SericeManger.select();
            this.DataBind();
            if (!IsPostBack)
            {
                List<SheBeiType> list1 = TypeManger.select();
                foreach (SheBeiType sb1 in list1)
                {
                    ListItem li1 = new ListItem();
                    li1.Value = sb1.TypeId.ToString();
                    li1.Text = sb1.Typename;
                    this.DropDownList1.Items.Add(li1);
                }
                this.DropDownList1.Items.Insert(0, "----请选择类型----");
            }
            //Response.Redirect("");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            string type = this.DropDownList1.SelectedItem.Text;
            this.Repeater1.DataSource = SericeManger.select(name,type);
            this.DataBind();
        }
    }
}