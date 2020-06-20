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
    public class PhieuTra_BUS
    {
        PhieuTra_DAO tDao = new PhieuTra_DAO();
        public DataTable GetList()
        {
            return tDao.Phieutra();
        }
        public int XoaT(string mS)
        {
            if (string.IsNullOrEmpty(mS))
                return 0;
            if (!tDao.Xoa(mS))
                return -1;
            return 1;
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