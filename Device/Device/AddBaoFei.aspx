<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBaoFei.aspx.cs" Inherits="Device.AddBaoFei" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>


    <style>
        #b {
        width:1100px;
        
        }

        #content {
        width:550px;
        margin: 0 auto;
      
        
        
        }


    </style>
</head>
<body style="width: 529px">
    <form id="form1" runat="server">
    <div id="b">
     <div id="content">
    <table>
        <caption>报废设备登记</caption>
       <tr>
           <td>选择设备：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="129px"></asp:DropDownList></td>
       </tr>
       <tr>
           <td>设备类型：<asp:DropDownList ID="DropDownList2" runat="server" Width="130px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
       </tr>
        <tr>
           <td>折旧金额：<asp:TextBox ID="btnprice" runat="server"></asp:TextBox></td>
           <td>报废日期：<asp:TextBox ID="btntime" runat="server" CssClass="datepicker" onclick="WdatePicker()"></asp:TextBox></td>

       </tr>
          <tr>
           <td>报废原因：<asp:TextBox ID="btnwhy" runat="server" Height="96px" TextMode="MultiLine" Width="205px"></asp:TextBox></td>         
       </tr>
    </table>
 <p style="text-align:center"><asp:Button ID="BtnTJ" runat="server" Text="提交" OnClick="BtnTJ_Click" />
            <a href="Main.aspx">返回首页</a></p>
    </div>
         
           
       
    </div>
    </form>
</body>
</html>
