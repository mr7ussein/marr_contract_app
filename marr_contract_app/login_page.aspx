<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="marr_contract_app.login_page" %>

<!DOCTYPE html>

<html>
	
<head>
	<title>عـقـود الـزواج</title>
		<meta charset="utf-8">
		<link href="style/style.css" rel='stylesheet' type='text/css' />
    <script src="jv1.js"></script>
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<script type="application/x-javascript">
             addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
   <script type="application/x-javascript">
 function myFunction() {

             
           window.location = "main1.aspx";
   
       }
</script>
      


		<!--webfonts-->
		<%--<link href='http://fonts.googleapis.com/css?family=Open+Sans:600italic,400,300,600,700' rel='stylesheet' type='text/css'>--%>
		<!--//webfonts-->
</head>
<body>
	
				 <!-----start-main---->
				<div class="login-form">
					<div class="head">
						<img src="images/mem2.jpg" alt=""/>
						
					</div>
				<form runat ="server">
					<li>
                        <asp:TextBox ID="TextBox1" placeholder="اسم المستخدم" class="text" runat="server"></asp:TextBox>
					
					</li>
					<li>
                         <asp:TextBox ID="TextBox2" placeholder="كلمة المرور" TextMode="Password" class="text" runat="server"></asp:TextBox>
					
					</li>
                   
					<div class="p-container" >
					<label class="checkbox1"><input  type="checkbox" runat ="server" id="newCHK"  onclick="check_uncheck('srchCHK')" name="checkbox" checked><i></i> الرئيسية</label> 
                        <br />         
                        <label class="checkbox1"><input type="checkbox" id="srchCHK" runat ="server"  onclick="check_uncheck('newCHK')"  name="checkbox1" ><i></i> الادارة</label>
                        <br />
                     <asp:Button ID="Button1" runat="server"  OnClick="login" Text="دخـول" />

							<div class="clear"> </div>


                        
					</div>
                   
				</form>
                   
			</div>
			
</body>
</html>
