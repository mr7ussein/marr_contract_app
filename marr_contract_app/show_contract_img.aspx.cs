using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Configuration;

namespace marr_contract_app
{
    public partial class show_contract_img : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            int appId = 0, courtId = 0, contractId = 0;

            // Prefer query string, then fall back to session
            int.TryParse(Request.QueryString["appId"], out appId);
            if (appId == 0) int.TryParse(Convert.ToString(Session["app_id_m2"]), out appId);

            int.TryParse(Request.QueryString["courtId"], out courtId);
            if (courtId == 0) int.TryParse(Convert.ToString(Session["court_id_m2"]), out courtId);

            string imgParam = Request.QueryString["img"];
            string imageFileName = null;

            // If an explicit image token was provided use it
            if (!string.IsNullOrWhiteSpace(imgParam))
            {
                imageFileName = imgParam;
            }
            else if (int.TryParse(Request.QueryString["contractId"], out contractId) && contractId > 0)
            {
                // Query DB for a picture row for this contract (build image token the same way main2 did)
                try
                {
                    string connString = ConfigurationManager.ConnectionStrings["marriageContract"].ConnectionString;
                    using (var conn = new SqlConnection(connString))
                    using (var cmd = new SqlCommand("SELECT TOP 1 R_N, P_N1, P_N2, P_N3 FROM [BAYA].[PICTURE] WHERE id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", contractId);
                        conn.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                var r_n = Convert.ToString(rdr["R_N"]);
                                var p1 = Convert.ToString(rdr["P_N1"]);
                                var p2 = Convert.ToString(rdr["P_N2"]);
                                var p3 = Convert.ToString(rdr["P_N3"]);
                                // Recreate token used elsewhere: R_N + "/" + P_N3 + P_N2 + P_N1
                                imageFileName = string.Concat(r_n, "/", p3, p2, p1);
                            }
                        }
                    }
                }
                catch
                {
                    // Log or handle DB error as needed. Keep it silent for now.
                    imageFileName = null;
                }
            }
            else
            {
                // final fallback: use session-based static from main2 if available
                imageFileName = main2.imge;
            }

            // Only set ImageUrl when we have required pieces
            if (!string.IsNullOrWhiteSpace(imageFileName) && appId > 0 && courtId > 0)
            {
                // ensure no accidental double slashes; this path matches your existing structure
                Image1.ImageUrl = string.Format("~/contract_image/{0}/{1}/{2}.jpg", appId, courtId, imageFileName);
            }
            else
            {
                // If you want to show a placeholder or hide the control:
                Image1.Visible = false;
                // Optionally show a message to user (use a Label control on the page)
                // lblMessage.Text = "Image not found or missing parameters.";
            }
        }
    }
}