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
    public partial class SheBeiReturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            Returns re = new Returns();
            if (this.DropDownList1.SelectedItem.Text == "电脑")
            {
                re.SheBeiID = 1;
            }
            if (this.DropDownList1.SelectedItem.Text == "手机")
            {
                re.SheBeiID = 2;
            }
            if (this.DropDownList1.SelectedItem.Text == "自行车")
            {
                re.SheBeiID = 3;
            }
            if (this.DropDownList1.SelectedItem.Text == "小汽车")
            {
                re.SheBeiID = 4;
            }

            if (this.DropDownList2.SelectedItem.Text == "常用类")
            {
                re.typeId = 1;
            }
            if (this.DropDownList2.SelectedItem.Text == "普通类")
            {
                re.typeId = 2;
            }
            if (this.DropDownList2.SelectedItem.Text == "其他类")
            {
                re.typeId = 3;
            }

            re.Worker = this.TextBox1.Text;
            re.BorrowDepartment = this.TextBox2.Text;
            re.BorrowTime = int.Parse(this.TextBox4.Text);
            re.BorrowData= this.TextBox4.Text;
            re.ReturnData = this.TextBox5.Text;
            if (  ReturnsManger.insert(re))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('归还成功！ ')</script>");  
            }

          


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}