using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace marr_contract_app.DAL
{
    public class DataAccessLayer
    {
        static SqlConnection SqlConnection;
       
        //consitructor to intialize the connection object
        public DataAccessLayer()
        {
            //SqlConnection = new SqlConnection(@"Server=sql5014.site4now.net; Database=DB_A322D1_institute ; Integrated Security=false; User Id=DB_A322D1_institute_admin; Password=123!@#qwe;");
            //SqlConnection = new SqlConnection(@"Server=WIN-290QH8AQ3VA; Database=marriage_contracts ; Integrated Security=True");
            string cs = ConfigurationManager.ConnectionStrings["marriageContract"].ConnectionString;

            SqlConnection = new SqlConnection(cs);
        }

        //method to open connection
        public void open() 
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();

            }

        }
        //method to close the connection
        public void close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {

                SqlConnection.Close();
            }



        }

        //method to read data from database


        public DataTable selectdata(string stored_prosedure, SqlParameter[] parm)
        {


            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_prosedure;
            sqlcmd.Connection = SqlConnection;
            if (parm != null)
            {
                for (int i = 0; i < parm.Length; i++)
                {
                    sqlcmd.Parameters.Add(parm[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //method to insert update and delete from database

        public void executecommand(string stored_prosedure, SqlParameter[] parm)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_prosedure;
            sqlcmd.Connection = SqlConnection;
            if (parm != null)
            {
                sqlcmd.Parameters.AddRange(parm);
            }
            sqlcmd.ExecuteNonQuery();
        }


    }
}
