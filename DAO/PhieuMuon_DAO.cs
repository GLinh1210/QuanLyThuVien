using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien.DAO
{
    class PhieuMuon_DAO : DataProvier
    {
        public DataTable Phieumuon()
        {
            string sqlString = @"select * from PHIEUMUON";
            return GetData(sqlString);
        }
        public bool Them(PhieuMuon_DTO pm)
        {
            if (GetData("select* from PHIEUMUON where MaPhieu = '" + pm.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = "insert into PHIEUMUON (MaPhieu, MaDocGia, MaSach, NgayMuon, NgayPhaiTra ) values('" + pm.MaPhieu + "','" + pm.MaDocGia + "','" + pm.MaSach + "','" + pm.NgayMuon + "','" + pm.NgayPhaiTra + "')";
            Excute(sql);

            return true;
        }
        public void Xoa(string mp)
        {
            Excute("delete from PHIEUMUON where MaPhieu = '" + mp + "'");


        }
        public void Sua(PhieuMuon_DTO pm)
        {
            string sql = string.Format("update PHIEUMUON set MaPhieu = '{0}', MaDocGia = '{1}', MaSach = '{2}', NgayMuon = '{3}', NgayPhaiTra = '{4}'",
                pm.MaPhieu, pm.MaDocGia, pm.MaSach, pm.NgayMuon, pm.NgayPhaiTra);
            Excute(sql);
        }

    }
}
