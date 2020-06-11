using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Dao;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.Bus
{
    public class DocGia_Bus
    {
        DocGia_Dao DocGiaDao = new DocGia_Dao();
        public DataTable GetList()
        {
            return DocGiaDao.loadDocGia();
        }
        public void Xoa(string mS)
        {
            DocGiaDao.Delete(mS);
        }
        public bool Sua(DocGia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            DocGiaDao.Update(dg);
            return true;
        }
        public int Them(DocGia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return 0;
            if (!DocGiaDao.Insert(dg))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return DocGiaDao.Search(_timkiem);
        }

        internal object TimKiem(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        internal bool Tim(DocGia_DTO dgDTO1, DocGia_DTO dgDTO2)
        {
            throw new NotImplementedException();
        }
    }
}
