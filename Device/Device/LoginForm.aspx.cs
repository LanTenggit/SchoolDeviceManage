using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Model;

namespace Device
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string name = this.Name.Text;
            string pwd = this.Pwd.Text;

            if (name == "" || pwd == "")
            {

                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('用户名或密码不能为空！ ')</script>");
            
            }
            else {
          List<admin>list =adminManger.pipei(name);
          foreach (admin item in list)
          {
              if (item.Pwd == pwd)
              {
                  string code = Code.Text;

                  string oldCode = Session["checkCode"].ToString();

                  if (code.Trim() == oldCode.Trim())
                  {
                      ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('登录成功！ ')</script>");

                      Session["Name"] = name;
                      Response.Redirect("Main.aspx");
                  }
              }
              else {

                  ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('密码错误！ ')</script>");
              
              }
           
          }

          if (list.Count == 0)
          {
             
 ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('不存在用户！ ')</script>");

          }
         
            
            }
         
            
        

         
      



        }

      
    }
}