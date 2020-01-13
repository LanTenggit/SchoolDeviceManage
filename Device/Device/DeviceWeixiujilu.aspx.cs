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
    public partial class DeviceWeixiujilu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Label1.Text=""+Session["Name"].ToString();
            if (!IsPostBack)
            {
                List<shebei> list = ShebeiManger.select();
                foreach (shebei sb in list)
                {
                    ListItem li = new ListItem();
                    li.Value = sb.ID.ToString();
                    li.Text = sb.Name;
                    this.DropDownList1.Items.Add(li);
                }

                List<SheBeiType> list1 = TypeManger.select();
                foreach (SheBeiType sb1 in list1)
                {
                    ListItem li1 = new ListItem();
                    li1.Value = sb1.TypeId.ToString();
                    li1.Text = sb1.Typename;
                    this.DropDownList2.Items.Add(li1);
                }



            }
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Serice sc = new Serice();
            sc.shebeiID = 1;


            sc.DeviceType  = 0;
            int id=0;
            if (this.DropDownList1.SelectedItem.Text == "电脑")
            {
                sc.shebeiID = 1;
            }
            if (this.DropDownList1.SelectedItem.Text == "手机")
            {
                sc.shebeiID = 2;
            }
            if (this.DropDownList1.SelectedItem.Text == "自行车")
            {
                sc.shebeiID = 3;
            }
            if (this.DropDownList1.SelectedItem.Text == "小汽车")
            {
                sc.shebeiID = 1;
            }
            if (this.DropDownList2.SelectedItem.Text=="常用类")
            {
                sc.DeviceType= 1;
            }
            if (this.DropDownList2.SelectedItem.Text == "空闲类")
            {
                sc.DeviceType = 2;
            }
            if (this.DropDownList2.SelectedItem.Text == "其他类")
            {
                sc.DeviceType = 3;
            }
           
            sc.Weixiuer= this.TextBox1.Text;

           sc.Area= this.TextBox2.Text;
            sc.Guzhang= this.TextBox3.Text;
            sc.WeixiuData = this.TextBox4.Text;
            sc.Beizu = this.TextBox5.Text;
           
            //string url = null;
            //string usertime=null;
            //string money = null;

            if (SericeManger.add(sc))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('提交成功！ ')</script>");
            } 
        }
        //联播
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (this.DropDownList2.SelectedItem.Text== "常用类")
            {
                id = 1;
            }
            if (this.DropDownList2.SelectedItem.Text == "普通类")
            {
                id = 2;
            }
            if (this.DropDownList2.SelectedItem.Text == "其他类")
            {
                id = 3;
            }
           
            this.DropDownList1.DataSource = SericeManger.getlist(id);
             List<shebei> list = SericeManger.getlist(id);
             this.DropDownList1.DataSource = list;
             this.DropDownList1.DataTextField = "Name";
             this.DropDownList1.DataValueField = "ID";
             this.DropDownList1.DataBind();
            // foreach (shebei item in list)
            //{
            //      this.DropDownList1.DataTextField = "" +item.Name;

            //      this.DropDownList1.DataValueField = ""+item.ID;
            //}

         

           
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }


    }
}