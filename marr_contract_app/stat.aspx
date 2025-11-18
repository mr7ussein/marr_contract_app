<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stat.aspx.cs" Inherits="marr_contract_app.stat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
           <asp:ListItem Value="1">كانون الثاني</asp:ListItem>
            <asp:ListItem Value="2">شباط</asp:ListItem>
            <asp:ListItem Value="3">اذار</asp:ListItem>
            <asp:ListItem Value="4">نيسان</asp:ListItem>
            <asp:ListItem Value="5">ايار</asp:ListItem>
            <asp:ListItem Value="6">حزيران</asp:ListItem>
            <asp:ListItem Value="7">تموز</asp:ListItem>
            <asp:ListItem Value="8">اب</asp:ListItem>
            <asp:ListItem Value="9">ايلول</asp:ListItem>
            <asp:ListItem Value="10">تشرين الاول</asp:ListItem>
            <asp:ListItem Value="11">تشرين الثاني</asp:ListItem>
            <asp:ListItem Value="12">كانون الاول</asp:ListItem>
        </asp:DropDownList>
      <asp:GridView ID="GridView2" runat="server" 
                                    AutoGenerateColumns="False" Width="600px" 
                          OnSelectedIndexChanged="GridView2_SelectedIndexChanged"  
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
    </form>
</body>
</html>
