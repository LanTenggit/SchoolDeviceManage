<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceWeixiujilu.aspx.cs" Inherits="Device.DeviceWeixiujilu" %>

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


    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <p style="color:#a8dc27">欢迎您：<br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        </p>
    <p style="text-align:center ;font-weight:bold">添加设备维修记录</p>


         <br />
        <div id="list">
<table style="width: 693px">
    <tr>

        <td>
            <asp:Label ID="Label2" runat="server" Text="选择设备："></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
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
           <asp:Label ID="Label4" runat="server" Text="维修人员："></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
       <td>
           <asp:Label ID="Label5" runat="server" Text="维修地点："></asp:Label>
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
      <tr>
       <td>
           <asp:Label ID="Label6" runat="server" Text="故障原因："></asp:Label>
           <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
          </td>
       <td>
           <asp:Label ID="Label7" runat="server" Text="维修日期："></asp:Label>
           <asp:TextBox ID="TextBox4" runat="server" onclick="WdatePicker()" class="datepicker"></asp:TextBox>
          </td>
    </tr>
      <tr>
       <td colspan="2">
           备注：<asp:TextBox ID="TextBox5" runat="server" Height="122px" TextMode="MultiLine" Width="444px"></asp:TextBox>
           <br />
          </td>
       
    </tr>
    <tr>

<td colspan="3" style="text-align:center">

    <asp:Button ID="Button1" runat="server" Text="提交" style="margin-right:100px;" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />

</td>
    </tr>
</table>

        </div>


    </div>
    </form>
</body>
</html>
