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
    public class QLDG_BUS
    {
        QLDG_DAO dgDao = new QLDG_DAO();
        public DataTable GetList()
        {
            return dgDao.DocGia();
        }
        public bool XoaDG1(string mS)
        {
            if (string.IsNullOrEmpty(mS))
                return false;
            else if (dgDao.XoaDG(mS))
                return true;
            return false;
        }
        public bool SuaDG1(DocGia_DTO dg, Account_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.MaDocGia))
                return false;
            dgDao.SuaDG(dg, acc);
            return true;
 
        }
        public int ThemDG1(DocGia_DTO dg, Account_DTO acc)
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
    }
}

