     <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_form.aspx.cs" Inherits="marr_contract_app.admin_form" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>عـقـود الـزواج</title>
    <link href="style/Style2.css" rel="stylesheet" />

    <script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
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
    <meta charset="utf-8">
 <%-- <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>--%>
  
</head>
<body>
    <form id="form1" runat="server">
         <div id="header1" class=head style="background-image: url('images/img123.png'); background-repeat: no-repeat;background-size:contain;">
    </div>
           
       <br />
     <div id="opened" class="pr">
     
           <div id="Slider_Div0" class="Slider"   dir="rtl" style=" right: 10%; top: 200px; position: fixed; align=right;" >
          
          <div id="" class="offdiv" align="center" dir="rtl">   
               <a href="#" id="link1"  align="left"  onclick="Sliding0()">اغلاق البحث</a>
              <br />
            <table>
                
        <tr>
            <td>
                <asp:Textbox CssClass="Textbox"  id="Textbox1" width="150px" placeholder=" الاسم الثلاثي " runat="server"></asp:Textbox>

            </td> 
    <td> <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/image/search.jpg" OnClick="btnSearch_Click" /></td>
      
        </tr>

                </table>
               </div>
             <div id="" class="res_class2" style="overflow-y:scroll; height:250px;">
  
<asp:GridView ID="GridView2" runat="server" 
                                    AutoGenerateColumns="False" Width="600px" 
                            OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"  
                            DataKeyNames="USER_ID,FULL_NAME, USERNAME,USERPASS,USER_STATUS,JUDGE_NAME,app_id,COURT_ID,APPP,COURTT,RECORD_NO,MAX_PAGE"
                          CssClass="mGrid"
    PagerStyle-CssClass="pgr"
    AlternatingRowStyle-CssClass="alt"
                                Visible="false" AllowPaging="false" AllowSorting="True">
                            

                            <Columns>
                                  <asp:BoundField DataField="USER_ID" HeaderText="ID" 
                                            SortExpression="USER_ID"   HeaderStyle-CssClass="hide"  ItemStyle-ForeColor="Red"  ItemStyle-CssClass="hide"/>
                                       
                                
                                <asp:BoundField DataField="FULL_NAME" HeaderText="الاسم الثلاثي" 
                                            SortExpression="FULL_NAME"   HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="USERNAME" HeaderText="اسم المستخدم " 
                                            SortExpression="USERNAME"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="USERPASS" HeaderText="كلمة السر " 
                                           SortExpression="USERPASS"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px" ItemStyle-Width="200px" ControlStyle-Width="250px" HeaderStyle-Width="200px" FooterStyle-Width="200px" />
                                 <asp:BoundField DataField="USER_STATUS" HeaderText="حالة المستخدم " 
                                            SortExpression="USER_STATUS"   HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="JUDGE_NAME" HeaderText="اسم القاضي " 
                                            SortExpression="JUDGE_NAME"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                  <asp:BoundField DataField="app_id" HeaderText="app_id" 
                                            SortExpression="app_id"   HeaderStyle-CssClass="hide"  ItemStyle-ForeColor="Red"  ItemStyle-CssClass="hide"/>
                                   <asp:BoundField DataField="COURT_ID" HeaderText="COURT_ID" 
                                            SortExpression="COURT_ID"   HeaderStyle-CssClass="hide"  ItemStyle-ForeColor="Red"  ItemStyle-CssClass="hide"/>
                                  
                                        <asp:BoundField DataField="APPP" HeaderText="اسم الاستئناف" 
                                           SortExpression="APPP"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px" ItemStyle-Width="200px" ControlStyle-Width="250px" HeaderStyle-Width="200px" FooterStyle-Width="200px" />
                                 <asp:BoundField DataField="COURTT" HeaderText="اسم المحكمة " 
                                            SortExpression="COURTT"   HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                        <asp:BoundField DataField="RECORD_NO" HeaderText="رقم السجل  " 
                                            SortExpression="RECORD_NO"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                                <asp:BoundField DataField="reached_no" HeaderText="عدد الصفحات المدخلة للسجل  " 
                                            SortExpression="reached_no"  HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>

                                                   <asp:BoundField DataField="MAX_PAGE" HeaderText="العدد الكلي للسجل   " 
                                            SortExpression="MAX_PAGE"   HeaderStyle-ForeColor="white" HeaderStyle-Height="30px"/>
                              
                                           <asp:CommandField ShowSelectButton="true"  Visible="True" SelectText="تفاصيل" HeaderStyle-CssClass="hide"  ItemStyle-ForeColor="Red"  ItemStyle-CssClass="hide"/>
                                         
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
           
   
       <div  id="Div2"  class="pr3" runat=server> 
                 <div id="div_lable2" class="DivLable">
         <table><tr>
     
         <%--     <td>     <asp:Button ID="Button1" Onclick="srch" CssClass="btn" runat="server" Text="بـحـــث" /> </td>--%>
              <td>  <asp:Button ID="Button33" Onclick="insert" CssClass="btn" runat="server" Text="حفظ" /></td>
              <td> <asp:Button ID="Button3" CssClass="btn" OnClick="new_u" runat="server" Text="جديد" /></td>
             <td> <asp:Button ID="Button1" CssClass="btn" OnClick="Button1_Click"  runat="server" Text="الاحصـائـية" /></td>
              <td> <asp:Button ID="Button2" CssClass="btn" OnClick="Button2_Click"  runat="server" Text="نـسـخـة احـتـياطية لقاعدة البيانات" /></td>
              <%-- <td>  <asp:Button ID="Button4" OnClick="attach_cont_img" CssClass="btn" runat="server" Text="ادراج صورة العقد" /></td>--%>
           </tr>
          </table> 
                     </div>
           <br />
           
           <div id="div_lable" class="DivLable">
         <table><tr>
 <td> * اسم الاستئناف   
                 <asp:DropDownList ID="app_name" CssClass="select2"  
                                        AutoPostBack="false" Font-Bold="True" Width="300px"   runat="server"> 
                      </asp:DropDownList><%--<select name="gov" id="Select1" runat="server">
