using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DbContext
    {
        private DataSet dSet;
        public DataSet DSet
        {
            get { return dSet; }
            set { dSet = value; }
        }
        private static SqlConnection connect;
        private static string strConnect;
        private static string strSeverName, strDataBaseName;
        public static string strUserName, strPassWord;

        //private string database;

        //public string dataBase
        //{
        //    get { return strDataBaseName; }
        //    set { strDataBaseName = value; }
        //}
        public string StrPassWord
        {
            get { return strPassWord; }
            set { strPassWord = value; }
        }

        public string StrUserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public string StrDataBaseName
        {
            get { return strDataBaseName; }
            set { strDataBaseName = value; }
        }

        public string StrSeverName
        {
            get { return strSeverName; }
            set { strSeverName = value; }
        }

        public string StrConnect
        {
            get { return strConnect; }
            set { strConnect = value; }
        }
        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public DbContext()
        {
            StrSeverName = @"LAPTOP-FRMKN0GD\TIEN";
            StrDataBaseName = "QL_KHAMBENH";
            StrUserName = "sa";
            StrPassWord = "123";
            //StrUserName = UserName;
            //StrPassWord = PassWord;
            StrConnect = @"Data Source=" + StrSeverName + ";Initial Catalog=" + StrDataBaseName + ";user ID=" + StrUserName + "; password = " + StrPassWord;
            Connect = new SqlConnection(StrConnect);
            DSet = new DataSet(StrDataBaseName);
            connect.Open();
        }

        public void OpenConnect()
        {
            strUserName = "sa";
            strPassWord = "123";
            //strUserName = UserName;
            //strPassWord = PassWord;
            strConnect = @"Data Source= LAPTOP-FRMKN0GD\TIEN " + ";Initial Catalog= QL_KHAMBENH " + ";user ID=" + strUserName + "; password =" + strPassWord;
            Connect = new SqlConnection(StrConnect);
            if (Connect.State == ConnectionState.Closed)
                Connect.Open();
        }
        //public DbContext()
        //{
        //    StrSeverName = @"LAPTOP-FRMKN0GD\TIEN";
        //    StrDataBaseName = "QL_KHAMBENH";
        //}

        public void OpenConnectAsSA()
        {
            StrUserName = "sa";
            StrPassWord = "123";
            StrConnect = @"Data Source=" + StrSeverName + ";Initial Catalog=" + StrDataBaseName + ";user ID=" + StrUserName + "; password = " + StrPassWord;
            Connect = new SqlConnection(StrConnect);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
            }
        }

        //public void OpenConnect(string UserName, string PassWord)
        //{
        //    StrUserName = UserName;
        //    StrPassWord = PassWord;
        //    StrConnect = @"Data Source=" + StrSeverName + ";Initial Catalog=" + StrDataBaseName + ";user ID=" + StrUserName + "; password = " + StrPassWord;
        //    Connect = new SqlConnection(StrConnect);
        //    if (Connect.State == ConnectionState.Closed)
        //    {
        //        Connect.Open();
        //    }
        //}

        public void CloseConnect()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
        }
        public void InsertToDatabase(string query, params object[] parameters)
        {
            //try
            //{
            //    OpenConnect();
            //    using (SqlCommand cmd = new SqlCommand(query, Connect))
            //    {
            //        for (int i = 0; i < parameters.Length; i++)
            //        {
            //            cmd.Parameters.AddWithValue($"@param{i}", parameters[i]);
            //        }
            //        cmd.ExecuteNonQuery();
            //    }
            //    CloseConnect();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Lỗi thêm: " + ex.Message);
            //}
        }
        public void UpdateToDatabase(string query)
        {
            //OpenConnect();
            //SqlCommand cmd = new SqlCommand(query, Connect);
            //cmd.ExecuteNonQuery();
            //CloseConnect();
        }
        public int GetCount(string query, SqlParameter[] parameters)
        {
            //OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddRange(parameters);
            int count = (int)cmd.ExecuteScalar();
            CloseConnect();
            return count;
        }

        //public SqlDataReader GetData(string query)
        //{
        //    //OpenConnect();
        //    //SqlCommand cmd = new SqlCommand(query, Connect);
        //    //SqlDataReader rd = cmd.ExecuteReader();
        //    //return rd;
        //}
        public SqlDataAdapter getDataAdapter(string query, string tableName)
        {
            //OpenConnectAsSA();
            OpenConnect();
            SqlDataAdapter ada = new SqlDataAdapter(query, Connect);
            ada.Fill(DSet, tableName);
            CloseConnect();
            return ada;
        }
        public int check_Quyen(string tk)
        {
            if (GetChucVu(tk) == "Admin")
            {
                return 1;
            }
            else if (GetChucVu(tk) == "Doctor")
            {
                return 2;
            }
            return 3;
        }
        public bool check_TaiKhoan(NhanVien_DTO nv)
        {
            try
            {
                //OpenConnectAsSA();
                OpenConnect();
                string query = "SELECT COUNT(*) FROM NhanVien WHERE SDT = @SDT AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                // Log the exception
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }
        public string GetChucVu(string tk)
        {
            //OpenConnect();
            string query = "SELECT CHUCDANH FROM NhanVien WHERE SDT = @tk";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.Add(new SqlParameter("@tk", tk));
            string chucvu = (string)cmd.ExecuteScalar();
            CloseConnect();
            return chucvu;
        }


    }
}