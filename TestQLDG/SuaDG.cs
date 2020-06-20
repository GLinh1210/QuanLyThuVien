using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQLDG
{
    [TestClass]
    public class SuaDG
    {
        private QuanLyThuVien.BUS.QLDG_BUS DG;
        private QuanLyThuVien.DTO.DocGia_DTO dg;
        private QuanLyThuVien.DTO.Account_DTO acc;
        [TestInitialize]
        public void CNSua()
        {
            this.DG = new QuanLyThuVien.BUS.QLDG_BUS();
        }

        [TestMethod]
        public void MPTrong()
        {
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            acc.MaDocGia = "";
            Assert.AreEqual(DG.SuaDG1(dg,acc), false);

        }
        [TestMethod]
        public void SuaDung()
        {
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            acc.MaDocGia = "105";
            acc.TenDangNhap = "VanAn";
            dg.GioiTinh = "Nữ";
            dg.DiaChi = "Đại học mở";


            Assert.AreEqual(DG.SuaDG1(dg, acc), true);

        }
    }
}
