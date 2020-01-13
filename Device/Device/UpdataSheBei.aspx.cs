using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace Device
{
    public partial class UpdataSheBei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



                  this.TextBox1.Text = "" + Request["Name"].ToString();
                  this.TextBox3.Text=Request["xinghao"].ToString ();
                  this.TextBox4.Text = "" + Request["pingpai"].ToString();
               
                


            this.Image1.ImageUrl = "Images/2.jpg";

            List<SheBeiType> list1 = TypeManger.select();
            foreach (SheBeiType sb1 in list1)
            {
                ListItem li1 = new ListItem();
                li1.Value = sb1.TypeId.ToString();
                li1.Text = sb1.Typename;
                this.DropDownList1.Items.Add(li1);
            }
            }

           

        



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            shebei sb = new shebei();
            sb.Name = this.TextBox1.Text;
            if (this.DropDownList1.SelectedItem.Text == "常用类")
            {
                sb.Typeid = 1;
            }
            if (this.DropDownList1.SelectedItem.Text == "普通类")
            {
                sb.Typeid = 2;
            }
            if (this.DropDownList1.SelectedItem.Text == "其他类")
            {
                sb.Typeid = 3;
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
                this.Image1.ImageUrl = sb.Url;
            }

            this.TextBox2.Text = sb.Url;
            if ( ShebeiManger.update(sb))
            {
                Response.Write("<script>alert('更新成功！')</script>");
            }
           
        }
    }
}