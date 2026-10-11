<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_contract_img.aspx.cs" Inherits="marr_contract_app.show_contract_img" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>عقود الزواج</title>
    <link href="style/Style2.css" rel="stylesheet" />
    
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
           <asp:Button ID="Button_img" 
    OnClientClick="CallPrintImage(document.getElementById('Image1')); return false;" 
    runat="server" 
    Text="طـبـاعـة الـصـورة" />        </div>
        <%--<div>
             <td> * <select name="gov" id="txt1" runat="server">
</select> </td>
               <td>
<select name="court_name" id="txt2" runat="server">--%>
    </form>
</body>
   <script type="text/javascript">
       function CallPrintImage(imgClientId) {
           // Ensure we have a valid image source
           var imgElem = imgClientId.src;
           if (!imgElem || imgElem.trim() === "") {
               alert('الصورة غير موجودة أو لم يتم تحميلها');
               return false;
           }

           var printWindow = window.open('', '', 'left=0,top=0,width=900,height=1000,toolbar=0,scrollbars=0,status=0');

           printWindow.document.write('<!DOCTYPE html><html><head><title>طباعة العقد</title>');
           printWindow.document.write('<link href="style/Style2.css" rel="stylesheet" />');

           // --- START OF THE FIX ---
           printWindow.document.write('<style>');

           // 1. This removes the header/footer (about:blank)
           printWindow.document.write('@page { size: auto; margin: 0mm; }');

           // 2. Adjust body to ensure image isn't cut off since we removed margins
           printWindow.document.write('body { margin: 10px; padding: 0; text-align: center; }');

           printWindow.document.write('img { width: 800px; height: 950px; display: block; margin: auto; }');
           printWindow.document.write('@media print { body { -webkit-print-color-adjust: exact; } }');
           printWindow.document.write('</style>');
           // --- END OF THE FIX ---

           printWindow.document.write('</head><body>');
           printWindow.document.write('<img src="' + imgElem + '" />');
           printWindow.document.write('</body></html>');

           printWindow.document.close();
           printWindow.focus();

           // Use a slight timeout to ensure image loads in the new window before printing
           printWindow.onload = function () {
               setTimeout(function () {
                   printWindow.print();
                   printWindow.close();
               }, 500);
           };

           return false;
       }
   </script>
</html>
