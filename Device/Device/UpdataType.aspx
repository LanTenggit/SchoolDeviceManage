<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdataType.aspx.cs" Inherits="Device.UpdataType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="color:#a8dc27">欢迎您：<br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        </p>
    <p style="text-align:center;font-weight:bold "> 修改设备类型</p>
         <p style="text-align:center"><span style="color:#2288ea">添加设备类型</span>：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="更新" OnClick="Button1_Click" />
        <a href="GuanliDevice.aspx" style="color:red">返回</a>
        </p>
    </div>
    </form>
</body>
</html>
