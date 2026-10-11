using System;
using System.Data;
using System.Data.SqlClient;

namespace marr_contract_app.BL
{
    public class Functions
    {
        public DataTable check_user(string name, string pass)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = name;
            param[1] = new SqlParameter("@pass", SqlDbType.NVarChar);
            param[1].Value = pass;
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[check_user]", param);
            DAL.close();
            return DT;
        }
        public void insert_user(string p_USERNAME, string p_USERPASS, string p_JUDGE_NAME, int p_APP_ID, int p_COURT_ID, int p_RECORD_NO, int user_id, int p_MAX_PAGE, int p_USER_STATUS, string p_FULL_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@p_USERNAME", SqlDbType.NVarChar);
            param[0].Value = p_USERNAME;
            param[1] = new SqlParameter("@p_USERPASS", SqlDbType.NVarChar);
            param[1].Value = p_USERPASS;
            param[2] = new SqlParameter("@p_JUDGE_NAME", SqlDbType.NVarChar);
            param[2].Value = p_JUDGE_NAME;
            param[3] = new SqlParameter("@p_APP_ID", SqlDbType.Int);
            param[3].Value = p_APP_ID;
            param[4] = new SqlParameter("@p_COURT_ID", SqlDbType.Int);
            param[4].Value = p_COURT_ID;
            param[5] = new SqlParameter("@p_RECORD_NO", SqlDbType.Int);
            param[5].Value = p_RECORD_NO;
            param[6] = new SqlParameter("@u_id", SqlDbType.Int);
            param[6].Value = user_id;
            param[7] = new SqlParameter("@p_MAX_PAGE", SqlDbType.Int);
            param[7].Value = p_MAX_PAGE;
            param[8] = new SqlParameter("@p_USER_STATUS", SqlDbType.Int);
            param[8].Value = p_USER_STATUS;
            param[9] = new SqlParameter("@p_FULL_NAME", SqlDbType.NVarChar);
            param[9].Value = p_FULL_NAME;

            DAL.open();

            DAL.executecommand("insert_user", param);
            DAL.close();

        }
        public DataTable GET_id()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[get_main_id]", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_userid()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[get_user_id]", param);
            DAL.close();
            return DT;
        }
        public void delete_user(int u_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@u_id", SqlDbType.Int);
            param[0].Value = u_id;
            DAL.open();
            DAL.executecommand("delete_user", param);
            DAL.close();

        }
        public DataTable GET_RECORD_NO(int u_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@u_id", SqlDbType.Int);
            param[0].Value = u_ID;
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[GET_RECORD_NO]", param);

            DAL.close();
            return DT;
        }
        public DataTable GET_WITNESSES(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[get_witBY_ID]", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_USERS(string F_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@F_NAME", SqlDbType.NVarChar);
            param[0].Value = F_NAME;
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[GET_USERS]", param);
            DAL.close();
            return DT;
        }
        public void UPDATE_RECORD_NO(int uid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@u_id", SqlDbType.Int);
            param[0].Value = uid;
            DAL.open();
            DAL.executecommand("UPDATE_RECORD_NO", param);
            DAL.close();

        }
        public void INSERT_PIC(int ID, int PN1, int PN2, int PN3, int R_N)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PN1", SqlDbType.Int);
            param[1].Value = PN1;
            param[2] = new SqlParameter("@PN2", SqlDbType.Int);
            param[2].Value = PN2;
            param[3] = new SqlParameter("@PN3", SqlDbType.Int);
            param[3].Value = PN3;
            param[4] = new SqlParameter("@R_N", SqlDbType.Int);
            param[4].Value = R_N;

            DAL.open();

            DAL.executecommand("INSERT_PIC", param);
            DAL.close();

        }
        public void INSERT_WITNESSES(int ID, string WN1, string WN2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@W_N1", SqlDbType.NVarChar);
            param[1].Value = WN1;
            param[2] = new SqlParameter("@W_N2", SqlDbType.NVarChar);
            param[2].Value = WN2;
            DAL.open();
            DAL.executecommand("sav_witnesses", param);
            DAL.close();

        }
        public void sav_basic(decimal MAIN_ID, int MAIN_APP_ID, int MAIN_COURT_ID, string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3, string MAIN_WIFE_SURNAME, string MAIN_WIFE_MOM1,
     string MAIN_WIFE_MOM2, string MAIN_WIFE_MOM3,
     string MAIN_WIFE_IDENTITY_ID, string MAIN_WIFE_RECORD_ID,
     string MAIN_WIFE_PAPER_ID,
     string MAIN_WIFE_DIRECTION_NAME,
     string MAIN_WIFE_BIRTH_DATE,
     string MAIN_WIFE_BIRTH_PLACE,
     int MAIN_WIFE_MARRIAGE_TYPE,
     string MAIN_WIFE_CITY_NAME,
     string MAIN_HUSBAND_NAME1,
     string MAIN_HUSBAND_NAME2,
     string MAIN_HUSBAND_NAME3,
     string MAIN_HUSBAND_SURNAME,
     string MAIN_HUSBAND_MOM1,
     string MAIN_HUSBAND_MOM2,
     string MAIN_HUSBAND_MOM3,
     string MAIN_HUSBAND_IDENTITY_ID,
     string MAIN_HUSBAND_RECORD_ID,
     string MAIN_HUSBAND_PAPER_ID,
     string MAIN_HUSBAND_DIRECTION_NAME,
     string MAIN_HUSBAND_BIRTH_DATE,
     string MAIN_HUSBAND_BIRTH_PLACE,
     int MAIN_HUSBAND_MARRIAGE_TYPE,
     string MAIN_HUSBAND_CITY_NAME,
     string JUDGE_NAME,
     string ACCEPTATION,
     string ME_DOCUMENT_DATE,
     string EXTERNAL_DOCUMENT_DATE,
     string AMOUNT_LEASED_DOWRY,
     int LEASED_DOWRY_TYPE,
     string AMOUNT_ACCELERATED_DOWRY,
     int ACCELERATED_DOWRY_TYPE,
     string RECORD_NUMBER,
     string MAIN_NUMBER,
     string RECORD_DATE,
     int IDEOLOGY,
     string USER_ID,
     string USER_DATE,
     string MAIN_NOTES,
     string HUSBAND_NATIONAL_NO,
     string WIFE_NATIONAL_NO, string HUSBAND_pass_NO,
     string WIFE_pass_NO)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[52];
            param[0] = new SqlParameter("@p_MAIN_ID", SqlDbType.Decimal);
            param[0].Value = MAIN_ID;
            param[1] = new SqlParameter("@p_MAIN_APP_ID", SqlDbType.Int);
            param[1].Value = MAIN_APP_ID;
            param[2] = new SqlParameter("@p_MAIN_COURT_ID", SqlDbType.Int);
            param[2].Value = MAIN_COURT_ID;
            param[3] = new SqlParameter("@p_MAIN_WIFE_NAME1", SqlDbType.NVarChar);
            param[3].Value = MAIN_WIFE_NAME1;
            param[4] = new SqlParameter("@p_MAIN_WIFE_NAME2", SqlDbType.NVarChar);
            param[4].Value = MAIN_WIFE_NAME2;
            param[5] = new SqlParameter("@p_MAIN_WIFE_NAME3", SqlDbType.NVarChar);
            param[5].Value = MAIN_WIFE_NAME3;
            param[6] = new SqlParameter("@p_MAIN_WIFE_SURNAME", SqlDbType.NVarChar);
            param[6].Value = MAIN_WIFE_SURNAME;
            param[7] = new SqlParameter("@p_MAIN_WIFE_MOM1", SqlDbType.NVarChar);
            param[7].Value = MAIN_WIFE_MOM1;
            param[8] = new SqlParameter("@p_MAIN_WIFE_MOM2", SqlDbType.NVarChar);
            param[8].Value = MAIN_WIFE_MOM2;
            param[9] = new SqlParameter("@p_MAIN_WIFE_MOM3", SqlDbType.NVarChar);
            param[9].Value = MAIN_WIFE_MOM3;
            param[10] = new SqlParameter("@p_MAIN_WIFE_IDENTITY_ID", SqlDbType.NVarChar);
            param[10].Value = MAIN_WIFE_IDENTITY_ID;
            param[11] = new SqlParameter("@p_MAIN_WIFE_RECORD_ID", SqlDbType.NVarChar);
            param[11].Value = MAIN_WIFE_RECORD_ID;
            param[12] = new SqlParameter("@p_MAIN_WIFE_PAPER_ID", SqlDbType.NVarChar);
            param[12].Value = MAIN_WIFE_PAPER_ID;
            param[13] = new SqlParameter("@p_MAIN_WIFE_DIRECTION_NAME", SqlDbType.NVarChar);
            param[13].Value = MAIN_WIFE_DIRECTION_NAME;
            param[14] = new SqlParameter("@p_MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar);
            param[14].Value = MAIN_WIFE_BIRTH_DATE;
            param[15] = new SqlParameter("@p_MAIN_WIFE_BIRTH_PLACE", SqlDbType.NVarChar);
            param[15].Value = MAIN_WIFE_BIRTH_PLACE;
            param[16] = new SqlParameter("@p_MAIN_WIFE_MARRIAGE_TYPE", SqlDbType.Int);
            param[16].Value = MAIN_WIFE_MARRIAGE_TYPE;
            param[17] = new SqlParameter("@p_MAIN_WIFE_CITY_NAME", SqlDbType.NVarChar);
            param[17].Value = MAIN_WIFE_CITY_NAME;
            param[18] = new SqlParameter("@p_MAIN_HUSBAND_NAME1", SqlDbType.NVarChar);
            param[18].Value = MAIN_HUSBAND_NAME1;
            param[19] = new SqlParameter("@p_MAIN_HUSBAND_NAME2", SqlDbType.NVarChar);
            param[19].Value = MAIN_HUSBAND_NAME2;
            param[20] = new SqlParameter("@p_MAIN_HUSBAND_NAME3", SqlDbType.NVarChar);
            param[20].Value = MAIN_HUSBAND_NAME3;
            param[21] = new SqlParameter("@p_MAIN_HUSBAND_SURNAME", SqlDbType.NVarChar);
            param[21].Value = MAIN_HUSBAND_SURNAME;
            param[22] = new SqlParameter("@p_MAIN_HUSBAND_MOM1", SqlDbType.NVarChar);
            param[22].Value = MAIN_HUSBAND_MOM1;
            param[23] = new SqlParameter("@p_MAIN_HUSBAND_MOM2", SqlDbType.NVarChar);
            param[23].Value = MAIN_HUSBAND_MOM2;
            param[24] = new SqlParameter("@p_MAIN_HUSBAND_MOM3", SqlDbType.NVarChar);
            param[24].Value = MAIN_HUSBAND_MOM3;
            param[25] = new SqlParameter("@p_MAIN_HUSBAND_IDENTITY_ID", SqlDbType.NVarChar);
            param[25].Value = MAIN_HUSBAND_IDENTITY_ID;
            param[26] = new SqlParameter("@p_MAIN_HUSBAND_RECORD_ID", SqlDbType.NVarChar);
            param[26].Value = MAIN_HUSBAND_RECORD_ID;
            param[27] = new SqlParameter("@p_MAIN_HUSBAND_PAPER_ID", SqlDbType.NVarChar);
            param[27].Value = MAIN_HUSBAND_PAPER_ID;
            param[28] = new SqlParameter("@p_MAIN_HUSBAND_DIRECTION_NAME", SqlDbType.NVarChar);
            param[28].Value = MAIN_HUSBAND_DIRECTION_NAME;
            param[29] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar);
            param[29].Value = MAIN_HUSBAND_BIRTH_DATE;
            param[30] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_PLACE", SqlDbType.NVarChar);
            param[30].Value = MAIN_HUSBAND_BIRTH_PLACE;
            param[31] = new SqlParameter("@p_MAIN_HUSBAND_MARRIAGE_TYPE", SqlDbType.Int);
            param[31].Value = MAIN_HUSBAND_MARRIAGE_TYPE;
            param[32] = new SqlParameter("@p_MAIN_HUSBAND_CITY_NAME", SqlDbType.NVarChar);
            param[32].Value = MAIN_HUSBAND_CITY_NAME;
            param[33] = new SqlParameter("p_JUDGE_NAME", SqlDbType.NVarChar);
            param[33].Value = JUDGE_NAME;
            param[34] = new SqlParameter("@p_ACCEPTATION", SqlDbType.NVarChar);
            param[34].Value = ACCEPTATION;
            param[35] = new SqlParameter("@ME_DOCUMENT_DATE", SqlDbType.NVarChar);
            param[35].Value = ME_DOCUMENT_DATE;
            param[36] = new SqlParameter("@p_EXTERNAL_DOCUMENT_DATE", SqlDbType.NVarChar);
            param[36].Value = EXTERNAL_DOCUMENT_DATE;
            param[37] = new SqlParameter("@p_AMOUNT_LEASED_DOWRY", SqlDbType.NVarChar);
            param[37].Value = AMOUNT_LEASED_DOWRY;
            param[38] = new SqlParameter("@p_LEASED_DOWRY_TYPE", SqlDbType.Int);
            param[38].Value = LEASED_DOWRY_TYPE;
            param[39] = new SqlParameter("@p_AMOUNT_ACCELERATED_DOWRY", SqlDbType.NVarChar);
            param[39].Value = AMOUNT_ACCELERATED_DOWRY;
            param[40] = new SqlParameter("@p_ACCELERATED_DOWRY_TYPE", SqlDbType.Int);
            param[40].Value = ACCELERATED_DOWRY_TYPE;
            param[41] = new SqlParameter("@p_RECORD_NUMBER", SqlDbType.NVarChar);
            param[41].Value = RECORD_NUMBER;
            param[42] = new SqlParameter("@p_MAIN_NUMBER", SqlDbType.NVarChar);
            param[42].Value = MAIN_NUMBER;
            param[43] = new SqlParameter("p_RECORD_DATE", SqlDbType.NVarChar);
            param[43].Value = RECORD_DATE;
            param[44] = new SqlParameter("@p_IDEOLOGY", SqlDbType.Int);
            param[44].Value = IDEOLOGY;
            param[45] = new SqlParameter("@p_USER_ID", SqlDbType.NVarChar);
            param[45].Value = USER_ID;
            param[46] = new SqlParameter("@p_USER_DATE", SqlDbType.NVarChar);
            param[46].Value = USER_DATE;
            param[47] = new SqlParameter("@p_MAIN_NOTES", SqlDbType.NVarChar);
            param[47].Value = MAIN_NOTES;
            param[48] = new SqlParameter("@p_HUSBAND_NATIONAL_NO", SqlDbType.NVarChar);
            param[48].Value = HUSBAND_NATIONAL_NO;
            param[49] = new SqlParameter("@p_WIFE_NATIONAL_NO", SqlDbType.NVarChar);
            param[49].Value = WIFE_NATIONAL_NO;
            param[50] = new SqlParameter("@p_HUSBAND_PASS_NO", SqlDbType.NVarChar);
            param[50].Value = WIFE_NATIONAL_NO;
            param[51] = new SqlParameter("@p_WIFE_PASSL_NO", SqlDbType.NVarChar);
            param[51].Value = WIFE_NATIONAL_NO;

            DAL.open();
            DAL.executecommand("[dbo].[sav_basic]", param);
            DAL.close();

        }


        public void upadate_all(int MAIN_ID, int MAIN_APP_ID, int MAIN_COURT_ID, string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3, string MAIN_WIFE_SURNAME, string MAIN_WIFE_MOM1,
string MAIN_WIFE_MOM2, string MAIN_WIFE_MOM3,
string MAIN_WIFE_IDENTITY_ID, string MAIN_WIFE_RECORD_ID,
string MAIN_WIFE_PAPER_ID,
string MAIN_WIFE_DIRECTION_NAME,
string MAIN_WIFE_BIRTH_DATE,
string MAIN_WIFE_BIRTH_PLACE,
int MAIN_WIFE_MARRIAGE_TYPE,
string MAIN_WIFE_CITY_NAME,
string MAIN_HUSBAND_NAME1,
string MAIN_HUSBAND_NAME2,
string MAIN_HUSBAND_NAME3,
string MAIN_HUSBAND_SURNAME,
string MAIN_HUSBAND_MOM1,
string MAIN_HUSBAND_MOM2,
string MAIN_HUSBAND_MOM3,
string MAIN_HUSBAND_IDENTITY_ID,
string MAIN_HUSBAND_RECORD_ID,
string MAIN_HUSBAND_PAPER_ID,
string MAIN_HUSBAND_DIRECTION_NAME,
string MAIN_HUSBAND_BIRTH_DATE,
string MAIN_HUSBAND_BIRTH_PLACE,
int MAIN_HUSBAND_MARRIAGE_TYPE,
string MAIN_HUSBAND_CITY_NAME,
string JUDGE_NAME,
string ACCEPTATION,
string ME_DOCUMENT_DATE,
string EXTERNAL_DOCUMENT_DATE,
string AMOUNT_LEASED_DOWRY,
int LEASED_DOWRY_TYPE,
string AMOUNT_ACCELERATED_DOWRY,
int ACCELERATED_DOWRY_TYPE,
string RECORD_NUMBER,
string MAIN_NUMBER,
string RECORD_DATE,
int IDEOLOGY,
string USER_ID,
string USER_DATE,
string MAIN_NOTES,
string HUSBAND_NATIONAL_NO,
string WIFE_NATIONAL_NO, string HUSBAND_pass_NO,
string WIFE_pass_NO)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[52];
            param[0] = new SqlParameter("@p_MAIN_ID", SqlDbType.Decimal);
            param[0].Value = MAIN_ID;
            param[1] = new SqlParameter("@p_MAIN_APP_ID", SqlDbType.Int);
            param[1].Value = MAIN_APP_ID;
            param[2] = new SqlParameter("@p_MAIN_COURT_ID", SqlDbType.Int);
            param[2].Value = MAIN_COURT_ID;
            param[3] = new SqlParameter("@p_MAIN_WIFE_NAME1", SqlDbType.NVarChar);
            param[3].Value = MAIN_WIFE_NAME1;
            param[4] = new SqlParameter("@p_MAIN_WIFE_NAME2", SqlDbType.NVarChar);
            param[4].Value = MAIN_WIFE_NAME2;
            param[5] = new SqlParameter("@p_MAIN_WIFE_NAME3", SqlDbType.NVarChar);
            param[5].Value = MAIN_WIFE_NAME3;
            param[6] = new SqlParameter("@p_MAIN_WIFE_SURNAME", SqlDbType.NVarChar);
            param[6].Value = MAIN_WIFE_SURNAME;
            param[7] = new SqlParameter("@p_MAIN_WIFE_MOM1", SqlDbType.NVarChar);
            param[7].Value = MAIN_WIFE_MOM1;
            param[8] = new SqlParameter("@p_MAIN_WIFE_MOM2", SqlDbType.NVarChar);
            param[8].Value = MAIN_WIFE_MOM2;
            param[9] = new SqlParameter("@p_MAIN_WIFE_MOM3", SqlDbType.NVarChar);
            param[9].Value = MAIN_WIFE_MOM3;
            param[10] = new SqlParameter("@p_MAIN_WIFE_IDENTITY_ID", SqlDbType.NVarChar);
            param[10].Value = MAIN_WIFE_IDENTITY_ID;
            param[11] = new SqlParameter("@p_MAIN_WIFE_RECORD_ID", SqlDbType.NVarChar);
            param[11].Value = MAIN_WIFE_RECORD_ID;
            param[12] = new SqlParameter("@p_MAIN_WIFE_PAPER_ID", SqlDbType.NVarChar);
            param[12].Value = MAIN_WIFE_PAPER_ID;
            param[13] = new SqlParameter("@p_MAIN_WIFE_DIRECTION_NAME", SqlDbType.NVarChar);
            param[13].Value = MAIN_WIFE_DIRECTION_NAME;
            param[14] = new SqlParameter("@p_MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar);
            param[14].Value = MAIN_WIFE_BIRTH_DATE;
            param[15] = new SqlParameter("@p_MAIN_WIFE_BIRTH_PLACE", SqlDbType.NVarChar);
            param[15].Value = MAIN_WIFE_BIRTH_PLACE;
            param[16] = new SqlParameter("@p_MAIN_WIFE_MARRIAGE_TYPE", SqlDbType.Int);
            param[16].Value = MAIN_WIFE_MARRIAGE_TYPE;
            param[17] = new SqlParameter("@p_MAIN_WIFE_CITY_NAME", SqlDbType.NVarChar);
            param[17].Value = MAIN_WIFE_CITY_NAME;
            param[18] = new SqlParameter("@p_MAIN_HUSBAND_NAME1", SqlDbType.NVarChar);
            param[18].Value = MAIN_HUSBAND_NAME1;
            param[19] = new SqlParameter("@p_MAIN_HUSBAND_NAME2", SqlDbType.NVarChar);
            param[19].Value = MAIN_HUSBAND_NAME2;
            param[20] = new SqlParameter("@p_MAIN_HUSBAND_NAME3", SqlDbType.NVarChar);
            param[20].Value = MAIN_HUSBAND_NAME3;
            param[21] = new SqlParameter("@p_MAIN_HUSBAND_SURNAME", SqlDbType.NVarChar);
            param[21].Value = MAIN_HUSBAND_SURNAME;
            param[22] = new SqlParameter("@p_MAIN_HUSBAND_MOM1", SqlDbType.NVarChar);
            param[22].Value = MAIN_HUSBAND_MOM1;
            param[23] = new SqlParameter("@p_MAIN_HUSBAND_MOM2", SqlDbType.NVarChar);
            param[23].Value = MAIN_HUSBAND_MOM2;
            param[24] = new SqlParameter("@p_MAIN_HUSBAND_MOM3", SqlDbType.NVarChar);
            param[24].Value = MAIN_HUSBAND_MOM3;
            param[25] = new SqlParameter("@p_MAIN_HUSBAND_IDENTITY_ID", SqlDbType.NVarChar);
            param[25].Value = MAIN_HUSBAND_IDENTITY_ID;
            param[26] = new SqlParameter("@p_MAIN_HUSBAND_RECORD_ID", SqlDbType.NVarChar);
            param[26].Value = MAIN_HUSBAND_RECORD_ID;
            param[27] = new SqlParameter("@p_MAIN_HUSBAND_PAPER_ID", SqlDbType.NVarChar);
            param[27].Value = MAIN_HUSBAND_PAPER_ID;
            param[28] = new SqlParameter("@p_MAIN_HUSBAND_DIRECTION_NAME", SqlDbType.NVarChar);
            param[28].Value = MAIN_HUSBAND_DIRECTION_NAME;
            param[29] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar);
            param[29].Value = MAIN_HUSBAND_BIRTH_DATE;
            param[30] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_PLACE", SqlDbType.NVarChar);
            param[30].Value = MAIN_HUSBAND_BIRTH_PLACE;
            param[31] = new SqlParameter("@p_MAIN_HUSBAND_MARRIAGE_TYPE", SqlDbType.Int);
            param[31].Value = MAIN_HUSBAND_MARRIAGE_TYPE;
            param[32] = new SqlParameter("@p_MAIN_HUSBAND_CITY_NAME", SqlDbType.NVarChar);
            param[32].Value = MAIN_HUSBAND_CITY_NAME;
            param[33] = new SqlParameter("p_JUDGE_NAME", SqlDbType.NVarChar);
            param[33].Value = JUDGE_NAME;
            param[34] = new SqlParameter("@p_ACCEPTATION", SqlDbType.NVarChar);
            param[34].Value = ACCEPTATION;
            param[35] = new SqlParameter("@ME_DOCUMENT_DATE", SqlDbType.NVarChar);
            param[35].Value = ME_DOCUMENT_DATE;
            param[36] = new SqlParameter("@p_EXTERNAL_DOCUMENT_DATE", SqlDbType.NVarChar);
            param[36].Value = EXTERNAL_DOCUMENT_DATE;
            param[37] = new SqlParameter("@p_AMOUNT_LEASED_DOWRY", SqlDbType.NVarChar);
            param[37].Value = AMOUNT_LEASED_DOWRY;
            param[38] = new SqlParameter("@p_LEASED_DOWRY_TYPE", SqlDbType.Int);
            param[38].Value = LEASED_DOWRY_TYPE;
            param[39] = new SqlParameter("@p_AMOUNT_ACCELERATED_DOWRY", SqlDbType.NVarChar);
            param[39].Value = AMOUNT_ACCELERATED_DOWRY;
            param[40] = new SqlParameter("@p_ACCELERATED_DOWRY_TYPE", SqlDbType.Int);
            param[40].Value = ACCELERATED_DOWRY_TYPE;
            param[41] = new SqlParameter("@p_RECORD_NUMBER", SqlDbType.NVarChar);
            param[41].Value = RECORD_NUMBER;
            param[42] = new SqlParameter("@p_MAIN_NUMBER", SqlDbType.NVarChar);
            param[42].Value = MAIN_NUMBER;
            param[43] = new SqlParameter("p_RECORD_DATE", SqlDbType.NVarChar);
            param[43].Value = RECORD_DATE;
            param[44] = new SqlParameter("@p_IDEOLOGY", SqlDbType.Int);
            param[44].Value = IDEOLOGY;
            param[45] = new SqlParameter("@p_USER_ID", SqlDbType.NVarChar);
            param[45].Value = USER_ID;
            param[46] = new SqlParameter("@p_USER_DATE", SqlDbType.NVarChar);
            param[46].Value = USER_DATE;
            param[47] = new SqlParameter("@p_MAIN_NOTES", SqlDbType.NVarChar);
            param[47].Value = MAIN_NOTES;
            param[48] = new SqlParameter("@p_HUSBAND_NATIONAL_NO", SqlDbType.NVarChar);
            param[48].Value = HUSBAND_NATIONAL_NO;
            param[49] = new SqlParameter("@p_WIFE_NATIONAL_NO", SqlDbType.NVarChar);
            param[49].Value = WIFE_NATIONAL_NO;
            param[50] = new SqlParameter("@p_HUSBAND_PASS_NO", SqlDbType.NVarChar);
            param[50].Value = WIFE_NATIONAL_NO;
            param[51] = new SqlParameter("@p_WIFE_PASSL_NO", SqlDbType.NVarChar);
            param[51].Value = WIFE_NATIONAL_NO;
            DAL.open();
            DAL.executecommand("[dbo].[update_basic]", param);
            DAL.close();

        }
        public DataTable CHECK_NAMES(string MAIN_WIFE_NAME1,
            string MAIN_WIFE_NAME2,
            string MAIN_WIFE_NAME3,
            string MAIN_HUSBAND_NAME1,
            string MAIN_HUSBAND_NAME2,
            string MAIN_HUSBAND_NAME3,
            string MAIN_HUSBAND_bd,
            string MAIN_wife_bd)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@p_MAIN_WIFE_NAME1", SqlDbType.NVarChar);
            param[0].Value = MAIN_WIFE_NAME1;
            param[1] = new SqlParameter("@p_MAIN_WIFE_NAME2", SqlDbType.NVarChar);
            param[1].Value = MAIN_WIFE_NAME2;
            param[2] = new SqlParameter("@p_MAIN_WIFE_NAME3", SqlDbType.NVarChar);
            param[2].Value = MAIN_WIFE_NAME3;
            param[3] = new SqlParameter("@p_MAIN_HUSBAND_NAME1", SqlDbType.NVarChar);
            param[3].Value = MAIN_HUSBAND_NAME1;
            param[4] = new SqlParameter("@p_MAIN_HUSBAND_NAME2", SqlDbType.NVarChar);
            param[4].Value = MAIN_HUSBAND_NAME2;
            param[5] = new SqlParameter("@p_MAIN_HUSBAND_NAME3", SqlDbType.NVarChar);
            param[5].Value = MAIN_HUSBAND_NAME3;
            //param[6] = new SqlParameter("@ME_DOCUMENT_DATE", SqlDbType.NVarChar);
            //param[6].Value = RECORD_DATE;
            param[6] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar);
            param[6].Value = MAIN_HUSBAND_bd;
            param[7] = new SqlParameter("@p_MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar);
            param[7].Value = MAIN_wife_bd;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[check_name]", param);
            DAL.close();
            return DT;
        }


        public DataTable SEARCH_CONTRCT(string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3, string MAIN_WIFE_BIRTH_DATE, string MAIN_HUSBAND_NAME1, string MAIN_HUSBAND_NAME2, string MAIN_HUSBAND_NAME3, string MAIN_HUSBAND_BIRTH_DATE, string ME_DOCUMENT_DATE, string record_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@p_MAIN_WIFE_NAME1", SqlDbType.NVarChar);
            param[0].Value = MAIN_WIFE_NAME1;
            param[1] = new SqlParameter("@p_MAIN_WIFE_NAME2", SqlDbType.NVarChar);
            param[1].Value = MAIN_WIFE_NAME2;
            param[2] = new SqlParameter("@p_MAIN_WIFE_NAME3", SqlDbType.NVarChar);
            param[2].Value = MAIN_WIFE_NAME3;
            param[3] = new SqlParameter("@p_MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar);
            param[3].Value = MAIN_WIFE_BIRTH_DATE;
            param[4] = new SqlParameter("@p_MAIN_HUSBAND_NAME1", SqlDbType.NVarChar);
            param[4].Value = MAIN_HUSBAND_NAME1;
            param[5] = new SqlParameter("@p_MAIN_HUSBAND_NAME2", SqlDbType.NVarChar);
            param[5].Value = MAIN_HUSBAND_NAME2;
            param[6] = new SqlParameter("@p_MAIN_HUSBAND_NAME3", SqlDbType.NVarChar);
            param[6].Value = MAIN_HUSBAND_NAME3;
            param[7] = new SqlParameter("@p_MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar);
            param[7].Value = MAIN_HUSBAND_BIRTH_DATE;
            param[8] = new SqlParameter("@ME_DOCUMENT_DATE", SqlDbType.NVarChar);
            param[8].Value = ME_DOCUMENT_DATE;
            param[9] = new SqlParameter("@p_MAIN_record_no", SqlDbType.NVarChar);
            param[9].Value = record_no;

            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[search_contract]", param);
            DAL.close();
            return DT;
        }


        public DataTable SEARCH_CONTRCTbyID(decimal MAIN_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@mainId", SqlDbType.Decimal);
            param[0].Value = MAIN_ID;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[search_contr_byID]", param);
            DAL.close();
            return DT;
        }

        public DataTable IMG_LINK_byID(int MAIN_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = MAIN_ID;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("[dbo].[get__imgeBY_ID]", param);
            DAL.close();
            return DT;
        }

        public void SAV_BASIC_MAIN2(decimal MAIN_ID, int MAIN_APP_ID, int MAIN_COURT_ID, string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3,
                                    string MAIN_HUSBAND_NAME1, string MAIN_HUSBAND_NAME2, string MAIN_HUSBAND_NAME3, string MAIN_WIFE_BIRTH_DATE, string MAIN_HUSBAND_BIRTH_DATE, int MAIN_WIFE_MARRIAGE_TYPE, int MAIN_HUSBAND_MARRIAGE_TYPE,
                                    string MAIN_NOTES, string USER_DATE, string USER_ID, string RECORD_NUMBER, string RECORD_DATE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@MAIN_ID", SqlDbType.Decimal);
            param[0].Value = MAIN_ID;
            param[1] = new SqlParameter("@MAIN_APP_ID", SqlDbType.Int);
            param[1].Value = MAIN_APP_ID;
            param[2] = new SqlParameter("@MAIN_COURT_ID", SqlDbType.Int);
            param[2].Value = MAIN_COURT_ID;
            param[3] = new SqlParameter("@MAIN_WIFE_NAME1", SqlDbType.NVarChar, 50);
            param[3].Value = MAIN_WIFE_NAME1;
            param[4] = new SqlParameter("@MAIN_WIFE_NAME2", SqlDbType.NVarChar, 50);
            param[4].Value = MAIN_WIFE_NAME2;
            param[5] = new SqlParameter("@MAIN_WIFE_NAME3", SqlDbType.NVarChar, 50);
            param[5].Value = MAIN_WIFE_NAME3;
            param[6] = new SqlParameter("@MAIN_HUSBAND_NAME1", SqlDbType.NVarChar, 50);
            param[6].Value = MAIN_HUSBAND_NAME1;
            param[7] = new SqlParameter("@MAIN_HUSBAND_NAME2", SqlDbType.NVarChar, 50);
            param[7].Value = MAIN_HUSBAND_NAME2;
            param[8] = new SqlParameter("@MAIN_HUSBAND_NAME3", SqlDbType.NVarChar, 50);
            param[8].Value = MAIN_HUSBAND_NAME3;
            param[9] = new SqlParameter("@MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar, 50);
            param[9].Value = MAIN_WIFE_BIRTH_DATE;
            param[10] = new SqlParameter("@MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar, 50);
            param[10].Value = MAIN_HUSBAND_BIRTH_DATE;
            param[11] = new SqlParameter("@MAIN_WIFE_MARRIAGE_TYPE", SqlDbType.Int);
            param[11].Value = MAIN_WIFE_MARRIAGE_TYPE;
            param[12] = new SqlParameter("@MAIN_HUSBAND_MARRIAGE_TYPE", SqlDbType.Int);
            param[12].Value = MAIN_HUSBAND_MARRIAGE_TYPE;
            param[13] = new SqlParameter("@MAIN_NOTES", SqlDbType.NVarChar, 500);
            param[13].Value = MAIN_NOTES;
            param[14] = new SqlParameter("@USER_DATE", SqlDbType.NVarChar, 10);
            param[14].Value = USER_DATE;
            param[15] = new SqlParameter("@USER_ID", SqlDbType.NVarChar, 200);
            param[15].Value = USER_ID;
            param[16] = new SqlParameter("@RECORD_NUMBER", SqlDbType.NVarChar, 50);
            param[16].Value = RECORD_NUMBER;
            param[17] = new SqlParameter("@RECORD_DATE", SqlDbType.NVarChar, 10);
            param[17].Value = RECORD_DATE;
            DAL.open();
            DAL.executecommand("[dbo].[SAV_BASIC_MAIN2]", param);
            DAL.close();








        }
        public DataTable select_court2()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("select_court2", param);
            DAL.close();
            return DT;
        }

        public void INSERT_PIC_MAIN2(int ID, string P_N1, string P_N2, string P_N3, string P_N4, int R_N)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@P_N1", SqlDbType.NVarChar, 1);
            param[1].Value = P_N1;
            param[2] = new SqlParameter("@P_N2", SqlDbType.NVarChar, 1);
            param[2].Value = P_N2;
            param[3] = new SqlParameter("@P_N3", SqlDbType.NVarChar, 1);
            param[3].Value = P_N3;
            param[4] = new SqlParameter("@P_N4", SqlDbType.NVarChar, 1);
            param[4].Value = P_N4;
            param[5] = new SqlParameter("@R_N", SqlDbType.Int);
            param[5].Value = R_N;

            DAL.open();
            DAL.executecommand("[dbo].[INSERT_PIC_MAIN2]", param);
            DAL.close();

        }
public void insert_with_edit(int id,string p_n1,string p_n2,string p_n3,string p_n4,int r_n)
        {

        }
        public void update_all_main2(string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3, string MAIN_HUSBAND_NAME1, string MAIN_HUSBAND_NAME2, string MAIN_HUSBAND_NAME3,
                                     string MAIN_WIFE_BIRTH_DATE, string MAIN_HUSBAND_BIRTH_DATE, int MAIN_WIFE_MARRIAGE_TYPE, int MAIN_HUSBAND_MARRIAGE_TYPE, string MAIN_NOTES, string UPDATE_DATE,
                                     string UPDATE_USER, string RECORD_NUMBER, string RECORD_DATE, decimal main_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@MAIN_WIFE_NAME1", SqlDbType.NVarChar, 50);
            param[0].Value = MAIN_WIFE_NAME1;
            param[1] = new SqlParameter("@MAIN_WIFE_NAME2", SqlDbType.NVarChar, 50);
            param[1].Value = MAIN_WIFE_NAME2;
            param[2] = new SqlParameter("@MAIN_WIFE_NAMe3", SqlDbType.NVarChar, 50);
            param[2].Value = MAIN_WIFE_NAME3;
            param[3] = new SqlParameter("@MAIN_HUSBAND_NAME1", SqlDbType.NVarChar, 50);
            param[3].Value = MAIN_HUSBAND_NAME1;
            param[4] = new SqlParameter("@MAIN_HUSBAND_NAME2", SqlDbType.NVarChar, 50);
            param[4].Value = MAIN_HUSBAND_NAME2;
            param[5] = new SqlParameter("@MAIN_HUSBAND_NAME3", SqlDbType.NVarChar, 50);
            param[5].Value = MAIN_HUSBAND_NAME3;
            param[6] = new SqlParameter("@MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar, 20);
            param[6].Value = MAIN_WIFE_BIRTH_DATE;
            param[7] = new SqlParameter("@MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar, 20);
            param[7].Value = MAIN_HUSBAND_BIRTH_DATE;
            param[8] = new SqlParameter("@MAIN_WIFE_MARRIAGE_TYPE", SqlDbType.Int);
            param[8].Value = MAIN_WIFE_MARRIAGE_TYPE;
            param[9] = new SqlParameter("@MAIN_HUSBAND_MARRIAGE_TYPE", SqlDbType.Int);
            param[9].Value = MAIN_HUSBAND_MARRIAGE_TYPE;
            param[10] = new SqlParameter("@MAIN_NOTES", SqlDbType.NVarChar, 200);
            param[10].Value = MAIN_NOTES;
            param[11] = new SqlParameter("@UPDATE_DATE", SqlDbType.NVarChar, 200);
            param[11].Value = UPDATE_DATE;
            param[12] = new SqlParameter("@UPDATE_USER", SqlDbType.NVarChar, 200);
            param[12].Value = UPDATE_USER;
            param[13] = new SqlParameter("@RECORD_NUMBER", SqlDbType.NVarChar, 50);
            param[13].Value = RECORD_NUMBER;
            param[14] = new SqlParameter("@RECORD_DATE", SqlDbType.NVarChar, 10);
            param[14].Value = RECORD_DATE;
            param[15] = new SqlParameter("@main_id", SqlDbType.Decimal);
            param[15].Value = main_id;

            DAL.open();
            DAL.executecommand("[dbo].[update_all_main2]", param);
            DAL.close();

        }

        public void update_pic_main2(int id, string p_n1, string p_n2, string p_n3, string p_n4, int r_n, int new_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@p_n1", SqlDbType.NVarChar, 1);
            param[1].Value = p_n1;
            param[2] = new SqlParameter("@p_n2", SqlDbType.NVarChar, 1);
            param[2].Value = p_n2;
            param[3] = new SqlParameter("@p_n3", SqlDbType.NVarChar, 1);
            param[3].Value = p_n3;
            param[4] = new SqlParameter("@p_n4", SqlDbType.NVarChar, 1);
            param[4].Value = p_n4;
            param[5] = new SqlParameter("@r_n", SqlDbType.Int);
            param[5].Value = r_n;
            param[6] = new SqlParameter("@new_id", SqlDbType.Int);
            param[6].Value = new_id;
            DAL.open();
            DAL.executecommand("[dbo].[update_pic_main2]", param);
            DAL.close();
        }
        public DataTable select_new_id(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@MAIN_APP_ID ", SqlDbType.Int);
            //param[0].Value = MAIN_APP_ID;
            //param[1] = new SqlParameter("@MAIN_COURT_ID ", SqlDbType.Int);
            //param[1].Value = MAIN_COURT_ID;
            param[0] = new SqlParameter("@id ", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("select_new_id", param);
            DAL.close();
            return DT;
        }
        public DataTable get_imge_main2(int r_n, string p_n1, string p_n2, string p_n3)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            //param[0] = new SqlParameter("@MAIN_APP_ID ", SqlDbType.Int);
            //param[0].Value = MAIN_APP_ID;
            //param[1] = new SqlParameter("@MAIN_COURT_ID ", SqlDbType.Int);
            //param[1].Value = MAIN_COURT_ID;
            param[0] = new SqlParameter("@r_n ", SqlDbType.Int);
            param[0].Value = r_n;
            param[1] = new SqlParameter("@p_n1 ", SqlDbType.NVarChar, 1);
            param[1].Value = p_n1;
            param[2] = new SqlParameter("@p_n2 ", SqlDbType.NVarChar, 1);
            param[2].Value = p_n2;
            param[3] = new SqlParameter("@p_n3 ", SqlDbType.NVarChar, 1);
            param[3].Value = p_n3;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("get_imge_main2", param);
            DAL.close();
            return DT;
        }
        public void insert_user_main2(int user_id, string username, string userpass, string full_name ,int appName,int courtName, int status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;
            param[1] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[1].Value = username;
            param[2] = new SqlParameter("@userpass", SqlDbType.NVarChar, 50);
            param[2].Value = userpass;
            param[3] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[3].Value = full_name;
            param[4] = new SqlParameter("@app_id", SqlDbType.Int);
            param[4].Value = appName;
            param[5] = new SqlParameter("@court_id", SqlDbType.Int);
            param[5].Value = courtName;
            param[6] = new SqlParameter("@stutesCode", SqlDbType.Int);
            param[6].Value = status;


            DAL.open();
            DAL.executecommand("[dbo].[insert_user_main2]", param);
            DAL.close();
        }
        public DataTable statistics_marr(string USER_DATE, string USER_DATE2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@USER_DATE", SqlDbType.NVarChar, 10);
            param[0].Value = USER_DATE;
            param[1] = new SqlParameter("@USER_DATE2", SqlDbType.NVarChar, 10);
            param[1].Value = USER_DATE2;
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("statistics_marr", param);
            DAL.close();
            return DT;


        }
        public DataTable get_court()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("get_court", param);
            DAL.close();
            return DT;
        }
        public DataTable get_app()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("get_app", param);
            DAL.close();
            return DT;
        }
        public DataTable serch_all(string MAIN_WIFE_NAME1, string MAIN_WIFE_NAME2, string MAIN_WIFE_NAME3,
      string MAIN_HUSBAND_NAME1, string MAIN_HUSBAND_NAME2, string MAIN_HUSBAND_NAME3,
      string MAIN_WIFE_BIRTH_DATE, string MAIN_HUSBAND_BIRTH_DATE, string RECORD_NUMBER, string RECORD_DATE, int appId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@MAIN_WIFE_NAME1", SqlDbType.NVarChar, 50) { Value = MAIN_WIFE_NAME1 ?? string.Empty };
            param[1] = new SqlParameter("@MAIN_WIFE_NAME2", SqlDbType.NVarChar, 50) { Value = MAIN_WIFE_NAME2 ?? string.Empty };
            param[2] = new SqlParameter("@MAIN_WIFE_NAME3", SqlDbType.NVarChar, 50) { Value = MAIN_WIFE_NAME3 ?? string.Empty };
            param[3] = new SqlParameter("@MAIN_HUSBAND_NAME1", SqlDbType.NVarChar, 50) { Value = MAIN_HUSBAND_NAME1 ?? string.Empty };
            param[4] = new SqlParameter("@MAIN_HUSBAND_NAME2", SqlDbType.NVarChar, 50) { Value = MAIN_HUSBAND_NAME2 ?? string.Empty };
            param[5] = new SqlParameter("@MAIN_HUSBAND_NAME3", SqlDbType.NVarChar, 50) { Value = MAIN_HUSBAND_NAME3 ?? string.Empty };
            param[6] = new SqlParameter("@MAIN_WIFE_BIRTH_DATE", SqlDbType.NVarChar, 20) { Value = MAIN_WIFE_BIRTH_DATE ?? string.Empty };
            param[7] = new SqlParameter("@MAIN_HUSBAND_BIRTH_DATE", SqlDbType.NVarChar, 20) { Value = MAIN_HUSBAND_BIRTH_DATE ?? string.Empty };
            param[8] = new SqlParameter("@RECORD_NUMBER", SqlDbType.NVarChar, 50) { Value = RECORD_NUMBER ?? string.Empty };
            param[9] = new SqlParameter("@RECORD_DATE", SqlDbType.NVarChar, 10) { Value = RECORD_DATE ?? string.Empty };
            param[10] = new SqlParameter("@APP_ID", SqlDbType.Int) { Value = appId == 0 ? (object)DBNull.Value : appId };
            DAL.open();
            DataTable DT = DAL.selectdata("serch_all", param);
            DAL.close();
            return DT;
        }

        public void delete_contracts(decimal main_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("main_id", SqlDbType.Decimal);
            param[0].Value = main_id;
            DAL.open();
            DAL.executecommand("delete_contracts", param);
            DAL.close();


        }
        public void delete_img(decimal id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("id", SqlDbType.Decimal);
            param[0].Value = id;
            DAL.open();
            DAL.executecommand("delete_img", param);
            DAL.close();


        }
        public DataTable search_monthly_records(string record_date_from,string record_date_to)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@record_date_from", SqlDbType.NVarChar,10);
            param[0].Value = record_date_from;

            param[1] = new SqlParameter("@record_date_to", SqlDbType.NVarChar,10);
            param[1].Value = record_date_to;

            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("search_monthly_records", param);
            DAL.close();
            return DT;
        }

    }



}
