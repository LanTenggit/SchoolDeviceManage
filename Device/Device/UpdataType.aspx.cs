using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace Device
{
    public partial class UpdataType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             

                this.TextBox1.Text = "" + Request["name"].ToString();

               
            }
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //this.TextBox1.Text = "";
             string  name = this.TextBox1.Text;
             ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('"+name+" ')</script>");
             int id = int.Parse(Request["id"]);
             TypeManger.update(name, id);
        }
    }
}