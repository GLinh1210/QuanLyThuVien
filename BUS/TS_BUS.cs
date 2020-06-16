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
    class TS_BUS
    {
        TS_DAO ts = new TS_DAO();
        public DataTable GetList()
        {
            return ts.TimSach();
        }
        public DataTable TS(string _timkiem, string _loaitk)
        {
            return ts.Tims(_timkiem, _loaitk);
        }
    }
}
