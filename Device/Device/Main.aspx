<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Device.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        * {
        margin:0px;
        padding:0px;
        }
        #top {
        height:300px;
        width:1300px;
        margin:auto;
        background-color:#c1f231;
        margin-top:100px;

        }
        #toplist> ul >li {
      float:left;
      margin-left:50px;
            
              }
        ul li  {
        list-style:none;
        height:39px;
       line-height:39px;
       width:100px;
        
        }
        a {
    text-decoration:none;
        
        }
        #toplist {
       background-color:#b6ff00;
            width:1100px;
            height:39px;
            margin:auto;
             }
        #erji {
        position:relative;
      
        
        }
       #erjilist {
            text-align:center;
           width:auto;
           height:auto;
           position:absolute;
                top:39px;
                left:0px;
                display:none;
                background-color:#b4f808;
                 }
        #erji:hover #erjilist  {
        display:block;
        
        
        }


         #sheguan {
        position:relative;
      
        
        }
       #sheguanlist {
           text-align:center;
           width:auto;
           height:auto;
           position:absolute;
                top:39px;
                left:0px;
                display:none;
                background-color:#b4f808;
                 }
        #sheguan:hover #sheguanlist  {
        display:block;
        
        
        }
           #shexiu {
        position:relative;
        }
       #shexiulist {
            text-align:center;
           width:auto;
           height:auto;
           position:absolute;
                top:39px;
                left:0px;
                display:none;
                background-color:#b4f808;
                 }
        #shexiu:hover #shexiulist  {
        display:block;
        }
           #jiehuan {
        position:relative;
        }
       #jiehuanlist {
            text-align:center;
           width:auto;
           height:auto;
           position:absolute;
                top:39px;
                left:0px;
                display:none;
                background-color:#b4f808;
                 }
        #jiehuan:hover #jiehuanlist  {
        display:block;
        }
        p {
        margin:auto;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="top">
   <div id="toplist">
       <ul>
           <li><a href="#">首页</a></li>
            <li id="sheguan"><a href="#">设备管理</a>
                <ul id="sheguanlist">
                    <li><a href="InsertSheBei.aspx">添加新设备</a></li>
                     <li><a href="SelectShebei.aspx">查询新设备</a></li>
                    <li><a href="GuanliDevice.aspx">管理新设备</a></li>
                </ul>

            </li>
            <li id="shexiu"><a href="GuanliDevice">管理设备维修</a>
                  <ul id="shexiulist">
                    <li><a href="SelectWeiXiu.aspx">查询设备维修</a></li>
                     <li><a href="DeviceWeixiujilu.aspx">设备维修登记</a></li>
                  
                </ul>
            </li>
            <li id="erji"><a href="#">管理设备报废</a>
                <ul id="erjilist">
                    <li><a href="SelecrtBaoFei.aspx">查询设备报废</a></li>
                     <li><a href="#">设备报废登记</a></li>
                </ul>

            </li>
           <li id="jiehuan"> <a href="SelectGuiHuan.aspx">设备借还</a>
                 <ul id="jiehuanlist">
                    <li><a href="SheBeiBorrow.aspx">登记设备借出</a></li>
                     <li><a href="SelectGuiHuan.aspx">登记设备</a></li>
                   
                </ul>

           </li>
            <li><a href="Password.aspx">修改密码</a></li>
            <li><a href="#" onclick="window.close()">退出</a></li>
           
       </ul>


   </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
