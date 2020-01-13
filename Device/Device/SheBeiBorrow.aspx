<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SheBeiBorrow.aspx.cs" Inherits="Device.SheBeiBorrow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <style>

        #list{
        width:800px;
        margin:auto;
        
        
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p style="text-align:center ;font-weight:bold" >设备借出登记</p>
      <div id="list">
<table style="width: 693px">
    <tr>

        <td>
            <asp:Label ID="Label2" runat="server" Text="选择设备："></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
       <td>
           <asp:Label ID="Label3" runat="server" Text="设备类型："></asp:Label>
           <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
             
           </asp:DropDownList>
        </td>
       <td rowspan="2">
           <asp:Image ID="Image1" runat="server" Width="66px" />
        </td>
    </tr>
    <tr>
       <td>
           <asp:Label ID="Label4" runat="server" Text="借用人："></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
       <td>
           <asp:Label ID="Label5" runat="server" Text="借用部门："></asp:Label>
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
      <tr>
       <td>
           借用日期：<asp:TextBox ID="TextBox3" runat="server"  onclick="WdatePicker()" class="datepicker"></asp:TextBox>
          </td>
       
    </tr>
    <tr>
        <td>
  借用天数：<asp:TextBox ID="TextBox4" runat="server"  > </asp:TextBox>天
          </td>
    </tr>
     
    <tr>

<td colspan="3" style="text-align:center">
    <a href="Main.aspx">返回首页</a>
    <asp:Button ID="Button1" runat="server" Text="借出" style="margin-right:100px;" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" />

</td>
    </tr>
</table>

        </div>
    </div>
    </form>
</body>
</html>
