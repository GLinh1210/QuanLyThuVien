using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuMuon
{
    [TestClass]
    public class SuaPM
    {
        private QuanLyThuVien.BUS.PhieuMuon_BUS pm;
        private QuanLyThuVien.DTO.PhieuMuon_DTO m;
        [TestInitialize]
        public void CNSua()
        {
            this.pm = new QuanLyThuVien.BUS.PhieuMuon_BUS();
        }

        [TestMethod]
        public void MPTrong()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "";
            m.MaDocGia = "739";
            m.MaSach = "03942";
            m.NgayMuon = DateTime.Today;
            m.NgayPhaiTra = DateTime.Today;

            Assert.AreEqual(pm.SuaM(m), false);

        }
        [TestMethod]
        public void SuaDung()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "5";
            m.MaDocGia = "739";
            m.MaSach = "03942";
            m.NgayMuon = DateTime.Today;
            m.NgayPhaiTra = DateTime.Today;

            Assert.AreEqual(pm.SuaM(m), true);

        }
    }
}
