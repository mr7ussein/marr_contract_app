

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main2.aspx.cs" Inherits="marr_contract_app.main2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>عـقود الزواج </title>
    <link href="style/Style2.css" rel="stylesheet" />
   <script type="text/javascript" src="js/jquery-1.4.2.min.js">
</script>
    <script src="jv1.js"></script>
    <script language="javascript" type="text/javascript" >
        var oldgridSelectedColor;
        var col;


        function setMouseOverColor(element) {

            oldgridSelectedColor = element.style.backgroundColor;
            col = element.style.color;
            element.style.backgroundColor = '#FFFFFF';
            element.style.color = '#0000FF';
            element.style.textDecoration = 'underline';

        }

        function setMouseOutColor(element) {

            element.style.backgroundColor = oldgridSelectedColor;
            element.style.color = col;
            element.style.textDecoration = 'none';
        }
</script>
     <script type="text/javascript">
         function deleteConfirm(pubid) {
             var result = confirm('Do you want to delete ' + pubid + ' ?');
             if (result) {
                 return true;
             }
             else {
                 return false;
             }
         }
</script>
    
      <script "javascript" type="text/javascript">
          $(function () {
              $('input:text:first').focus();
              var $inp = $('input:text');
              $inp.bind('keydown', function (e) {
                  //var key = (e.keyCode ? e.keyCode : e.charCode);
                  var key = e.which;
                  if (key == 13) {
                      e.preventDefault();
                      var nxtIdx = $inp.index(this) + 1;
                      $(":input:text:eq(" + nxtIdx + ")").focus();
                  }
              });
          });
    </script>




    <meta charset="utf-8">
 <%-- <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>--%>
  
</head>
<body>
    <form id="form1" runat="server">
         <div id="header1" class="head" style="background-image: url('images/img123.png'); background-repeat: no-repeat;background-size:contain;">
    </div>
          <asp:textbox CssClass="Textbox"  ID="newid1" runat="server"></asp:textbox>
          <asp:textbox CssClass="Textbox"  ID="newid2" runat="server"></asp:textbox>
          <asp:textbox CssClass="Textbox"  ID="newid3" runat="server"></asp:textbox>
  
       <br />
     <div id="opened" class="pr">
     
           <div id="Slider_Div0" class="Slider"   dir="rtl" style=" right: 10%; top: 50px; position: fixed; align=right;" >
          
          <div id="mng_item2" class="offdiv" align="center" dir="rtl">   
               <a href="#" id="link1"  align="left"  onclick="Sliding0()">اغلاق البحث</a>
            <table>
           <tr>
           <td></td>
               <td></td>
                 <td></td>
               <td colspan="2"><asp:Label ID="Label15" runat="server" Text="الزوج"></asp:Label> </td>
             
               <td colspan="2"><asp:Label ID="Label16" runat="server" Text="الزوجة"></asp:Label> </td>
           </tr>
               <tr>
            <td colspan="3"> <asp:Label ID="Label27" runat="server" Text=" الاسم الثلاثي "></asp:Label></td>
            <td colspan="2">
                
<asp:textbox CssClass="Textbox"  id="Textbox3" width="60px" placeholder="الاسم " runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="Textbox4" placeholder=" اسم الاب" width="60px" runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="Textbox5" width="60px" placeholder=" اسم الجد" runat="server"></asp:textbox>
        </td>
              
   
            <td colspan="2">
