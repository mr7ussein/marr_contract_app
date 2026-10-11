

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace marr_contract_app
{
    


    public partial class main2 : System.Web.UI.Page
    {
        public static string img
        {
            get
            {
                object value = HttpContext.Current.Session["img"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["img"] = value;
            }
        }
        public static string flag_id
        {
            get
            {
                object value = HttpContext.Current.Session["flag_id"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["flag_id"] = value;
            }
        }
        public static string img_link
        {
            get
            {
                object value = HttpContext.Current.Session["img_link"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["img_link"] = value;
            }
        }
        public static string imge
        {
            get
            {
                object value = HttpContext.Current.Session["imge"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["imge"] = value;
            }
        }
        public static string main_no_flag
        {
            get
            {
                object value = HttpContext.Current.Session["main_no_flag"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["main_no_flag"] = value;
            }
        }
        public static string record_no_flag
        {
            get
            {
                object value = HttpContext.Current.Session["record_no_flag"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["record_no_flag"] = value;
            }
        }
        public static string record_date_flag
        {
            get
            {
                object value = HttpContext.Current.Session["record_date_flag"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["record_date_flag"] = value;
            }
        }
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marriageContract"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

             

                marr_contract_app.BL.Functions bal = new marr_contract_app.BL.Functions();
                DataTable DT = new DataTable();
                DT = bal.get_app();
                this.txt1.DataSource = DT;
                this.txt1.DataValueField = "ID";
                this.txt1.DataTextField = "name";
                this.txt1.DataBind();
                DataTable DT1 = new DataTable();
                DT1 = bal.select_court2();
                //this.txt2.DataSource = DT1;
                //this.txt2.DataValueField = "ID";
                //this.txt2.DataTextField = "name";

                //  this.txt2.DataBind();



                court_name.Visible = false;
                court_id.Visible = false;
                maincourtid1.Visible = false;
                TextBox2.Visible = false;
              TextBox22.Visible = false; 
            Textbox1.Visible = false;
                newid1.Visible = false;
                newid2.Visible = false;
                newid3.Visible = false;

                if (Session["courtname"] != null)
                {
                    court_name.Text = Session["courtname"].ToString();
                    court_id.Text = Session["courtid"].ToString();
                    txt2.Text = Session["courtname"].ToString();
                }
               


            }
        }
        protected void SaveToDB(object sender, EventArgs e)
        {

            decimal id = 0;
            string daten = System.DateTime.Today.ToString("yyyy-MM-dd");
            marr_contract_app.BL.Functions bal = new marr_contract_app.BL.Functions();
            DataTable DT0 = new DataTable();
            DataTable DT = new DataTable();
            if (this.txt8.Text.Trim().Length == 0 ||
                this.txt9.Text.Trim().Length == 0||
                this.txt4.Text.Trim().Length == 0||
                this.txt5.Text.Trim().Length == 0||
                txt_record_no.Text.Trim().Length == 0)
            {
                 ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تأكد من ادخال البيانات الاساسية المطلوبة ')", true);
                return;
            }
            if (txt_record_no.Text != "")
            {
                DT = bal.GET_id();
                if (DT.Rows.Count > 0)
                {
                    id = Decimal.Parse(DT.Rows[0][0].ToString()) + 1;


                    DataTable dtsrch = new DataTable();
                    dtsrch = bal.CHECK_NAMES(
                                                this.txt8.Text, this.txt9.Text, this.txt10.Text, // Wife names
                                                this.txt4.Text, this.txt5.Text, this.txt6.Text, // Husband names
                                                                                                // ?
                                                this.datepicker2.Text,                          // ?
                                                this.datepicker3.Text                           // ?
                                            );
                    if (dtsrch.Rows.Count > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' القيد مكرر قم بالبحث عنه وتعديله ان رغبت ')", true);
                    }
                    else
                    {
                        bal.SAV_BASIC_MAIN2(id, Int32.Parse(txt1.Value), Int32.Parse(court_id.Text), txt8.Text, txt9.Text, txt10.Text, txt4.Text, txt5.Text, txt6.Text, datepicker3.Text, datepicker2.Text, Int32.Parse(txt27.Value), Int32.Parse(txt26.Value), txt_note.Text, daten, login_page.user_name, txt_record_no.Text, txt_RecordDate.Text);

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تـم الحفظ ')", true);
                        flag_id = id.ToString();
                        loadpic();
                        gridView.Visible = true;

                    }
                }
            }

            else { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تاكد من ادخال البيانات ')", true); }


        }
        protected void d_entry(object sender, EventArgs e)
        {
            ClearControls(Page);
            if (Session["courtname"] != null)
            {
                court_name.Text = Session["courtname"].ToString();
                court_id.Text = Session["courtid"].ToString();
                txt2.Text = Session["courtname"].ToString();
            }
            txt2.Visible = true;

            txt26.Value = "0";
            txt27.Value = "0";
            gridView.Visible = true;
            lblmsg.Text = "";
            

        }
        protected void prevv(object sender, EventArgs e)
        {
            int rownum = Convert.ToInt32(GridView2.SelectedRow.RowIndex.ToString());
            flag_id = GridView2.DataKeys[rownum]["MAIN_ID"].ToString();

            maincourtid1.Text = flag_id;

            BL.Functions BL = new BL.Functions();
            //////////////معلومات اساسية
            DataTable dt = new DataTable();

            dt = BL.SEARCH_CONTRCTbyID(Decimal.Parse(flag_id));
            string courtId = dt.Rows[0]["MAIN_COURT_ID"].ToString();
          
            string contractId = flag_id;
            string appId = txt1.Value;

            // Redirect with query parameters
            string url = $"show_contract_img.aspx?contractId={contractId}&appId={appId}&courtId={courtId}";
            Response.Redirect(url);

        }
        protected void srch(object sender, EventArgs e)
        {

            //ClearControls(Page);
            GridView2.Visible = false;
            
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding0()", true);

        }
        public void ClearControls(Control c)
        {
            foreach (Control c1 in c.Controls)
            {
                if (c1.GetType() == typeof(TextBox))
                {
                    // if(this.txt_court_id.Text!="")
                    ((TextBox)c1).Text = "";
                }
                if (c1.HasControls())
                {
                    ClearControls(c1);
                }
            }

            flag_id = "";
            img_link = "";
        }
        //local
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            txt2.Visible = true;
            record_date_flag = "";

            if (this.Textbox7.Text == "" && this.Textbox8.Text == "" && this.Textbox9.Text == "" && this.TextBox12.Text == "" && this.Textbox3.Text == "" && this.Textbox4.Text == "" && this.Textbox5.Text == "" && this.TextBox11.Text == "" && this.TextBox13.Text == "" && srch_record_no.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' قم بادخال احد الحقول على الاقل ')", true);
                return;
            }

            int appId = 0, courtId = 0;
            int.TryParse(Convert.ToString(Session["app_id_m2"]), out appId);
           // int.TryParse(Convert.ToString(Session["court_id_m2"]), out courtId);
            // optional fallback:
            if (appId == 0) int.TryParse(Convert.ToString(Session["app"]), out appId);
           // if (courtId == 0) int.TryParse(Convert.ToString(Session["courtid"]), out courtId);

            BL.Functions BL = new BL.Functions();
            DataTable dt = BL.serch_all(
                Textbox7.Text, Textbox8.Text, Textbox9.Text,
                Textbox3.Text, Textbox4.Text, Textbox5.Text,
                TextBox12.Text, TextBox11.Text, srch_record_no.Text, TextBox13.Text,
                appId
            );

            if (dt.Rows.Count > 0)
            {
                this.GridView2.DataSource = dt;
                this.GridView2.DataBind();
                GridView2.Visible = true;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding0()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' لم يسفر البحث عن شيء ')", true);
                GridView2.Visible = false;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding0()", true);
            }
        }
        protected void loadgrid()
        {
            string connstring = (ConfigurationManager.ConnectionStrings["marriageContract"].Name);
            using (SqlConnection conn = new SqlConnection(connstring))
            using (SqlCommand cmd = new SqlCommand("select [MAIN_COURT_ID] from [BAYA].[MAIN_TABLE]", conn))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }

        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int rownum = Convert.ToInt32(GridView2.SelectedRow.RowIndex.ToString());
            flag_id = GridView2.DataKeys[rownum]["MAIN_ID"].ToString();
            maincourtid1.Text = flag_id;
            
            BL.Functions BL = new BL.Functions();
            //////////////معلومات اساسية
            DataTable dt = new DataTable();
            
            dt = BL.SEARCH_CONTRCTbyID(Decimal.Parse(flag_id));
            TextBox2.Text = dt.Rows[0]["MAIN_COURT_ID"].ToString();


            if (dt.Rows.Count > 0 )
            {

                //-------------------- بيانات زوجة
                txt8.Text = dt.Rows[0][0].ToString();
                txt9.Text = dt.Rows[0][1].ToString();
                txt10.Text = dt.Rows[0][2].ToString();
                txt11.Text = dt.Rows[0][3].ToString();

                datepicker3.Text = dt.Rows[0][11].ToString();

                txt27.Value = dt.Rows[0][13].ToString();

                //--------------------

                //-------------------بيانات زوج
                txt4.Text = dt.Rows[0][15].ToString();
                txt5.Text = dt.Rows[0][16].ToString();
                txt6.Text = dt.Rows[0][17].ToString();
                txt7.Text = dt.Rows[0][18].ToString();

                datepicker2.Text = dt.Rows[0][26].ToString();
                //txt24.Text = dt.Rows[0][27].ToString();
                txt26.Value = dt.Rows[0][28].ToString();

                txt_record_no.Text = dt.Rows[0][36].ToString();
                txt_note.Text = dt.Rows[0][42].ToString();
                string dateTime = dt.Rows[0][38].ToString();

                txt_RecordDate.Text = dt.Rows[0]["RECORD_DATE"].ToString();
                //------------------معلومات صورة
                Textbox1.Text = dt.Rows[0]["MAIN_COURT_ID"].ToString();
                loadpic();

            }

        }
        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                e.Row.Attributes["onmouseover"] = "javascript:setMouseOverColor(this);";
                e.Row.Attributes["onmouseout"] = "javascript:setMouseOutColor(this);";
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView2, "Select$" + e.Row.RowIndex);

            }
        }
        protected void update_all(object sender, EventArgs e)
        {
   
            if (flag_id.Trim().Length == 0) {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('الحقول فارغة')", true);
                return;
            }
            // Ask client for confirmation first. If not confirmed, show browser confirm and re-submit with marker.
            decimal id = Decimal.Parse(flag_id);
           
            string daten = System.DateTime.Today.ToString("yyyy-MM-dd");
            // User confirmed -> perform update (existing logic)
            
           
            marr_contract_app.BL.Functions bal = new marr_contract_app.BL.Functions();

            bal.update_all_main2(
                txt8.Text, txt9.Text, txt10.Text,
                txt4.Text, txt5.Text, txt6.Text,
                datepicker3.Text, datepicker2.Text,
                Int32.Parse(txt27.Value),
                Int32.Parse(txt26.Value),
                txt_note.Text,
                daten,
                login_page.user_name,
                txt_record_no.Text,
                txt_RecordDate.Text,
                id
            );

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تم التعديل بنجاح')", true);
        }

        protected void loadpic()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [BAYA].[PICTURE] where ID=" + flag_id, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gridView.DataSource = ds;
                gridView.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                gridView.DataSource = ds;
                gridView.DataBind();
                int columncount = gridView.Rows[0].Cells.Count;
                lblmsg.Text = " لم يتم اضافة صورة لهذا العقد !!!";
                gridView.Visible = true;
            }
        }
        protected void gridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridView.EditIndex = e.NewEditIndex;
            loadpic();
        }
        protected void gridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rownum = Convert.ToInt32(GridView2.SelectedRow.RowIndex.ToString());
            TextBox txtR_N = (TextBox)gridView.Rows[e.RowIndex].FindControl("txtR_N");
            TextBox txt11 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt1");
            TextBox txt12 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt2");
            TextBox txt3 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt3");
            TextBox txt4 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt4");
            flag_id = GridView2.DataKeys[rownum]["MAIN_ID"].ToString();
            maincourtid1.Text = flag_id;

            BL.Functions BL = new BL.Functions();
            //////////////معلومات اساسية
            DataTable dt = new DataTable();

            dt = BL.SEARCH_CONTRCTbyID(Decimal.Parse(flag_id));
            string courtId = dt.Rows[0]["MAIN_COURT_ID"].ToString();
            // Get court_id from DataKeys


            imge = txtR_N.Text + "/" +txt4.Text+ txt3.Text + txt12.Text + txt11.Text;
            Image6.ImageUrl = "~/contract_image/" + txt1.Value + "/" + courtId + "/" + imge + ".jpg";
            if (Image6.ImageUrl != "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('لاتوجد صوره لهذا العقد')", true);
            }
        }
            
         
        
        protected void gridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridView.EditIndex = -1;
            loadpic();
        }
        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            TextBox txtR_N = (TextBox)gridView.Rows[e.RowIndex].FindControl("txtR_N");
            TextBox txt1 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt1");
            TextBox txt2 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt2");
            TextBox txt3 = (TextBox)gridView.Rows[e.RowIndex].FindControl("txt3");


            con.Open();
            SqlCommand cmd = new SqlCommand("delete from [BAYA].PICTURE  where id=" + flag_id + " and R_N='" + txtR_N.Text + "' and P_N1='" + txt1.Text + "' and P_N2='" + txt2.Text + "' and  P_N3='" + txt3.Text + "'", con);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                loadpic();
                lblmsg.BackColor = Color.Red;
                lblmsg.ForeColor = Color.White;
                lblmsg.Text = "       تم الحذف بنجاح..........    ";
            }
        }
        
        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string id = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "id"));
                Button lnkbtnresult = (Button)e.Row.FindControl("ButtonDelete");
                if (lnkbtnresult != null)
                {
                    lnkbtnresult.Attributes.Add("onclick", "javascript:return deleteConfirm('" +id + "')");
                }
            }
        }
        protected void gridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                TextBox inRN = (TextBox)gridView.FooterRow.FindControl("inR_N");
                TextBox inTXT1 = (TextBox)gridView.FooterRow.FindControl("in1");
                TextBox inTXT2 = (TextBox)gridView.FooterRow.FindControl("in2");
                TextBox inTXT3 = (TextBox)gridView.FooterRow.FindControl("in3");
                TextBox inTXT4 = (TextBox)gridView.FooterRow.FindControl("in4");


                con.Open();
                SqlCommand cmd =
                    new SqlCommand(
                        "insert into [BAYA].PICTURE ([id],[R_N],[P_N1],[P_N2],[P_N3],[p_N4]) values('" + Decimal.Parse(flag_id) + "','" +
                        inRN.Text + "','" + inTXT1.Text + "','" + inTXT2.Text + "','" + inTXT3.Text +"','"+inTXT4.Text+ "')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result == 1)
                {
                    loadpic();
                    lblmsg.BackColor = Color.Green;
                    lblmsg.ForeColor = Color.White;
                    lblmsg.Text = "     تمت اضافة الصورة بنجاح......    ";
                }
                else
                {
                    lblmsg.BackColor = Color.Red;
                    lblmsg.ForeColor = Color.White;
                    lblmsg.Text =  " Error while adding row.....";
                }
            }
        }
       
        protected void delete_click(object sender, EventArgs e)
        {
            // If the user hasn't confirmed yet, show a browser confirm dialog and re-submit with a marker.
           

            // User confirmed -> perform deletion actions
            marr_contract_app.BL.Functions bal = new marr_contract_app.BL.Functions();

            // Ensure flag_id is the id to delete
            TextBox22.Text = flag_id;
            decimal id = Decimal.Parse(TextBox22.Text);

            bal.delete_contracts(id);
            bal.delete_img(id);

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تـم الحـذف')", true);

            // Clear UI and restore session court info
            ClearControls(Page);
            if (Session["courtname"] != null)
            {
                court_name.Text = Session["courtname"].ToString();
                court_id.Text = Session["courtid"].ToString();
                txt2.Text = Session["courtname"].ToString();
            }

            txt26.Value = "0";
            txt27.Value = "0";
            gridView.Visible = false;
            lblmsg.Text = "";
        }
    }
}