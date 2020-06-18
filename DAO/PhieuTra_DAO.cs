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
    public class PhieuTra_DAO : DataProvier
    {
        public DataTable Phieutra()
        {
            string sqlString = @"select * from PHIEUTRA";
            return GetData(sqlString);
        }
        public bool Them(PhieuTra_DTO pm)
        {
            if (GetData("select* from PHIEUTRA where MaPhieu = '" + pm.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = "insert into PHIEUTRA (MaPhieu, MaDocGia, MaSach, NgayTra ) values('" + pm.MaPhieu + "','" + pm.MaDocGia + "','" + pm.MaSach + "','" + pm.NgayTra + "')";
            Excute(sql);

            return true;

        }

        public void Xoa(string mp)
        {
            Excute("delete from PHIEUTRA where MaPhieu = '" + mp + "'");


        }
        public void Sua(PhieuTra_DTO pm)
        {
            string sql = string.Format("update PHIEUTRA set MaDocGia = '{0}', MaSach = '{1}',  NgayTra = '{2}' where MaPhieu = '{3}' ",
                pm.MaDocGia, pm.MaSach, pm.NgayTra, pm.MaPhieu);
            Excute(sql);
        }
        public DataTable Tim(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from PHIEUTRA where {0} like N'%{1}%'", _loaitk, _timkiem);
            //Excute(sqlString);
            return GetData(sqlString);
        }
    }
}