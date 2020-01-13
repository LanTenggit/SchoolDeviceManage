<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectWeiXiu.aspx.cs" Inherits="Device.SelectWeiXiu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <style>
        #list {
        width:700px;
        margin:auto;
        
        }
            #list tr td {
            text-align:center;
            width:100px;
            
            }
        td:horizontal tr {
        
        background-color:#16c414;
        
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="color:#a8dc27">欢迎您：<br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        </p>
    <p style="text-align:center;font-weight:bold "> 查询设备维修</p>
        <p style="text-align:center">

            <asp:Label ID="Label2" runat="server" Text="设备名称："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="width:80px;"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="设备类型："></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="width:80px;">
            </asp:DropDownList>
            <asp:Label ID="Label4" runat="server" Text="开始日期："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="width:80px;" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="结束日期："></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="width:80px;" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" style="width:80px;" OnClick="Button1_Click" />
            <a href="Main.aspx">返回首页</a>
        </p>
        <div id="list">



            <a href="SelectWeiXiu.aspx"></a><asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr style="background-color:#16c414">
                            <td>设备名称</td>
                            <td>设备类型</td>
                            <td>送修处</td>
                             <td>维修人员</td>
                            <td>维修日期</td>
                            <td>故障原因</td>
                             <td>操作</td>
                        </tr>
                </HeaderTemplate>
              
                <ItemTemplate>
                  <tr>
                           <td><%#Eval("Name") %></td>
                            <td><%#Eval("TypeName") %></td>
                            <td><%#Eval("Area") %></td>
                             <td><%#Eval("Weixiuer") %></td>
                            <td><%#Eval("WeixiuData") %></td>
                            <td><%#Eval("Guzhang") %></td>
                             <td><a href="Weixiuchuli.aspx?name=<%#Eval("Name") %>&&type=<%#Eval("TypeName") %>&&area=<%#Eval("Area") %>&&weier=<%#Eval("Weixiuer") %>&&guzhang=<%#Eval("Guzhang") %>">维修处理</a></td>
                 </tr>
                </ItemTemplate>
                <FooterTemplate>
              </table>
                </FooterTemplate>

            </asp:Repeater>



        </div>
    </div>
    </form>
</body>
</html>
