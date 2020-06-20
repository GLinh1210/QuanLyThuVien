using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhieuTra
{
    [TestClass]
    public class SuaPT
    {
        private QuanLyThuVien.BUS.PhieuTra_BUS pt;
        private QuanLyThuVien.DTO.PhieuTra_DTO t;
        [TestInitialize]
        public void CNSua()
        {
            this.pt = new QuanLyThuVien.BUS.PhieuTra_BUS();
        }

        [TestMethod]
        public void MPTrong()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "";
            t.MaDocGia = "100";
            t.MaSach = "1000";
            t.NgayTra = DateTime.Today;

            Assert.AreEqual(pt.SuaT(t), false);

        }
        [TestMethod]
        public void SuaDung()
        {
            this.t = new QuanLyThuVien.DTO.PhieuTra_DTO();
            t.MaPhieu = "2";
            t.MaDocGia = "101";
            t.MaSach = "1001";
            t.NgayTra = DateTime.Today;

            Assert.AreEqual(pt.SuaT(t), true);

        }
    }
}
