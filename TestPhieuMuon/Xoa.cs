using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuMuon
{
    [TestClass]
    public class Xoa
    {
        private QuanLyThuVien.DAO.PhieuMuon_DAO pm;
        private QuanLyThuVien.DTO.PhieuMuon_DTO m;
        [TestInitialize]
        public void XoaPM()
        {
            this.pm = new QuanLyThuVien.DAO.PhieuMuon_DAO();
        }

        [TestMethod]
        public void XoaDu()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "1";

            Assert.AreEqual(pm.Xoa(m.MaPhieu), true);
        }
        [TestMethod]
        public void XoaSaiMP()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "8";

            Assert.AreEqual(pm.Xoa(m.MaPhieu), false);

        }
        [TestMethod]
        public void XoaTrongMP()
        {
            this.m = new QuanLyThuVien.DTO.PhieuMuon_DTO();
            m.MaPhieu = "";

            Assert.AreEqual(pm.Xoa(m.MaPhieu), false);

        }
    }
}
