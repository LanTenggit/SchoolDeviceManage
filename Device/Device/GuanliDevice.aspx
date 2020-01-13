<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuanliDevice.aspx.cs" Inherits="Device.GuanliDevice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #list {
        width:800px;
        margin:auto;
        
        }
        tr td {
       text-align:center;
            width:200px;

            
             }
    </style>


</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1181px">
    
        欢迎您：<br />
        <br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        <br />
        <br />
        <p style="text-align:center;font-weight:bold ">
            管理设备类型
        </p>
        <div id="list">
           <asp:Repeater ID="Repeater1" runat="server" >
               <HeaderTemplate>
                   <table>
                       <tr style="background-color:#a1d420">
                           <td>设备类型编号</td>
                           <td>设备类型名称</td>
                           <td>操作</td>
                            <td>操作</td>
                       </tr>
               </HeaderTemplate>

               <ItemTemplate>
                   <tr>
                       <td><%#Eval("TypeId")%></td>
                        <td><%#Eval("TypeName")%></td>
                       <td><a href="UpdataType.aspx?name=<%#Eval("TypeName")%>&&id=<%#Eval("TypeId")%>">修改</a></td>
                         <td><a href="DeleteType.aspx?Id=<%#Eval("TypeId")%>" onclick="return confirm('确认操作')">删除</a></td>
                   </tr>
               </ItemTemplate>


               <FooterTemplate>
              </table>
               </FooterTemplate>

            </asp:Repeater>
        </div>

    <p style="text-align:center"><span style="color:#2288ea">添加设备类型</span>：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
        <a href="Main.aspx" style="color:red">返回首页</a>
        </p>
    </div>
    </form>
</body>
</html>
