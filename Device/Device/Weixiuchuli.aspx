<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weixiuchuli.aspx.cs" Inherits="Device.Weixiuchuli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 1300px;
        }
        #list {
        width:649px;
        margin:auto;
        
        
        }
        .auto-style2 {
            width: 868px;
        }
        .auto-style3 {
            width: 41px;
        }
        .auto-style4 {
            width: 1300px;
            height: 39px;
        }
        .auto-style5 {
            width: 868px;
            height: 39px;
        }
        .auto-style6 {
            width: 41px;
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p style="color:#a8dc27">欢迎您：<br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        </p>
    <p style="text-align:center;font-weight:bold "> 设备维修处理</p>
        <div id="list">
            <table style="width: 661px">
            <tr>
                <td class="auto-style1">设备名称：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
               <td class="auto-style2">设备类型：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                <td rowspan="2" class="auto-style3"><asp:Image ID="Image1" runat="server" Height="64px" ImageUrl="#" style="margin-left: 57px" Width="74px" /></td>
                    
            </tr>
             <tr>
                <td class="auto-style1">送修地点：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                 </td>
                <td class="auto-style2">维修人员：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </td>
                <td></td>
            </tr>
              <tr>
                <td class="auto-style4">故障原因：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  </td>
                <td class="auto-style5">维修日期：<asp:TextBox ID="TextBox3" runat="server" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
                  </td>
                 <td class="auto-style6"></td>
            </tr>
              <tr>
                <td class="auto-style1">维修费用：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>元
                  </td>
                <td class="auto-style2">维修费时：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>工时
                  </td>
                 <td class="auto-style3"></td>
            </tr>
                <tr>
                    <td colspan="2">
                        备注：<asp:TextBox ID="TextBox6" runat="server" Height="59px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="提交" style="margin-left:100px;" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="返回" style="margin-left:100px;" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
