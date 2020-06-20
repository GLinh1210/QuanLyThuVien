using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQLDG
{
    [TestClass]
    public class ThemDG
    {
         private QuanLyThuVien.DAO.QLDG_DAO dg;
        private QuanLyThuVien.DTO.DocGia_DTO DG;
        private QuanLyThuVien.DTO.Account_DTO acc;
        [TestInitialize]
        public void CNThem()
        {
            this.dg = new QuanLyThuVien.DAO.QLDG_DAO();
        }

        [TestMethod]
        public void TrungMDG()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.DG = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "100";
            acc.TenDangNhap = "TestDG";
            DG.GioiTinh = "Nữ";


            Assert.AreEqual(dg.ThemDG(DG, acc), false);
        }
        [TestMethod]
        public void TrungTenDN()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.DG = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "114";
            acc.TenDangNhap = "KimNgan";
            DG.GioiTinh = "Nữ";


            Assert.AreEqual(dg.ThemDG(DG, acc), false);
        }
        [TestMethod]
        public void ThemDGDung()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.DG = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "114";
            acc.TenDangNhap = "TestDG";
            DG.HoTen = "Test Độc Giả";
            DG.NamSinh = DateTime.Today;
            DG.GioiTinh = "Nữ";


            Assert.AreEqual(dg.ThemDG(DG, acc), true);
        }
    }
}
