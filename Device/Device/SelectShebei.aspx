<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectShebei.aspx.cs" Inherits="Device.SelectShebei" %>

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
      table tr:hover {
        background-color:#00ff21;
        
        
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="text-align:center ;font-weight:bold" >查询设备信息</p>
    <p style="text-align:center">设备名称：<asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        设备类型：<asp:DropDownList ID="DropDownList1" runat="server" style="width:70px;">
           
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
                            <td> 设备状态</td>
                            <td> 设备品牌</td>
                            <td> 设备型号</td>
                            <td> 购买时间</td>
                            <td> 操作</td>
                        </tr>

                   
                </HeaderTemplate>

                <ItemTemplate>
                   <tr >
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("TypeName") %></td>
                     <td><%#Eval("State") %></td>
                    <td><%#Eval("Pinpai") %></td>
                     <td><%#Eval("Xinghao") %></td>
                    <td><%#Eval("Shopdata") %></td>
                     <td><a href="UpdataSheBei.aspx?Name=<%#Eval("Name") %>&&typename=<%#Eval("TypeName") %>&&pingpai=<%#Eval("Pinpai") %>&&xinghao=<%#Eval("Xinghao") %> ">详情</a></td>
                       
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
