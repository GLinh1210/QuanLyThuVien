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
        static string provider = @"Data Source=GIAOLINH1210\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection connect = new SqlConnection(provider);

        public DataTable GetData(string sql)
        {
            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(rs);
            return rs;
        }
        public void Excute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
            
    }
}
