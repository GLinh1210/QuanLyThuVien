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
    public class QLDG_DAO : DataProvier
    {
        public DataTable DocGia()
        {
            string sqlString = @"select * from DOCGIA";
            return GetData(sqlString);
        }
        public bool ThemDG(DocGia_DTO dg, Account_DTO acc)
        {
            if (GetData("select* from ACCOUNT where MaDocGia = '" + acc.MaDocGia + "'").Rows.Count > 0)
                return false;
            else if (GetData("select* from ACCOUNT where TenDangNhap = '" + acc.TenDangNhap + "'").Rows.Count > 0)
                return false;
            string sql = "INSERT INTO ACCOUNT(MaDocGia, TenDangNhap, MatKhau, Quyen)VALUES (";
            sql += "N'" + acc.MaDocGia + "',N'" + acc.TenDangNhap + "','" + 123 + "','" + 0 + "')";
            Excute(sql);
            string Sql = "INSERT INTO DOCGIA (MaDocGia, TenDangNhap, HoTen, DiaChi,GioiTinh,NamSinh) VALUES (";
            Sql += "N'" + acc.MaDocGia + "',N'" + acc.TenDangNhap + "',N'" + dg.HoTen + "',N'" + dg.DiaChi + "',N'" + dg.GioiTinh + "','" + dg.NamSinh + "')";
            Excute(Sql);
            return true;
        }
        public void XoaDG(string mS)
        {
            Excute("delete from PHIEUTRA where MaDocGia = '" + mS + "'");
            Excute("delete from PHIEUMUON where MaDocGia = '" + mS + "'");
            Excute("delete from ACCOUNT where MaDocGia = '" + mS + "'");
            Excute("delete from DOCGIA where MaDocGia = '" + mS + "'");
        }

        public void SuaDG(DocGia_DTO dg, Account_DTO acc)
        {
            string Sql = string.Format("update ACCOUNT set  TenDangNhap = N'{0}' where MaDocGia = '{1}'",
                acc.TenDangNhap, acc.MaDocGia);
            Excute(Sql);
            string sql = string.Format("update DOCGIA set  TenDangNhap = N'{0}', HoTen = N'{1}', GioiTinh = N'{2}', NamSinh = '{3}', DiaChi = N'{4}'  where MaDocGia = '{5}'",
                acc.TenDangNhap, dg.HoTen, dg.GioiTinh, dg.NamSinh, dg.DiaChi, acc.MaDocGia);
            Excute(sql);
        }
        public DataTable TimDG(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DOCGIA where {0} like N'%{1}%'", _loaitk, _timkiem);
            //Excute(sqlString);
            return GetData(sqlString);
        }
    }
}
