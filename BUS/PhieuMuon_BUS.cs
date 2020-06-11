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
        PhieuMuon_DAO PMDAO = new PhieuMuon_DAO();
        public DataTable GetList()
        {
            return PMDAO.loadSach();
        }
        public void Xoa(string mt)
        {
            PMDAO.Delete(mt);
        }
        public bool Sua(PhieuMuon_DTO m)
        {
            if (string.IsNullOrEmpty(m.MaPhieu))
                return false;
            PMDAO.Update(m);
            return true;
        }
        public int Them(PhieuMuon_DTO m)
        {
            if (string.IsNullOrEmpty(m.MaPhieu))
                return 0;
            if (!PMDAO.Insert(m))
                return -1;
            return 1;
        }
    }
}
