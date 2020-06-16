using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien.BUS
{
    class DangNhap_BUS
    {
        DangNhap_DAO dnDAO  = new DangNhap_DAO();
        public bool DangNhap(string _tk, string _mk)
        {
            if (dnDAO.login(_tk, _mk) == true)
                return true;
            return false;
        }
       
  
    }
}
