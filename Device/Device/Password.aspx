<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Password.aspx.cs" Inherits="Device.Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        * {
        padding:0px;
        margin:0px;
        
        
        }
        #top {
        height:50px;
        width:1300px;
        margin:auto;
        
        }
        #uppwd {
        height:300px;
        width:500px;
        margin:auto;
        }
        table {
       border-top:1px solid black;
       border-left:1px solid black;
        }
        td {
           border-right:1px solid black;
             border-bottom:1px solid black;
      
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="top">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </div>
        <div id="uppwd">


           <p style="text-align:center"> <asp:Label ID="Label2" runat="server" Text="修改密码" ></asp:Label></p>
            <br />
          <table cellspacing="0" cellpadding="0">
              <tr>
                  <td>
                      请输入修改密码：
                  </td>
                  <td>
                     
                      <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox><asp:Label ID="Label3" runat="server" ></asp:Label>
                      </span>
                     
                      </span>
                     
                  &nbsp;</td>
              </tr>

              <tr>
                   <td>
                      请确认修改密码：
                  </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
              </tr>
              <tr>
                  <td colspan="3" style="text-align:center">
                      <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /><a href="Main.aspx">返回首页</a>
                  </td>
              </tr>
          </table>


        </div>
    </div>
    </form>
</body>
</html>
