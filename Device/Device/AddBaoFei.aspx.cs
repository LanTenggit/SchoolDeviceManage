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
    public partial class AddBaoFei : System.Web.UI.Page
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

        protected void BtnTJ_Click(object sender, EventArgs e)
        {
            Reject re = new Reject();
          
            int id = 0;
            if (this.DropDownList1.SelectedItem.Text=="电脑")
            {
                re.ShebeiID = 1;
            }
            if (this.DropDownList1.SelectedItem.Text == "手机")
            {
                re.ShebeiID = 2;
            }
            if (this.DropDownList1.SelectedItem.Text == "自行车")
            {
                re.ShebeiID = 3;
            }
            if (this.DropDownList1.SelectedItem.Text == "小汽车")
            {
                re.ShebeiID = 4;
            }

            int typeid = 0;
            if (this.DropDownList2.SelectedItem.Text == "常用类")
            {
                re.Type = 1;
            }
            if (this.DropDownList2.SelectedItem.Text == "普通类")
            {
                re.Type = 2;
            }
            if (this.DropDownList2.SelectedItem.Text == "其他类")
            {
                re.Type = 3;
            }
           
            re.Money  = this.btnprice.Text;
            re.RejectData= this.btntime.Text;
            re.RejectReason = this.btnwhy.Text;
            if (RejectManger.insert(re))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "loginSucess", "<script>alert('添加成功！ ')</script>");
            }
            
            //RejectManger.insert(re.ShebeiID, re.Type, re.Money, re.RejectData, re.RejectReason);

        }
    }
}