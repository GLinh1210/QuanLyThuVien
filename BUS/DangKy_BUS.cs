using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;
using System.Data;

namespace QuanLyThuVien.BUS
{
    class DangKy_BUS
    {
        DangKy_DAO dkDao = new DangKy_DAO();

        public bool Them(DangNhap_DTO dn, DangKy_DTO dk)
        {
            return dkDao.Insert(dn, dk);
        }
    }
        
    
}
