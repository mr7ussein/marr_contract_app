<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_contract_img.aspx.cs" Inherits="marr_contract_app.show_contract_img" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>عقود الزواج</title>
    <link href="style/Style2.css" rel="stylesheet" />
      <script "javascript" type="text/javascript">
          function CallPrint(ashe2) {
              var prtContent = document.getElementById(ashe2);
              var WinPrint = window.open('', '', 'letf=0,top=0,width=900,height=700,toolbar=0,scrollbars=0,status=0,dir=ltr');
              WinPrint.document.write(ashe2.innerHTML);
              WinPrint.document.close();
              WinPrint.focus();
              WinPrint.print();
              WinPrint.close();
              ashe2.innerHTML = strOldOne;
          }
</script>

</head>
<body class="pr2">
    <form id="form1" runat="server">
    <div id="ashe"  class="contr_img3">
        <div id="ashe2">
            <asp:Image ID="Image1" ImageAlign="Middle" runat="server" Width="800px" Height="950px" />
            </div>
        <br />
        <br />
      <div id="div_img">
       <%-- <asp:Button ID="Button_img"  onclientclick="javascript:CallPrint('ashe2');" runat="server" Text="طـبـاعـة الـصـورة" />--%>

      </div>
        <div>
             <td> * <select name="gov" id="txt1" runat="server">

</select> </td>
               <td>
<select name="court_name" id="txt2" runat="server">

</select></td>
        </div>
    </div>
    </form>
</body>
</html>
