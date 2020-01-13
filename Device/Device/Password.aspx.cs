using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace Device
{
    public partial class Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = "欢迎您："+Session["Name"];
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pwd=this.TextBox1.Text;

            if (pwd=="")
            {
                this.Label3.Text = "修改密码不能为空！";
            }
            string pwd1 = this.TextBox2.Text;
            string name=Session["Name"].ToString();
            if (pwd == pwd1)
            {
                if ( adminManger.updata(pwd, name))
                {
                     ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('提交成功！ ')</script>");
            
                }
                  
               
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('两次密码不同！ ')</script>");
            
            }



           


        }
    }
}