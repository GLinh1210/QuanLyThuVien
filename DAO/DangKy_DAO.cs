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
    public class DangKy_DAO : DataProvier
    {
        public bool KThoa(string mk)
        {
            bool kt = false;
            for (int i = 0; i < mk.Length; i++)
            {
                if (mk[i] >= 'A' && mk[i] <= 'Z')
                {
                    kt = true;
               
                }
            }
            return kt;
                    
        }
        
        public bool Insert(Account_DTO dn, DocGia_DTO dk )
        {
            bool them = true;

            if (GetData("select* from ACCOUNT where MaDocGia = '" + dn.MaDocGia + "'").Rows.Count > 0)
                them = false;
            else if (GetData("select* from ACCOUNT where TenDangNhap = '" + dn.TenDangNhap + "'").Rows.Count > 0)
                them = false;
            else
            {
                string sql = "INSERT INTO ACCOUNT(MaDocGia, TenDangNhap, MatKhau, Quyen)VALUES (";
                sql += "N'" + dn.MaDocGia + "',N'" + dn.TenDangNhap + "','" + dn.MatKhau + "','" + 0 + "')";
                Excute(sql);
                string Sql = "INSERT INTO DOCGIA (MaDocGia, TenDangNhap, HoTen, DiaChi,GioiTinh,NamSinh) VALUES (";
                Sql += "N'" + dn.MaDocGia + "',N'" + dn.TenDangNhap + "',N'" + dk.HoTen + "',N'" + dk.DiaChi + "',N'" + dk.GioiTinh + "','" + dk.NamSinh + "')";
                Excute(Sql);
                if (KThoa(dn.MatKhau) == false)
                    them = false;
            }
            return them;   
        }
        
    }
}
