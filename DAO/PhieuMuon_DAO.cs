﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien.DAO
{
    public class PhieuMuon_DAO : DataProvier
    {
        public DataTable Phieumuon()
        {
            string sqlString = @"select * from PHIEUMUON";
            return GetData(sqlString);
        }
        public bool Them(PhieuMuon_DTO pm)
        {
            Sach_DTO s = new Sach_DTO();
            DocGia_DTO dg = new DocGia_DTO();
            if (GetData("select* from PHIEUMUON where MaPhieu = '" + pm.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = "insert into PHIEUMUON (MaPhieu, MaDocGia, MaSach, NgayMuon, NgayPhaiTra ) values('" + pm.MaPhieu + "','" + pm.MaDocGia + "','" + pm.MaSach + "','" + pm.NgayMuon + "','" + pm.NgayPhaiTra + "')";
            Excute(sql);

            return true;

        }

        public bool Xoa(string mp)
        {
            if (GetData("select* from PHIEUMUON where MaPhieu = '" + mp + "'").Rows.Count <= 0)
                return false;
            Excute("delete from PHIEUMUON where MaPhieu = '" + mp + "'");
            return true;


        }
        public void Sua(PhieuMuon_DTO pm)
        {
            string sql = string.Format("update PHIEUMUON set MaDocGia = '{0}', MaSach = '{1}', NgayMuon = '{2}', NgayPhaiTra = '{3}' where MaPhieu = '{4}' ",
                pm.MaDocGia, pm.MaSach, pm.NgayMuon, pm.NgayPhaiTra, pm.MaPhieu);
            Excute(sql);
        }
        public DataTable Tim(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from PHIEUMUON where {0} like N'%{1}%'", _loaitk, _timkiem);
            //Excute(sqlString);
            return GetData(sqlString);
        }
    }
}
