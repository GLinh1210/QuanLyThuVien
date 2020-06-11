using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyThuVien.DAO
{
    public class DataProvier
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8MH1NJR\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");



        public DataTable GetData(string sql)
        {

            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(rs);
            return rs;

        }
        public void Excute(string sql)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();


        }
        public SqlDataReader ExecuteReader(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

    }
}
