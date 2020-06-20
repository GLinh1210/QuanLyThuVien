using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuTra
{
    [TestClass]
    public class ThemPT
    {
        private QuanLyThuVien.DAO.PhieuTra_DAO pt;
        private QuanLyThuVien.DTO.PhieuTra_DTO t;
        [TestInitialize]
        public void CNThem()
        {
            this.pt = new QuanLyThuVien.DAO.PhieuTra_DAO();
        }

        [TestMethod]
        public void TrungMPT()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "1";
            t.MaDocGia = "739";
            t.MaSach = "03942";
            t.NgayTra = DateTime.Today;
           

            Assert.AreEqual(pt.Them(t), false);

        }
        [TestMethod]
        public void ThemDuPT()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "5";
            t.MaDocGia = "102";
            t.MaSach = "1004";
            t.NgayTra = DateTime.Today;

            Assert.AreEqual(pt.Them(t), true);

        }
    }
}
