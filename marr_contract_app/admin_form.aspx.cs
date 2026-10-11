using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace marr_contract_app
{
    public partial class admin_form : System.Web.UI.Page
    {
        public static string user_id
        {
            get
            {
                object value = HttpContext.Current.Session["user_id"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["user_id"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                marr_contract_app.BL.Functions bal = new marr_contract_app.BL.Functions();
                DataTable DT = new DataTable();
                DT = bal.get_app();
                this.app_name.DataSource = DT;
                this.app_name.DataValueField = "ID";
                this.app_name.DataTextField = "name";
                this.app_name.DataBind();
                DataTable DT1 = new DataTable();
                DT1 = bal.get_court();
                this.court_name.DataSource = DT1;
                this.court_name.DataValueField = "ID";
                this.court_name.DataTextField = "name";
                this.court_name.DataBind();
            }
           
        }
        protected void srch(object sender, EventArgs e)
        {


            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding0()", true);

        }
        protected void new_u(object sender, EventArgs e)
        {


            user_id = "";
            ClearControls(Page);
            Button33.Enabled = true;
            Button33.CssClass = "btn";


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


        }
        protected void insert(object sender, EventArgs e)
        {
            if (txt2.Text.Trim().Length == 0 ||
                txt1.Text.Trim().Length == 0||
                txt3.Text.Trim().Length == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('يرجى ملء الحقول الاجبارية')", true);
                return;
            }
            if (user_id == "")
            {
               
                BL.Functions BL = new BL.Functions();
                DataTable dt = new DataTable();
                dt = BL.GET_userid();
                if (dt.Rows.Count > 0)
                {
                    //BL.insert_user(txt2.Text, txt3.Text, txt5.Text, Int32.Parse(app_name.SelectedValue), Int32.Parse(court_name.SelectedValue), Int32.Parse(txt6.Text), Int32.Parse(dt.Rows[0][0].ToString()), Int32.Parse(txt8.Text), Int32.Parse(Select3.Value), txt1.Text);
                    BL.insert_user_main2(Int32.Parse(dt.Rows[0][0].ToString()), txt2.Text, txt3.Text, txt1.Text, Int32.Parse(app_name.SelectedValue), Int32.Parse(court_name.SelectedValue), Int32.Parse(Select3.Value));
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تم الحفظ بنجـاح')", true);
                    Button33.Enabled = false;
                    Button33.CssClass = "hide";
                }
            }
            else
            {

                BL.Functions BL = new BL.Functions();
                DataTable dt2 = new DataTable();
                dt2 = BL.GET_userid();
                if (dt2.Rows.Count > 0)
                {
                    BL.delete_user(Int32.Parse(user_id));
                    BL.insert_user_main2(Int32.Parse(dt2.Rows[0][0].ToString()), txt2.Text, txt3.Text, txt1.Text, Int32.Parse(app_name.DataValueField), Int32.Parse(court_name.DataValueField),1);
                    //BL.insert_user(txt2.Text, txt3.Text, txt5.Text, Int32.Parse(app_name.SelectedValue), Int32.Parse(court_name.SelectedValue), Int32.Parse(txt6.Text), Int32.Parse(dt2.Rows[0][0].ToString()), Int32.Parse(txt8.Text), Int32.Parse(Select3.Value), txt1.Text);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تم الحفظ بنجـاح  تم تحديث البيانات هذا القيد مدخل مسبقا')", true);
                    Button33.Enabled = false;
                    Button33.CssClass = "hide";
                }
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.Textbox1.Text == "")
            { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' قم بادخال احد الحقول على الاقل ')", true); }
            else
            {

                BL.Functions BL = new BL.Functions();
                //////////////معلومات المستخدم
                DataTable dt = new DataTable();
                dt = BL.GET_USERS("%" + this.Textbox1.Text + "%");
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


        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rownum = Convert.ToInt32(GridView2.SelectedRow.RowIndex.ToString());
            user_id = GridView2.DataKeys[rownum]["USER_ID"].ToString();
            app_name.SelectedValue = GridView2.DataKeys[rownum]["app_id"].ToString();
            court_name.SelectedValue = GridView2.DataKeys[rownum]["COURT_ID"].ToString();
            txt1.Text = GridView2.DataKeys[rownum]["FULL_NAME"].ToString();
            txt2.Text = GridView2.DataKeys[rownum]["USERNAME"].ToString();
            txt3.Text = GridView2.DataKeys[rownum]["USERPASS"].ToString();
            Select3.Value = GridView2.DataKeys[rownum]["USER_STATUS"].ToString();
            //txt5.Text = GridView2.DataKeys[rownum]["JUDGE_NAME"].ToString();
            //txt6.Text = GridView2.DataKeys[rownum]["RECORD_NO"].ToString();

            //txt8.Text = GridView2.DataKeys[rownum]["MAX_PAGE"].ToString();
            Button33.Enabled = true;
            Button33.CssClass = "btn";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Sliding()", true);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            BL.Functions BL = new BL.Functions();
            DataTable dt2 = new DataTable();
            dt2 = BL.statistics_marr(TextBox2.Text, TextBox3.Text);
            TextBox4.Text = dt2.Rows[0][0].ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["marriageContract"].ConnectionString;

            // Get all available drive letters except C:
            var drives = System.IO.DriveInfo.GetDrives();
            string partitionLetter = null;
            foreach (var drive in drives)
            {
                if (drive.IsReady && !string.Equals(drive.Name.Substring(0, 2), "C:", StringComparison.OrdinalIgnoreCase))
                {
                    partitionLetter = drive.Name.Substring(0, 2); // e.g., "D:"
                    break;
                }
            }

            // If no other partition, fallback to C: and show a message
            if (partitionLetter == null)
            {
                partitionLetter = "C:";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('لا يوجد قسم آخر غير C:، سيتم الحفظ في القسم C:')", true);
            }

            string backupDIR = partitionLetter + "\\نسخة احتياطية لعقود الزواج";
            if (!System.IO.Directory.Exists(backupDIR))
            {
                System.IO.Directory.CreateDirectory(backupDIR);
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string backupFile = backupDIR + "\\" + DateTime.Now.ToString("dd_MM_yyyy_") + "Back_up_marriage_contracts";
                    SqlCommand sqlcmd = new SqlCommand("backup database marriage_contracts to disk='" + backupFile + "'", con);
                    sqlcmd.CommandTimeout = 600; // Wait up to 10 minutes for backup
                    sqlcmd.ExecuteNonQuery();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('تمت العملية بنجاح. ')", true);
                }
            }
            catch (Exception dx)
            {
                throw (dx);
            }
        }
    }
}
