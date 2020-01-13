<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelecrtBaoFei.aspx.cs" Inherits="Device.SelecrtBaoFei" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <style>
        #list {
        width:622px;
        margin:auto;
        
        
        }
         #list tr td{
        width:120px;
        text-align:center;
        
        
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="text-align:center ;font-weight:bold" >查询设备报废信息</p>
    <p style="text-align:center">设备名称：<asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="126px"></asp:TextBox>
        设备类型：<asp:DropDownList ID="DropDownList1" runat="server" style="width:70px;">
            <asp:ListItem>---请选择---</asp:ListItem>
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
        <p style="text-align:center">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr style="background-color:#00ff21">
                            <td> 设备名称</td>
                            <td> 设备类型</td>
                            <td> 报废日期</td>
                            <td> 报废原由</td>
                            <td> 折扣金额</td>
                            
                        </tr>

                   
                </HeaderTemplate>

                <ItemTemplate>
                   <tr>
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("TypeName") %></td>
                    <td><%#Eval("RejectData") %></td>
                     <td><%#Eval("RejectReason") %></td>
                    <td><%#Eval("Money") %></td>
                  
                        
                   


                   </tr>

                </ItemTemplate>

                <FooterTemplate>
     </table>
                </FooterTemplate>


            </asp:Repeater>
    </p>

        </div>
    </div>
    </form>
</body>
</html>
