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
        PhieuTra_DAO PTDAO = new PhieuTra_DAO();
        public DataTable GetList()
        {
            return PTDAO.loadSach();
        }
        public void Xoa(string mt)
        {
            PTDAO.Delete(mt);
        }
        public bool Sua(PhieuTra_DTO t)
        {
            if (string.IsNullOrEmpty(t.MaPhieu))
                return false;
            PTDAO.Update(t);
            return true;
        }
        public int Them(PhieuTra_DTO t)
        {
            if (string.IsNullOrEmpty(t.MaPhieu))
                return 0;
            if (!PTDAO.Insert(t))
                return -1;
            return 1;
        }
    }
}
