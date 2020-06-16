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
    class PhieuTra_BUS
    {
        PhieuTra_DAO tDao = new PhieuTra_DAO();
        public DataTable GetList()
        {
            return tDao.Phieutra();
        }
        public void XoaT(string mS)
        {
            tDao.Xoa(mS);
        }
        public bool SuaT(PhieuTra_DTO pm)
        {
            if (string.IsNullOrEmpty(pm.MaPhieu))
                return false;
            tDao.Sua(pm);
            return true;
        }
        public int ThemT(PhieuTra_DTO pm)
        {
            if (string.IsNullOrEmpty(pm.MaPhieu))
                return 0;
            if (!tDao.Them(pm))
                return -1;
            return 1;
        }
        public DataTable TimKiemT(string _timkiem, string _loaitk)
        {
            return tDao.Tim(_timkiem, _loaitk);
        }
    }
}