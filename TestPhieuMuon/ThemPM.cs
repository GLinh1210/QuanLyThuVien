using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuMuon
{
    [TestClass]
    public class ThemPM
    {
        private QuanLyThuVien.DAO.PhieuMuon_DAO pm;
        private QuanLyThuVien.DTO.PhieuMuon_DTO m;
        [TestInitialize]
        public void CNThem()
        {
            this.pm = new QuanLyThuVien.DAO.PhieuMuon_DAO();
        }

        [TestMethod]
        public void TrungMP()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "5";
            m.MaDocGia = "100";
            m.MaSach = "1000";
            m.NgayMuon = DateTime.Today;
            m.NgayPhaiTra = DateTime.Today;

            Assert.AreEqual(pm.Them(m), false);

        }
        [TestMethod]
        public void ThemDu()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "7";
            m.MaDocGia = "105";
            m.MaSach = "1000";
            m.NgayMuon = DateTime.Today;
            m.NgayPhaiTra = DateTime.Today;

            Assert.AreEqual(pm.Them(m), true);

        }
        
    }
}
