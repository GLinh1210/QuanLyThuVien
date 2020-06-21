using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDangNhapvaDangKy
{
    [TestClass]
    public class DangKy
    {
        private QuanLyThuVien.DAO.DangKy_DAO dk;
        private QuanLyThuVien.DTO.Account_DTO acc;
        private QuanLyThuVien.DTO.DocGia_DTO dg;
        [TestInitialize]
        public void CNDangKy()
        {
            this.dk = new QuanLyThuVien.DAO.DangKy_DAO();
        }

        [TestMethod]
        public void TrungMDG()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "100";
            acc.TenDangNhap = "KimNgan";
            acc.MatKhau = "KN123";
            acc.Quyen = 0;
            dg.MaDocGia = acc.MaDocGia;
            dg.TenDangNhap = acc.TenDangNhap;
            dg.HoTen = "Nguyễn Kim Ngân";
            dg.DiaChi = "23 Nguyễn Kiệm";
            dg.GioiTinh = "Nữ";

            Assert.AreEqual(dk.Insert(acc, dg), false);

        }

        [TestMethod]
        public void DK()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "110";
            acc.TenDangNhap = "KimNgan12";
            acc.MatKhau = "KN123";
            acc.Quyen = 0;
            dg.NamSinh = DateTime.Today;
            dg.HoTen = "Lê Kim Ngân";
            dg.DiaChi = "23 Nguyễn Kiệm";
            dg.GioiTinh = "Nữ";

            Assert.AreEqual(dk.Insert(acc, dg), true);

        }
       
        [TestMethod]
        public void TrungTenDN()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "112";
            acc.TenDangNhap = "KimNgan";
            acc.MatKhau = "123L";
            acc.Quyen = 0;
            dg.NamSinh = DateTime.Now;
            dg.HoTen = "Lê Kim Ngân";
            dg.DiaChi = "23 Nguyễn Kiệm";
            dg.GioiTinh = "Nữ";

            Assert.AreEqual(dk.Insert(acc, dg), false);

        }
        [TestMethod]
        public void ThieuTT()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "113";
            acc.TenDangNhap = "Test2";
            acc.MatKhau = "123L";
            dg.DiaChi = "fvgh";
            Assert.AreEqual(dk.Insert(acc, dg), false);

        }
        [TestMethod]
        public void TestMK()
        {
            this.acc = new QuanLyThuVien.DTO.Account_DTO();
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            acc.MaDocGia = "116";
            acc.TenDangNhap = "TestMK";
            acc.MatKhau = "123";
            dg.DiaChi = "fvgh";
            Assert.AreEqual(dk.Insert(acc, dg), false);

        }

    }
}
