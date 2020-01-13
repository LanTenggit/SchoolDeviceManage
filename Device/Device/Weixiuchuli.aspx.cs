using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace Device
{
    public partial class Weixiuchuli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
            this.Label2.Text= Request["name"].ToString();
            this.Label3.Text = Request["type"].ToString();
            this.Label4.Text = Request["area"].ToString();
            this.TextBox1.Text=Request["weier"].ToString();
            this.TextBox2.Text = Request["guzhang"].ToString();
            }
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Serice sc = new Serice();
            sc.Name = Request["name"].ToString();

            List<shebei> list = ShebeiManger.select(sc.Name);
            foreach (shebei item in list)
            {
                sc.shebeiID = item.ID;
            }

            
            
            if (Request["type"].ToString()=="常用类")
            {
                sc.DeviceType = 1;  
            }
            if (Request["type"].ToString() == "普通类")
            {
                sc.DeviceType = 2;
            }
            if (Request["type"].ToString() == "其他类")
            {
                sc.DeviceType = 3;
            }
            sc.Area = Request["area"].ToString();
           
            sc.Weixiuer = this.TextBox1.Text;
            sc.Guzhang = this.TextBox2.Text;
            sc.WeixiuData = this.TextBox3.Text;
            sc.Money = this.TextBox4.Text;
            sc.UseTime = this.TextBox5.Text;
            sc.Beizu = this.TextBox6.Text;
            sc.Url = "Images/";
            if (SericeManger.add(sc))
            {
               
                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('提交成功！ ')</script>");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectWeiXiu.aspx");
        }
    }
}