using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class DocGia_DAO : DataProvier
    {
        public bool SuaDG(DocGia_DTO dg, string tdn)
        {
            if (GetData("select* from DOCGIA where TenDangNhap = '" + tdn + "'").Rows.Count <= 0)
                return false;
            string sql = string.Format("update DOCGIA set HoTen = N'{0}', GioiTinh = N'{1}', NamSinh = '{2}', DiaChi = N'{3}'  where TenDangNhap = N'{4}'",
                dg.HoTen, dg.GioiTinh, dg.NamSinh, dg.DiaChi, tdn);
            Excute(sql);
            return true;
        }
        
    }
}