<asp:textbox CssClass="Textbox"  id="Textbox7" width="60px" placeholder="الاسم " runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="Textbox8" placeholder=" اسم الاب" width="60px" runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="Textbox9" width="60px" placeholder=" اسم الجد" runat="server"></asp:textbox>
                </td>
        </tr>



                <tr>
            <td colspan=3> <asp:Label ID="Labelt" runat="server" Text=" التولد "></asp:Label></td>
            <td colspan=2>
                
 <asp:textbox CssClass="Textbox"  ID="TextBox11" runat="server"></asp:TextBox>
        </td>
            <td colspan=2>
 <asp:textbox CssClass="Textbox"  ID="TextBox12" runat="server"></asp:TextBox>
                </td>
        </tr>
                <tr>
                      <td colspan=2> <asp:Label ID="Label5" runat="server" Text="العـــدد "></asp:Label></td>
            <td>
                
 <asp:textBox CssClass="Textbox"  ID="srch_record_no" runat="server"></asp:textBox> </td>
                     </tr>
                 <tr>
            <td colspan=2> <asp:Label ID="Label19" runat="server" Text="التاريـــــــخ"></asp:Label></td>
            <td>
                
 <asp:textBox CssClass="Textbox"  ID="TextBox13" runat="server"></asp:textBox>    </td>
                     <td> <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/image/search.jpg" OnClick="btnSearch_Click" />
     </td>
          
        </tr>

                </table>
               </div>
             <div id="srch_rslt" class="res_class" style="overflow-y:scroll; height:250px;">
  
   <asp:GridView ID="GridView2" runat="server" 
                                    AutoGenerateColumns="False" Width="600px" AutoGenerateSelectButton="true"
                            OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"  
                            DataKeyNames="MAIN_ID ,name1,name2,RECORD_DATE"
                          CssClass="mGrid"
    PagerStyle-CssClass="pgr"
    AlternatingRowStyle-CssClass="alt"
                                Visible="true" AllowPaging="false" AllowSorting="True">
                            

                            <Columns>
                                        <asp:BoundField DataField="name2" HeaderText="اسم الزوج " 
                                            SortExpression="name2"   HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="name1" HeaderText="اسم الزوجة " 
                                            SortExpression="name1"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="RECORD_DATE" HeaderText="تاريخ العقد" 
                                           SortExpression="RECORD_DATE"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px" ItemStyle-Width="200px" ControlStyle-Width="250px" HeaderStyle-Width="200px" FooterStyle-Width="200px" />
                                        <asp:CommandField ShowSelectButton="true"  Visible="false" SelectText="تفاصيل" HeaderStyle-CssClass="hide"  ItemStyle-ForeColor="Red"  ItemStyle-CssClass="hide"/>
                                         
                               </Columns>                                    

                                          <PagerSettings FirstPageText="الاولى" LastPageText="الاخيرة" 
                                              NextPageText="التالي" Position="Top" 
                                                  PreviousPageText="السابق" Mode="NumericFirstLast" />
                                              <PagerStyle Font-Underline="True" VerticalAlign="Top" Width="1px" 
                                                  BorderColor="#FFCC66" BorderStyle="None" BorderWidth="0px" 
                                                  Wrap="True" />

                                              <RowStyle Height="10px" />

                                              <SelectedRowStyle BackColor="#CCFFFF" />

                            </asp:GridView>


</div>
        </div>
          <div id="Slider_Div" class="Slider"   dir="rtl" style=" right: 55%; top:  250px; position: absolute;" align="right">
          
          <div id="mng_item" class=offdiv align="center" dir="rtl">   
               <asp:Image ID="Image1" runat="server" ImageUrl="~/image/images.jpg" cssclass="ximg" Width="20px" Height="20px" ImageAlign="left"  onclick="Sliding()"/>
            <table>
                          <tr>
                            
                  
                                 
                                
                              </tr>
                <tr>
                      <td>  <asp:Image ID="Image6" Width="350" Height="400" runat="server"  /></td>
                          </tr>
                <tr>
                     
                    <td>  <asp:Button ID="Button3" OnClick="prevv" CssClass="btn" runat="server" Text="معاينة قبل الطباعة" /></td>   
                     </tr>
                </table>
               </div>
             
        </div> 
   
       <div  id="Div2"  class="pr3" runat="server"> 
                 <div id="div_lable" class="DivLable">
         <table>
             
             <tr>
              <td> <asp:Button ID="Button4" OnClick="d_entry" CssClass="btn" runat="server" Text="عقد جديد" /></td>
              <td>  <asp:Button ID="Button5" OnClick="SaveToDB" CssClass="btn" runat="server" Text= " حفظ " /></td>
              <td>     <asp:Button ID="Button1" Onclick="srch" CssClass="btn" runat="server" Text="بـحـــث" /> </td>
                 <td>  <asp:Button ID="Button6" OnClick="delete_click" CssClass="btn" runat="server" Text= " حـذف " OnClientClick="return confirm('هل أنت متأكد أنك تريد حذف هذا السجل؟');"/></td>
              <td>  <asp:Button ID="Button2" OnClick="update_all" CssClass="btn" runat="server" Text="تعديل على قاعدة البيانات" OnClientClick="return confirm('هل أنت متأكد من تعديل البيانات؟');" /></td>
        
              <td></td>
 <td> * <select name="gov" id="txt1" runat="server" class="select2">


</select> </td>
               <td>
  <asp:textbox   id="txt2" CssClass="select2" runat="server"></asp:textbox>
<%--<select name="court_name" id="txt2" runat="server" class="select2">      </select>--%>
                   </td>
  <asp:textbox   id="Textbox1" width="100px" runat="server"></asp:textbox>

        
           </tr>

          </table> 
         <table><tr> <td>   <asp:Label ID="Label20" runat="server" Text=" العــــدد"></asp:Label>

   <asp:textbox CssClass="Textbox"  id="txt_record_no" width="100px" runat="server"></asp:textbox></td>
        
      
        <td>      <asp:Label ID="Label4" runat="server" Text="التاريخ "></asp:Label>
           
                
