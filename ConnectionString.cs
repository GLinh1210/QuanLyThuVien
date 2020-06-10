using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien
{
    class ConnectionString
    {
        public static string connectionString = @"Data Source=DESKTOP-8MH1NJR\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public static void openketnoi()
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        // phuong thuc get
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
