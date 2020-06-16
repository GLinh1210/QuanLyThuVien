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
    class TTMT_BUS
    {
        TTMT_DAO mt = new TTMT_DAO();

        public DataTable PM(string tk)
        {
            return mt.PMu(tk);
        }
        public DataTable PT(string tk)
        {
            return mt.PTr(tk);
        }
    }
}
