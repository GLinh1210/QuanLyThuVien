using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuTra
{
    [TestClass]
    public class Xoa
    {
        private QuanLyThuVien.DAO.PhieuTra_DAO pt;
        private QuanLyThuVien.DTO.PhieuTra_DTO t;
        [TestInitialize]
        public void XoaPT()
        {
            this.pt = new QuanLyThuVien.DAO.PhieuTra_DAO();
        }

        [TestMethod]
        public void XoaDu()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "1";

            Assert.AreEqual(pt.Xoa(t.MaPhieu), true);
        }
        [TestMethod]
        public void XoaSaiMP()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "8";

            Assert.AreEqual(pt.Xoa(t.MaPhieu), false);

        }
        [TestMethod]
        public void XoaTrongMP()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "";

            Assert.AreEqual(pt.Xoa(t.MaPhieu), false);

        }
    }
}
