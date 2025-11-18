using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop;
using System.Globalization;


namespace marr_contract_app
{
    public partial class repo : System.Web.UI.Page
    {

        DataTable dt = new DataTable();
        BL.Functions f = new BL.Functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataTable g = new DataTable();
            // string aa = "";

            //g= f.get_date();
            //aa = g.Rows[0][0].ToString();
            //DateTime d = Convert.ToDateTime(aa);

            //TextBox1.Text = d.ToString("yyyy");
            //if (txt1.Value == "2")
            //    TextBox1.Text = "2015-05-01";




        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            return;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {



            //////if (DropDownList1.Text== "كانون الثاني")
            //////{

            //////  string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand+ "-01-01", rand + "-01-31");

            //////}
            //////else if (DropDownList1.Text == "شباط")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-02-01", rand + "-02-29");

            //////}

            //////else if (DropDownList1.Text == "آذار")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-03-1", rand + "-03-31");

            //////}


            //////else if (DropDownList1.Text == "نيسان")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-04-1", rand + "-04-31");

            //////}
            //////else if (DropDownList1.Text == "ايار")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-05-01", rand + "-05-30");

            //////}

            //////else if (DropDownList1.Text == "حزيران")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-06-1", rand + "-06-31");

            //////}


            //////else if (DropDownList1.Text == "تموز")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-07-1", rand + "-07-31");

            //////}
            //////else if (DropDownList1.Text == "آب")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-08-1", rand + "-08-31");

            //////}

            //////else if (DropDownList1.Text == "ايلول")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-09-1", rand + "-09-31");

            //////}


            //////else if (DropDownList1.Text == "تشرين الاول")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-10-1", rand + "-10-31");

            //////}
            //////else if (DropDownList1.Text == "تشرين الثاني")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-11-1", rand + "-11-31");

            //////}

            //////else if (DropDownList1.Text == "كانون الاول")
            //////{

            //////    string rand = System.DateTime.Today.Year.ToString();



            //////    dt = f.search_monthly_records(rand + "-12-1", rand + "-12-31");

            //////}























            ////if (txt_record_date_from.Text != "" && txt_record_date_to.Text != "")
            //if(DropDownList1.Text !="")
            //{




            //    //DateTime date = Convert.ToDateTime(txt_record_date_from.Text);
            //    //string s1 = date.ToString("dd-MM-yyyy");

            //    //DateTime date1 = Convert.ToDateTime(txt_record_date_to.Text);
            //    //string s2 = date.ToString("dd-MM-yyyy");


            //dt = f.search_monthly_records(TextBox1.Text, TextBox2.Text);

            //if (dt.Rows.Count > 0)
            //{
            //GridView1.DataSource = dt;

            //GridView1.DataBind();
            //Response.ClearContent();
            //Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية للتاريخ.xls");
            //Response.ContentType = "application/excel";

            //System.IO.StringWriter sw = new System.IO.StringWriter();
            //HtmlTextWriter htw = new HtmlTextWriter(sw);
            //GridView1.RenderControl(htw);
            //Response.Write(sw.ToString());
            //Response.End();

            //GridView1.Visible = false;



            //}

            //else
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' لم يسفر البحث عن شيء ')", true);

            //}

            //}

            //else

            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' توجد حقول فارغة ..!')", true);

            //}





        }

        protected void Button2_Click(object sender, EventArgs e)
        {


        }

        protected void txt_record_date_to_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click1(object sender, EventArgs e)
        {

            string rand = "2015";


            //  string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-01-01", rand + "-01-31");






            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر كانون الثاني.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

            // string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-02-01", rand + "-02-29");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر شباط.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //  string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "/03/01", rand + "/03/31");


            DateTime dd = Convert.ToDateTime(dt);





            GridView1.DataSource = dd;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر اذار.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //  string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-04-01", rand + "-04-30");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر نيسان.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //   string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-05-01", rand + "-05-31");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر آيار.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //   string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-06-01", rand + "-06-30");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر حزيران.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //  string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-07-01", rand + "-07-31");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر تموز.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //  string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-08-01", rand + "-08-31");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر آب.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            // string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-09-01", rand + "-09-30");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر ايلول.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            // string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-10-01", rand + "-10-31");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر تشرين الاول.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //  string rand="2015";


            string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-11-01", rand + "-11-30");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر تشرين الثاني.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();











































        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            string rand = "2015";


            //   string rand = System.DateTime.Today.Year.ToString();


            dt = f.search_monthly_records(rand + "-12-01", rand + "-12-30");








            GridView1.DataSource = dt;

            GridView1.DataBind();
            Response.ClearContent();
            Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية لشهر كانون الاول.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }



        protected void Button13_Click3(object sender, EventArgs e)
        {

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            if (TextBox1.Text == "" || TextBox2.Text == "")

            { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تأكد من كتابة التاريخ بصورة صحيحة ')", true); }

            else
            {
                string date_from = "", date_to = "";
                DateTime d1 = Convert.ToDateTime(TextBox1.Text);
                date_from = d1.ToString("yyyy-MM-dd");

                DateTime d2 = Convert.ToDateTime(TextBox2.Text);
                date_to = d2.ToString("yyyy-MM-dd");


                dt2 = f.search_monthly_records(date_from, date_to);

                if (dt2.Rows.Count > 0)
                {
                    GridView2.DataSource = dt2;

                    GridView2.DataBind();


                    Response.ClearContent();
                    Response.AddHeader(@"content-disposition", "attachment; filename=احصائية عقود الزواج الشهرية بتاريخ محدد .xls");
                    Response.ContentType = "application/excel";

                    System.IO.StringWriter sw = new System.IO.StringWriter();
                    HtmlTextWriter htw = new HtmlTextWriter(sw);
                    GridView2.RenderControl(htw);
                    Response.Write(sw.ToString());
                    Response.End();

                    GridView2.Visible = false;

                }

                else

                { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' لم يسفر البحث عن شيء ')", true); }


            }

        }

        protected void Button13_Click(object sender, EventArgs e)
        {

        }

    }
}