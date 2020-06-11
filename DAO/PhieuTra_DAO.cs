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
    class PhieuTra_DAO:DataProvier
    {
        public DataTable loadSach()
        {
            string sqlString = @"select * from PHIEUTRA";
            return GetData(sqlString);
        }
        public bool Insert(PhieuTra_DTO t)
        {
            if (GetData("select* from PHIEUTRA where MaPhieu = '" + t.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PHIEUTRA values('{0}',N'{1}',N'{2}',N'{3}')",
                t.MaPhieu, t.MaDocGia, t.MaSach, t.NgayTra);

            Excute(sql);
            return true;
        }
        public void Delete(string mt)
        {
            Excute("delete from PHIEUTRA where MaPhieu = '" + mt + "'");
        }
        public void Update(PhieuTra_DTO t)
        {
            string sql = string.Format("update PHIEUMUON set MaDocGia = N'{0}', MaSach = N'{1}', NgayTra = N'{2}'",
                t.MaDocGia,t.MaSach, t.NgayTra);
            Excute(sql);
        }
    }
}
