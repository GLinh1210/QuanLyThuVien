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
    class PhieuMuon_DAO: DataProvier
    {
        public DataTable loadSach()
        {
            string sqlString = @"select * from PHIEUMUON";
            return GetData(sqlString);
        }
        public bool Insert(PhieuMuon_DTO m)
        {
            if (GetData("select * from PHIEUMUON where MaPhieu = '" + m.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = "insert into PHIEUMUON (MaPhieu, MaDocGia, MaSach, NgayMuon, NgayPhaiTra ) values('"+ m.MaPhieu + "','" + m.MaDocGia + "','" + m.MaSach + "','" + m.NgayMuon + "','" + m.NgayPhaiTra + "')"; 
            Excute(sql);
            return true;
        }
        public void Delete(string mt)
        {
            Excute("delete from PHIEUMUON where MaPhieu = '" + mt + "'");
        }
        public void Update(PhieuMuon_DTO m)
        {
            string sql = string.Format("update PHIEUMUON set MaDocGia = N'{0}', MaSach = N'{1}', NgayMuon = N'{2}', NgayPhaiTra = N'{3}'",
                m.MaDocGia, m.MaSach, m.NgayMuon, m.NgayPhaiTra);
            Excute(sql);
        }

    }
}
