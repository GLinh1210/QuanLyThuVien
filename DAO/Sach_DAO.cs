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
    class Sach_DAO : DataProvier
    {
        public DataTable loadSach()
        {
            string sqlString = @"select * from SACH";
            return GetData(sqlString);
        }
        public bool Insert(Sach_DTO s)
        {
            if (GetData("select* from SACH where MaSach = '" + s.MaSach + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into SACH values('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}', N'{7}')",
                s.MaSach, s.TenSach, s.TacGia, s.TheLoai, s.NhaXuatBan, s.GiaSach, s.SoLuong, s.TinhTrang);

            Excute(sql);
            return true;
        }
        public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach_DTO s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' , TinhTrang = N'{6}' where MaSach = '{7}'",
                s.TenSach, s.TacGia, s.TheLoai, s.NhaXuatBan, s.GiaSach, s.SoLuong, s.TinhTrang, s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            //Excute(sqlString);
            return GetData(sqlString);
        }
    }
}
