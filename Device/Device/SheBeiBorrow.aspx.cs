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
    public partial class SheBeiBorrow : System.Web.UI.Page
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
 {
     Borrow br = new Borrow();
     if (this.DropDownList1.SelectedItem .Text =="电脑")
     {
         br.SheBeiID = 1;  
     }
     if (this.DropDownList1.SelectedItem.Text == "手机")
     {
         br.SheBeiID = 2;
     }
     if (this.DropDownList1.SelectedItem.Text == "自行车")
     {
         br.SheBeiID = 3;
     }
     if (this.DropDownList1.SelectedItem.Text == "小汽车")
     {
         br.SheBeiID = 4;
     }

     if (this.DropDownList2.SelectedItem.Text == "常用类")
     {
         br.TypeID = 1;
     }
     if (this.DropDownList2.SelectedItem.Text == "普通类")
     {
         br.TypeID = 2;
     }
     if (this.DropDownList2.SelectedItem.Text == "其他类")
     {
         br.TypeID = 3;
     }
     br.Borrower = this.TextBox1.Text;
     br.BorrowDepartment = this.TextBox2.Text;
     br.BorrowData = this.TextBox3.Text;
     br.BorrowTime = this.TextBox4.Text;

     if (  BorrowManger.insert(br))
     {
          ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('借出成功！ ')</script>");  
     }
          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}