using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.BUS
{
    class TrangChu_BUS
    {
        TrangChu_DAO tc = new TrangChu_DAO();
        public DataTable GetList()
        {
            return tc.HienThi();
        }
        public DataTable HT(string tenDN)
        {
            return tc.HienThi(tenDN);
        }
    }
}
