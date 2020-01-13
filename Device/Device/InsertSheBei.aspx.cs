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
    public partial class InsertSheBei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text=""+Session["Name"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            shebei sb = new shebei();
            sb.Name = this.TextBox1.Text;
            if ( this.DropDownList1.Text=="常用类")
            {
                sb.Typeid = 1; 
            }
            if (this.DropDownList1.Text == "普通类")
            {
                sb.Typeid = 1;
            }
            if (this.DropDownList1.Text == "其他类")
            {
                sb.Typeid = 1;
            }
            sb.Xinghao = this.TextBox3.Text;
            sb.Pinpai = this.TextBox4.Text;
            sb.XulieNumber = this.TextBox5.Text;
            sb.Shopdata = this.TextBox7.Text;
            sb.Outdata = this.TextBox8.Text;
            sb.Factory = this.TextBox6.Text;

            if (FileUpload2.HasFile)
            {
                string filename = FileUpload2.FileName;
                string ex = filename.Substring(filename.LastIndexOf("."));
                string newfilename = DateTime.Now.Ticks.ToString() + new Random().Next(100000, 1000000) + ex;
                string path = Server.MapPath("/") + "Images/";
                FileUpload2.SaveAs(path + newfilename);
                this.TextBox2.Text = "Images/" + newfilename;
                sb.Url = "Images/" + newfilename;
               sb.Beizu = this.TextBox11.Text;
               if ( ShebeiManger.insert(sb))
               {
                   ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('添加成功！ ')</script>");  
               }
                
               
            }

           

           
        }
    }
}