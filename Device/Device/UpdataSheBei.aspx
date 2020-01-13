<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdataSheBei.aspx.cs" Inherits="Device.UpdataSheBei" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <script src="My97DatePicker/WdatePicker.js"></script>

    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
        #list {
        width:1000px;
        margin:auto;
        }
       #list tr td {
        /*margin-right:1000px;*/    
            width:200px;
            padding-left:200px;
            
      }
</style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     <p style="color:#a8dc27">欢迎您：<br /><asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066"></asp:Label>
        </p>
    <p style="text-align:center;font-weight:bold "> 更新设备信息</p>
      
<div id="list">
    <table>
        <tr>
            <td>
             <asp:Label ID="Label2" runat="server" Text="设备名称："></asp:Label> <asp:TextBox ID="TextBox1" runat="server" style="width:100px;"></asp:TextBox>
            </td>  
             <td>
                <asp:Label ID="Label3" runat="server" Text="设备类型："></asp:Label> 
                 <asp:DropDownList ID="DropDownList1" runat="server" style="width:100px;" >
                    
                 </asp:DropDownList>
            </td>
        </tr>

         <tr>
            <td class="auto-style1">
             <asp:Label ID="Label4" runat="server" Text="设备型号："></asp:Label> <asp:TextBox ID="TextBox3" runat="server"  style="width:100px;"></asp:TextBox>
            </td>  
             <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="设备牌名："></asp:Label> <asp:TextBox ID="TextBox4" runat="server"  style="width:100px;"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>
             <asp:Label ID="Label6" runat="server" Text="设备序号："></asp:Label> <asp:TextBox ID="TextBox5" runat="server"  style="width:100px;"></asp:TextBox>
            </td>  
             <td>
                <asp:Label ID="Label7" runat="server" Text="生产厂家："></asp:Label> <asp:TextBox ID="TextBox6" runat="server"  style="width:100px;"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
             <asp:Label ID="Label8" runat="server" Text="出场时间："></asp:Label> <asp:TextBox ID="TextBox7" runat="server" onclick="WdatePicker()" class="datepicker" style="width:100px;"></asp:TextBox>
            </td>  
             <td>
                <asp:Label ID="Label9" runat="server" Text="购买时间："></asp:Label> <asp:TextBox ID="TextBox8" runat="server" onclick="WdatePicker()" class="datepicker" style="width:100px;"></asp:TextBox>
            </td>
        </tr>

      

    </table>



</div>
<div style="width:600px; margin:auto ;margin-top:100px;">
    <table>
   <tr>
            <td>
             <asp:Label ID="Label13" runat="server" Text="上传图片："></asp:Label> 
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </td> 
       <td rowspan="2">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/1.jpg"  Width="88px"/>
       </td>

   </tr>
      <tr>
          
             <td>
                <asp:Label ID="Label14" runat="server" Text="图片路径:"></asp:Label>&nbsp;<asp:TextBox ID="TextBox2" runat="server"  style="width:100px;"> </asp:TextBox>
             
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label15" runat="server" Text="备注："></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server" Height="82px" TextMode="MultiLine" Width="296px"></asp:TextBox>

              

            </td>
        </tr>
</table>

     <asp:Button ID="Button1" runat="server" Text="提交"  style="margin-left:100px; height: 21px;" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="取消"  style="margin-left:100px;"/><a href="Main.aspx" style="color:red">返回首页</a>
</div>

    </div>
    </form>
</body>
</html>
