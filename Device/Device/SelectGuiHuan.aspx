<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectGuiHuan.aspx.cs" Inherits="Device.SelectGuiHuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <style>

          tr td {
        width:100px;
        padding:8px;
        text-align:center;
        
        
        }
        #list {
        width:800px;
        margin:auto;
        
        
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <p style="text-align:center ;font-weight:bold" >查询归还信息</p>
    <p style="text-align:center">设备名称：<asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        设备类型：<asp:DropDownList ID="DropDownList1" runat="server" style="width:70px;">
            <asp:ListItem>常用类</asp:ListItem>
            <asp:ListItem>普通类</asp:ListItem>
            <asp:ListItem>其他类</asp:ListItem>
        </asp:DropDownList>
        开始日期:<asp:TextBox ID="TextBox2" runat="server" style="width:80px;" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
        结束日期：<asp:TextBox ID="TextBox3" runat="server" style="width:80px;" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
       <a href="Main.aspx">返回首页</a> 
    </p>
        <div id="list">



            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr style="background-color:#00ff21">
                            <td>
                                设备名称
                            </td>
                             <td>
                                设备类型
                            </td>
                             <td>
                                接触部门
                            </td>
                             <td>
                                借出人
                            </td>
                             <td>
                                借出时间
                            </td>
                             <td>
                                借出天数
                            </td>
                              <td>
                                操作
                            </td>

                        </tr>
                    
                </HeaderTemplate>
                <ItemTemplate>
                    <tr >
                      
                        <td>
                              <%#Eval("Name") %>
                            </td>
                             <td>
                                <%#Eval("TypeName") %>
                            </td>
                             <td>
                                <%#Eval("BorrowDepartment") %>
                            </td>
                             <td>
                                <%#Eval("Borrower") %>
                            </td>
                             <td>
                                <%#Eval("BorrowData") %>
                            </td>
                             <td>
                                <%#Eval("BorrowTime") %>
                            </td>
                              <td>
                                <a href="SheBeiReturn.aspx">归还</a>
                            </td>
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