<asp:textbox CssClass="Textbox"  id="txt_RecordDate" width="100px" runat="server"></asp:textbox>
        </td>
                           
                         </tr>
                       
            
             </table>
                     </div>
           
      <table>
           <tr>
           <td></td>
               <td></td>
                 <td></td>
               <td colspan="2"><asp:Label ID="Label2" runat="server" Text="الزوج"></asp:Label> </td>
             
               <td colspan="2"><asp:Label ID="Label3" runat="server" Text="الزوجة"></asp:Label> </td>
           </tr>
               <tr>
            <td colspan="3"> <asp:Label ID="Label1" runat="server" Text=" الاسم الثلاثي "></asp:Label></td>
            <td colspan="2">
                
<asp:textbox CssClass="Textbox"  id="txt4" width="60px" placeholder="الاسم " runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="txt5" placeholder=" اسم الاب" width="60px" runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="txt6" width="60px" placeholder=" اسم الجد" runat="server"></asp:textbox><asp:textbox CssClass="hide"  id="txt7"  placeholder=" اللقب" width="60px" runat="server"></asp:textbox>
        </td>
              
   
            <td colspan="2">
<asp:textbox CssClass="Textbox"  id="txt8" width="60px" placeholder="الاسم " runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="txt9" placeholder=" اسم الاب" width="60px" runat="server"></asp:textbox><asp:textbox CssClass="Textbox"  id="txt10" width="60px" placeholder=" اسم الجد" runat="server"></asp:textbox><asp:textbox CssClass="hide"  id="txt11"  placeholder=" اللقب" width="60px" runat="server"></asp:textbox>
                </td>
        </tr>
          <tr class="hide">
            <td colspan="3> <asp:Label ID="Label18" runat="server" Text="  اسم الأم الثلاثي "></asp:Label></td>
            <td colspan=2>
                

        </tr>
           <tr>
            <td colspan=3> <asp:Label ID="Label10" runat="server" Text="التولد "></asp:Label></td>
            <td colspan=2>
                
 <asp:textbox CssClass="Textbox"  ID="datepicker2"  width="200px" runat="server"></asp:TextBox>
        </td>
            <td colspan=2>
 <asp:textbox CssClass="Textbox"  ID="datepicker3"  width="200px" runat="server"></asp:TextBox> 
                </td>
        </tr>
           <tr>
            <td colspan=3> <asp:Label ID="Label11" runat="server" Text="الحالة الزوجية "></asp:Label></td>
            <td colspan=2>
                
<select name="marr_status" id="txt26" runat="server"   width="250px">
    <option VALUE="0" >...................</option>
<option VALUE="1">متزوج</option>
<option VALUE="2">اعزب</option>
    <option VALUE="3">مطلق</option>
    <option VALUE="4">ارمل</option>
       <option VALUE="5">متزوج من نفس الزوجة</option>
       <option VALUE="6">مطلق من نفس الزوجة</option>
       <option VALUE="7">مطلق قبل الدخول</option>
</select>
        </td>
   
            <td colspan=2>
<select name="marr_status2" id="txt27" runat="server" >
    <option VALUE="0"  >...................</option>
<option VALUE="1"    >مطلقة</option>
<option VALUE="2"    >باكر</option>
<option VALUE="3"    >ارملة</option>
       <option VALUE="4">متزوجة من نفس الزوج</option>
       <option VALUE="5">مطلقة من نفس الزوج</option>
       <option VALUE="6">مطلقة قبل الدخول</option>
       <option VALUE="7">المرأة الثيب</option>
</select> 

            </td>
        </tr>
          <tr>
     <td colspan=3> <asp:Label ID="Label23" runat="server" Text="ملاحظات:  "></asp:Label></td>
            <td colspan=4>
                
<asp:textbox CssClass="Textbox"  id="txt_note" TextMode="MultiLine" width="400px" height="50px" runat="server"></asp:textbox>
        </td>
        </tr>
         
       </table>
           <br />
      
          
          
          <div>
<asp:GridView ID="gridView" DataKeyNames="ID" runat="server" width="500px"
        AutoGenerateColumns="false" ShowFooter="true" HeaderStyle-Font-Bold="true"                CssClass="mGrid"
    PagerStyle-CssClass="pgr"
    AlternatingRowStyle-CssClass="alt"
                                Visible="true" AllowPaging="false" AllowSorting="True"
        onrowcancelingedit="gridView_RowCancelingEdit"
        onrowdeleting="gridView_RowDeleting"
        onrowediting="gridView_RowEditing"
        onrowupdating="gridView_RowUpdating"
        onrowcommand="gridView_RowCommand"
        OnRowDataBound="gridView_RowDataBound">
