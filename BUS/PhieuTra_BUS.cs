using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.BUS
{
    class PhieuTra_BUS
    {
        PhieuTra_DAO traDAO = new PhieuTra_DAO();
        public DataTable GetList()
        {
            return traDAO.Phieutra();
        }
        public void XoaB(string mt)
        {
            traDAO.Xoa(mt);
        }
        public bool SuaB(PhieuTra_DTO t)
        {
            if (string.IsNullOrEmpty(t.MaPhieu))
                return false;
            traDAO.Sua(t);
            return true;
        }
        public int ThemB(PhieuTra_DTO t)
        {
            if (string.IsNullOrEmpty(t.MaPhieu))
                return 0;
            if (!traDAO.Them(t))
                return -1;
            return 1;
        }
    }
}
