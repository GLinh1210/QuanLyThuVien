using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
    class DangKy_DAO : DataProvier
    {

        
        public bool Insert(Account_DTO dn, DocGia_DTO dk )
        {
            
            if (GetData("select* from ACCOUNT where MaDocGia = '" + dn.MaDocGia + "'").Rows.Count > 0)
                return false;
            string sql = "INSERT INTO ACCOUNT(MaDocGia, TenDangNhap, MatKhau, Quyen)VALUES (";
            sql += "N'" + dn.MaDocGia + "',N'" + dn.TenDangNhap + "','" + dn.MatKhau + "','" + 0 + "')";
            Excute(sql);
            string Sql = "INSERT INTO DOCGIA (MaDocGia, TenDangNhap, HoTen, DiaChi,GioiTinh,NamSinh) VALUES (";
            Sql += "N'" + dn.MaDocGia + "',N'" + dn.TenDangNhap + "',N'" + dk.HoTen + "',N'" + dk.DiaChi + "',N'" + dk.GioiTinh + "','" + dk.NamSinh + "')";
            Excute(Sql);
            return true;
        }
        
    }
}
