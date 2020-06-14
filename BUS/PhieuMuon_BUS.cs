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
    class PhieuMuon_BUS
    {
        PhieuMuon_DAO muonDAO = new PhieuMuon_DAO();
        public DataTable GetList()
        {
            return muonDAO.Phieumuon();
        }
        public void XoaB(string mt)
        {
            muonDAO.Xoa(mt);
        }
        public bool SuaB(PhieuMuon_DTO m)
        {
            if (string.IsNullOrEmpty(m.MaPhieu))
                return false;
            muonDAO.Sua(m);
            return true;
        }
        public int ThemB(PhieuMuon_DTO m)
        {
            if (string.IsNullOrEmpty(m.MaPhieu))
                return 0;
            if (!muonDAO.Them(m))
                return -1;
            return 1;
        }
    }
}
