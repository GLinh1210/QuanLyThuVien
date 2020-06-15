using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
    public class DATA
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-QCN1M3M\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
   
        public DataTable GetData(string sql)
        {
            
            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, _conn);
            adapter.Fill(rs);
            return rs;  
        }
        public void Excute(string sql)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand(sql, _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql,_conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
