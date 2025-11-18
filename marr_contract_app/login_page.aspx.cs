using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace marr_contract_app
{
    public partial class login_page : System.Web.UI.Page
    {
        public static string userid
        {
            get
            {
                object value = HttpContext.Current.Session["userid"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["userid"] = value;
            }
        }


        public static string app
        {
            get
            {
                object value = HttpContext.Current.Session["app"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["app"] = value;
            }
        }
        public static string court
        {
            get
            {
                object value = HttpContext.Current.Session["court"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["court"] = value;
            }
        }

        public static string j_name
        {
            get
            {
                object value = HttpContext.Current.Session["j_name"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["j_name"] = value;
            }
        }

        public static string user_name
        {
            get
            {
                object value = HttpContext.Current.Session["user_name"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["user_name"] = value;
            }
        }

        public static string USER_STATUS
        {
            get
            {
                object value = HttpContext.Current.Session["USER_STATUS"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["USER_STATUS"] = value;
            }
        }
        public static string court_id_m2
        {
            get
            {
                object value = HttpContext.Current.Session["court_id_m2"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["court_id_m2"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string app_id_m2
        {
            get
            {
                object value = HttpContext.Current.Session["app_id_m2"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["app_id_m2"] = value;
            }
        }
        public static string main_id
        {
            get
            {
                object value = HttpContext.Current.Session["main_id"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["main_id"] = value;
            }
        }
        //private SqlConnection con = new SqlConnection(@"Server=WIN-290QH8AQ3VA; Database=marriage_contracts ; Integrated Security=True");
        protected void login(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["marriageContract"].ConnectionString;
            string query = @"select u.COURT_ID,u.APP_ID,u.USER_STATUS,c.NAME
                     from [BAYA].[USERS] u
                     inner join [BAYA].[COURT] c on u.COURT_ID=c.ID
                     where u.USERNAME=@name and u.USERPASS=@pass";
            using (SqlConnection conn = new SqlConnection(connstr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int st = Convert.ToInt32(reader["USER_STATUS"]);
                        int courtid = reader["COURT_ID"] != DBNull.Value ? Convert.ToInt32(reader["COURT_ID"]) : 0;
                        int appid = reader["APP_ID"] != DBNull.Value ? Convert.ToInt32(reader["APP_ID"]) : 0;
                        string courtname = reader["NAME"].ToString();

                        Session["courtname"] = courtname;
                        Session["courtid"] = courtid;

                        // set the keys main2 expects
                        Session["app_id_m2"] = appid;
                        Session["court_id_m2"] = courtid;
                        login_page.app_id_m2 = appid.ToString();
                        login_page.court_id_m2 = courtid.ToString();

                        if (st == 1) Response.Redirect("main2.aspx");
                        else if (st == 5) Response.Redirect("admin_form.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('اسم المستخدم او كلمة المرور غير صحيحة')", true);
                    }
                }
            }
        }








        //{
        //    BL.Functions BL = new BL.Functions();
        //    DataTable dt = new DataTable();

        //    dt = BL.check_user(TextBox1.Text, TextBox2.Text);
        //    USER_STATUS = dt.Rows[0]["USER_STATUS"].ToString();

        //    if (dt.Rows.Count > 0 && newCHK.Checked == true && USER_STATUS == "1")
        //    {
        //      //  user_name = dt.Rows[0]["USERNAME"].ToString();
        //        //userid = dt.Rows[0][0].ToString();

        //        //j_name = dt.Rows[0][3].ToString();
        //        user_name = dt.Rows[0]["USERNAME"].ToString();
        //        app_id_m2 = dt.Rows[0]["APP_ID"].ToString();
        //        court_id_m2 = dt.Rows[0]["COURT_ID"].ToString();
        //      //  app = dt.Rows[0][4].ToString();
        //        //court = dt.Rows[0][5].ToString();
        //        Response.Redirect("main2.aspx");

        //        //if (newCHK.Checked == true)
        //        //{
        //        //    Response.Redirect("main2.aspx");
        //    }
        //   // USER_STATUS = dt.Rows[0][8].ToString();

        //        if (dt.Rows.Count > 0 && srchCHK.Checked == true&&USER_STATUS=="5")
        //        {
        //        app_id_m2 = dt.Rows[0]["APP_ID"].ToString();
        //        court_id_m2 = dt.Rows[0]["COURT_ID"].ToString();
        //        Response.Redirect("admin_form.aspx");
        //        }


        //    else
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('اسم المستخدم او كلمة المرور غير صحيحة الرجاء اعادة  المحاولة')", true);
        //}

    }
}