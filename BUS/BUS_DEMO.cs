using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BUS
{
    public class BUS_DEMO
    {
        DAO_DEMO dgDao = new DAO_DEMO ();
        public DataTable GetList()
        {
            return dgDao.DocGia();
        }
        public void XoaDG1(string mS)
        {
            dgDao.XoaDG(mS);
        }
        public bool SuaDG1(DangKy_DTO dg, DangNhap_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.MaDocGia))
                return false;
            dgDao.SuaDG(dg, acc);
            return true;
        }
        public int ThemDG1(DangKy_DTO dg, DangNhap_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.MaDocGia))
                return 0;
            if (!dgDao.ThemDG(dg, acc))
                return -1;
            return 1;
        }
        public DataTable TimDG1(string _timkiem, string _loaitk)
        {
            return dgDao.TimDG(_timkiem, _loaitk);
        }

        internal bool btSua(DTO_DEMO dg)
        {
            throw new NotImplementedException();
        }
    }
}
