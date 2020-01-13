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
    public partial class SelectShebei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
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
                this.DropDownList1.Items.Insert(0,"----请选择类型----");
            }
           
           
            this.Repeater1.DataSource = ShebeiManger.select();
            this.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            string name = this.TextBox1.Text;
            string type = this.DropDownList1.SelectedItem.Text;
            string datatime = this.TextBox2.Text;
            this.Repeater1.DataSource = ShebeiManger.selectlist(name, type, datatime);
            this.DataBind();
        }
    }
}