using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien.DAO
{
    class PhieuTra_DAO : DataProvier
    {
        public DataTable Phieutra()
        {
            string sqlString = @"select * from PHIEUTRA";
            return GetData(sqlString);
        }
        public bool Them(PhieuTra_DTO t)
        {
          
            if (GetData("select* from PHIEUTRA where MaPhieu = '" + t.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = "insert into PHIEUTRA (MaPhieu, MaDocGia, MaSach, NgayTra)values('" + t.MaPhieu + "','" + t.MaDocGia + "','" + t.MaSach + "','" + t.NgayTra + "',)";

            Excute(sql);
            return true;
        }
        public void Xoa(string mt)
        {
            Excute("delete from PHIEUTRA where MaPhieu = '" + mt + "'");
        }
        public void Sua(PhieuTra_DTO pm)
        {
            string sql = string.Format("update PHIEUTRA set MaDocGia = '{0}', MaSach = '{1}', NgayTra = '{2}' where MaPhieu = '{3}' ",
                   pm.MaDocGia, pm.MaSach,  pm.NgayTra, pm.MaPhieu);
            Excute(sql);
        }
    }
}