<option VALUE="1">بغداد/ناحية الرصافة</option>
<option VALUE="2">بغداد/استئناف الكرخ الاتحادية</option>

</select> --%>
  * المحكمة   <asp:DropDownList ID="court_name" CssClass="select2"  
                                        AutoPostBack="false" Font-Bold="True" Width="300px"   runat="server"> 
                      </asp:DropDownList><%--<select name="court_name" id="Select2" runat="server">
<option VALUE="277">محكمة الاحوال الشخصية في البياع</option>
      <option VALUE="275">محكمة الاحوال الشخصية في  الزهور</option>
</select>--%></td>
         
      
   </tr>
             <tr>     
        
            <td>
                
<asp:textbox CssClass="Textbox"  id="txt1" width="150px" placeholder=" الاسم الثلاثي " runat="server"></asp:textbox>
<asp:textbox CssClass="Textbox"  id="txt2" placeholder="اسم المستخدم" width="80px" runat="server"></asp:textbox>
<asp:textbox CssClass="Textbox"  id="txt3" width="80px" placeholder=" كلمة المرور " runat="server"></asp:textbox>
حالة المستخدم:<select name="court_name" id="Select3" width="50px" runat="server">
<option VALUE="1">ادخال</option>
    <option VALUE="2">تدقيق</option>
    <option VALUE="3">غير مفعل</option>
</select> 
                       </td>
                </tr>
 
       </div>
          </div>
  </div>
        <div>
  </div>
        <table>
            <tr>
                <td></td> <td></td> <td></td> <td></td> <td></td> <td></td> <td></td> <td></td>
                <td>
*الاحـصـائية<asp:TextBox ID="TextBox2" placeholder="من تـأريخ" CssClass="TxtBox5" runat="server"></asp:TextBox>
                    <td>
                    <asp:TextBox ID="TextBox3"  CssClass="TxtBox5" placeholder="الـى تـأريخ" runat="server"></asp:TextBox>
                    </td>
                    <td></td> <td></td>  <td></td>  <td></td>  <td></td>  <td></td>  <td></td>  <td></td>  <td></td>  <td></td>
                   
                   
                    <td>
                         <asp:TextBox ID="TextBox4" ReadOnly="true" CssClass="TxtBox5" runat="server"></asp:TextBox>
                    </td>
                </td>
            </tr>
        </table>
          
         
        
            <%--  <asp:SqlDataSource  ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:bayaaConnectionString %>" 
            SelectCommand="SELECT *  FROM [HELAL2018].[BAYA].[USERS]"></asp:SqlDataSource>

             <asp:SqlDataSource  ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:bayaaConnectionString %>" 
            SelectCommand="SELECT *  FROM [HELAL2018].[BAYA].[APP]"></asp:SqlDataSource>
            <asp:SqlDataSource  ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:bayaaConnectionString %>" 
            SelectCommand="SELECT *  FROM [HELAL2018].[BAYA].[COURT]"></asp:SqlDataSource>--%>
       
    </form>
</body>
</html>