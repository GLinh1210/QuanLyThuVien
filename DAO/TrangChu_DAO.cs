using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
    class TrangChu_DAO : DataProvier
    {
        public DataTable HienThi()
        {
            string sqlString = @"select * from DOCGIA";
            return GetData(sqlString);
        }
        public DataTable HienThi(string Tendn)
        {
            string sql = "select * from DOCGIA where TenDangNhap = '" + Tendn + "'" ;
            return GetData(sql);
        }

    }
}
