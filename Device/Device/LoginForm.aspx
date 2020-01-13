<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Device.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Css/Share.css" rel="stylesheet" />
    <style type="text/css">
        #login{
           width:350px;
           border:1px solid #808080;               
           margin:auto;
           padding:20px;
           margin-top:200px;
           background-color:#98e931;
         
        }
       
        #login p {
            margin:10px;
            width: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="BtnLogin">
    <div id="login">
    <p>用&nbsp;&nbsp; 户：<asp:TextBox ID="Name" runat="server" style="width:100px"></asp:TextBox></p>
    <p>密&nbsp;&nbsp; 码：<asp:TextBox ID="Pwd" runat="server" TextMode="Password" style="width:100px"></asp:TextBox></p>
    <p>
          验 证 码 ：<asp:TextBox ID="Code" runat="server" style="width:100px"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/RandCode.aspx" />
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server"
            NavigateUrl="~/LoginForm.aspx">看不清换张图</asp:HyperLink>
      
    </p>
    <asp:Button ID="BtnLogin" runat="server" Text="登录" OnClick="Button1_Click" Style="height: 28px;width:80px;" />
     
    <input type="button" style="height: 28px;width:80px;margin-left:50px;" onclick="window.close()"  value="取消" />
    </div>
    </form>
</body>
</html>
