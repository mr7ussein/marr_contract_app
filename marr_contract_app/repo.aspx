<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repo.aspx.cs" Inherits="marr_contract_app.repo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>تقارير شهرية لعقود الزواج</title>
    <link href="style/repo.css" rel="stylesheet" />
    <style type="text/css">


        .Textbox
{

 font-size:15px;
 font-weight:bold;
 border-color:#6d81a1;
 border-radius:10px 10px 10px 10px;
}
        .auto-style1 {
            width: 560px;
        }
        .auto-style5 {
            height: 43px;
            width: 213px;
        }
        .auto-style6 {
            width: 213px;
        }
        .auto-style9 {
            width: 843px;
            height: 34px;
        }
        .auto-style10 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style11 {
            width: 843px;
        }
        .auto-style12 {
            width: 843px;
            height: 43px;
        }
        </style>
    </head>
<body>
    <form id="form1" runat="server">



    <div id="main_div" class="mainDiv" style="background-image: url('images/img123.png'); background-repeat: no-repeat; background-size:contain;">
       
    </div>
        <br />



     <div id="div1" class="div1">
         <br />
         
          <asp:Label ID="lable_main1" class="lable_main1" runat="server" Text="the name" >تقــارير احصائــــية عقود الزواج الشهرية  </asp:Label>

          <br />
          

     </div>
         <br /> <br /> <br />
         <div id="div11" class="div1">
         
        
       <asp:Label ID="lable_main2" class="lable_main2" runat="server" Text="the name" >اختيار الشهر لطبـــاعة الاحصائــية </asp:Label>
             </div>
          <br />
           <br /> 

              <br />

   

     <div id="div2" class="div2">
         <br />
           <br /> 

  

<%--    <tr>
        <td </td class="auto-style1">
                
<%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select name="gov" id="txt1" runat="server" aria-multiselectable="False" multiple="False">
<option value="1">كانون الثاني</option>
<option value="2">شباط</option>
<option value="3">نينوى</option>
<option value="4">ديالى</option>
<option value="5">النجف</option>
<option value="6">حزيران</option>
<option value="7">تموز</option>
<option value="8">اب</option>
<option value="9">ايلول</option>
<option value="10">تشرين الاول</option>
<option value="11"> تشرين الثاني</option>
<option value="12">كانون الاول</option>
</select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
                
 

<table id="table" class="table"  style="margin:auto">
    
   <tr class="button1" >
       <td>
           <asp:Button ID="Button3" CssClass="b12" runat="server" Text="     آذار    " OnClick="Button3_Click" />
       </td>
        <td>
           <asp:Button ID="Button2" CssClass="b12" runat="server" Text="شبـــــــــاط" OnClick="Button2_Click1" />
       </td>
        <td>
           <asp:Button ID="Button1" CssClass="b12" runat="server" Text="كانون الثاني" OnClick="Button1_Click1" />
       </td>
   </tr>



    



    

     <tr class="button2">
        <td>
           <asp:Button ID="Button6" CssClass="b12" runat="server" Text="حزيـــــران" OnClick="Button6_Click" />
       </td>
        <td>
           <asp:Button ID="Button5" CssClass="b12" runat="server" Text="آيــــــــــــار" OnClick="Button5_Click" />
       </td>
        <td>
           <asp:Button ID="Button4" CssClass="b12" runat="server" Text="نـــيســــان" OnClick="Button4_Click" />
       </td>


   </tr>




     <tr class="button1">
           <td>
           <asp:Button ID="Button9" CssClass="b12" runat="server" Text="ايلــــــول" OnClick="Button9_Click" />
       </td>
        <td>
           <asp:Button ID="Button8" CssClass="b12" runat="server" Text="      آب     " OnClick="Button8_Click" Height="28px" />
       </td>
        <td>
           <asp:Button ID="Button7" CssClass="b12" runat="server" Text="تمـــــــــوز" OnClick="Button7_Click" />
       </td>
       
   </tr>



     <tr class="button2">
           <td>
           <asp:Button ID="Button12" CssClass="b12" runat="server" Text="كانون الاول" OnClick="Button12_Click" />
       </td>
        <td>
           <asp:Button ID="Button11" CssClass="b12" runat="server" Text="تشرين الثاني" OnClick="Button11_Click" />
       </td>
        <td>
           <asp:Button ID="Button10" CssClass="b12" runat="server" Text="تشرين الاول" OnClick="Button10_Click" />
       </td>
       
   </tr>



    </table>

         
         <br />
                 <br />
                 <br />


             <div id="div111" class="div1">
         
        
       <asp:Label ID="Label1" class="lable_main2" runat="server" Text="the name" >بحث بتاريخ محدد من  قبل الموظف </asp:Label>
   
                 <br />
                 <br />
                 <br />
   
  <table id="table22" class="table"  style="margin:auto">

    <tr>
        <td class="auto-style12">


            <asp:TextBox ID="TextBox1" style="border-radius:10px 10px ;background-color:#e1d6d6; text-align:center;"  Font-Bold="true"  runat="server" Width="193px"></asp:TextBox>


        </td>
        <td class="auto-style5">

            <asp:Label ID="Label2" style="font-size:large"  runat="server" CssClass="auto-style10" Text="من تـــاريخ"></asp:Label>

        </td>
    </tr>

    <tr>

        <td class="auto-style11">
                
            <asp:TextBox ID="TextBox2" style="border-radius:10px 10px ;background-color:#e1d6d6; text-align:center;"  runat="server" Font-Bold="true" Width="192px"></asp:TextBox>
        </td>

        <td class="auto-style6"> 
            <asp:Label ID="Label3"  style="font-size:large"  runat="server" CssClass="auto-style10" Text="الى تـــاريخ"></asp:Label>
        </td>


    </tr>

      <tr>

        
          <td class="auto-style9">

                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" style="font-weight: 700; font-size: medium;border-radius:10px 10px;background-color:#808080;padding-left:10px; margin-right:7px; margin-left: 26px;" Text="طبـــاعة" Width="136px" />
       
          </td>

         
      </tr>
      <tr>

          <td class="auto-style11">
              <br />
              <br />

          </td>
      </tr>
      </table>

                 <br />

             </div>
   

        


    <table id="table2" class="table"  style="margin:auto">

        
    <tr>
        
    </tr>

    </table>

          </div>

        <table>
      <tr>

          <td>
              <asp:GridView ID="GridView2" runat="server" CellPadding="4" Font-Bold="True" Font-Size="Large" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                 <AlternatingRowStyle BackColor="White" />
                 <EditRowStyle BackColor="#2461BF" />
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#EFF3FB" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#F5F7FB" />
                 <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                 <SortedDescendingCellStyle BackColor="#E9EBEF" />
                 <SortedDescendingHeaderStyle BackColor="#4870BE" />
             </asp:GridView>
             
          </td>
      </tr>

      <tr><td class="auto-style1">
             &nbsp;<asp:GridView ID="GridView1" runat="server" CellPadding="4" Font-Bold="True" Font-Size="Large" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                 <AlternatingRowStyle BackColor="White" />
                 <EditRowStyle BackColor="#2461BF" />
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#EFF3FB" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#F5F7FB" />
                 <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                 <SortedDescendingCellStyle BackColor="#E9EBEF" />
                 <SortedDescendingHeaderStyle BackColor="#4870BE" />
             </asp:GridView>
            <br />
        </td></tr>
      </table>

         <br />
         <br />
         <br />

      
   

    </form>
</body>
</html>