<Columns>
<asp:TemplateField HeaderText="">
    <ItemTemplate>
        <asp:Label ID="txtid" runat="server" Text='<%#Eval("ID") %>'/>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="lblid" runat="server" Visible="false"  ReadOnly="true" width="40px" Text='<%#Eval("ID") %>'/>
    </EditItemTemplate>
    <FooterTemplate>
       
      
    </FooterTemplate>
</asp:TemplateField>
    <asp:TemplateField HeaderText="رقم السجل">
     <ItemTemplate>
        <asp:TextBox ID="txtR_N" width="30px" ReadOnly="true" runat="server" Text='<%#Eval("R_N") %>'/>
     </ItemTemplate>
     
    <FooterTemplate>
        <asp:TextBox ID="inR_N" width="40px"   runat="server"/>
     <asp:RequiredFieldValidator ID="vstate" runat="server" ControlToValidate="inR_N" Text="?" ValidationGroup="validaiton"/>
    </FooterTemplate>
 </asp:TemplateField>
 <asp:TemplateField HeaderText="رقم1">
      <ItemTemplate>
       <asp:TextBox ID="txt1" width="70px" ReadOnly="true" runat="server" Text='<%#Eval("P_N1") %>'/>
     </ItemTemplate>
     
     <FooterTemplate>
         <asp:TextBox ID="in1"  width="120px" runat="server"/>
         <%--<asp:RequiredFieldValidator ID="vname" runat="server" ControlToValidate="in1" Text="?" ValidationGroup="validaiton"/>--%>
     </FooterTemplate>
 </asp:TemplateField>
 <asp:TemplateField HeaderText="رقم2">
     <ItemTemplate>
           <asp:TextBox ID="txt2" width="70px" ReadOnly="true" runat="server" Text='<%#Eval("P_N2") %>'/>
     </ItemTemplate>
     
    <FooterTemplate>
        <asp:TextBox ID="in2" width="110px"  runat="server"/>
        <%--<asp:RequiredFieldValidator ID="vaddress" runat="server" ControlToValidate="in2" Text="?" ValidationGroup="validaiton"/>--%>
    </FooterTemplate>
 </asp:TemplateField>
  <asp:TemplateField HeaderText="رقم3">
       <ItemTemplate>
     <asp:TextBox ID="txt3" width="50px"  ReadOnly="true" runat="server" Text='<%#Eval("P_N3") %>'/>
     </ItemTemplate>
     
    <FooterTemplate>
        <asp:TextBox ID="in3" width="60px"  runat="server"/>
        <%--<asp:RequiredFieldValidator ID="vcity" runat="server" ControlToValidate="in3" Text="?" ValidationGroup="validaiton"/>--%>
    </FooterTemplate>
 </asp:TemplateField>



     <asp:TemplateField HeaderText="رقم4">
      <ItemTemplate>
    <asp:TextBox ID="txt4" width="50px"  ReadOnly="true" runat="server" Text='<%#Eval("P_N4") %>'/>
    </ItemTemplate>
    
   <FooterTemplate>
       <asp:TextBox ID="in4" width="60px"  runat="server"/>
       <%--<asp:RequiredFieldValidator ID="vcity" runat="server" ControlToValidate="in3" Text="?" ValidationGroup="validaiton"/>--%>
   </FooterTemplate>
</asp:TemplateField>
   
    
 <asp:TemplateField HeaderText="خيارات">
    
  <EditItemTemplate >
        <asp:Button ID="ButtonUpdate" runat="server" CommandName="Update"  Text="عرض"  />
        <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel"  Text="الغاء" />
    </EditItemTemplate>
    <ItemTemplate>
        <asp:Button ID="ButtonEdit" runat="server" CommandName="Edit"  Text="فحص الصورة"  />
        <asp:Button ID="ButtonDelete" runat="server" CommandName="Delete"  Text="حذف"  />
    </ItemTemplate>
    <FooterTemplate>
        <asp:Button ID="ButtonAdd" runat="server" CommandName="AddNew"  Text="اضافة\حفظ صورة  جديدة" ValidationGroup="validaiton" />
    </FooterTemplate>
 </asp:TemplateField>
 </Columns>
</asp:GridView>
              <br />    
<asp:Label ID="lblmsg" runat="server"></asp:Label>
    </div>
<div >

</div>
        

                <br />
                <br />
         
              
       </div>
         <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>

         <asp:TextBox ID="court_name" Width="300px" runat="server"></asp:TextBox>
         
         <asp:TextBox ID="court_id" Width="300px" runat="server"></asp:TextBox>
          <asp:TextBox ID="maincourtid1" Width="300px" runat="server"></asp:TextBox>
          <asp:TextBox ID="TextBox2" Width="300px" runat="server"></asp:TextBox>
         <%--<asp:TextBox ID="idserch" Width="300px" runat="server"></asp:TextBox>--%>
          <br />
                <br />
      </div>  
    </form>
</body>
</html>
