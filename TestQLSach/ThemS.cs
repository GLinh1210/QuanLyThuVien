using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQLSach
{
    [TestClass]
    public class ThemS
    {
        private QuanLyThuVien.DAO.Sach_DAO sa;
        private QuanLyThuVien.DTO.Sach_DTO s;
        
        [TestInitialize]
        public void CNThem()
        {
            this.sa = new QuanLyThuVien.DAO.Sach_DAO();
        }

        [TestMethod]
        public void TrungMS()
        {
            this.s = new QuanLyThuVien.DTO.Sach_DTO();
            s.MaSach = "1000";
            s.TenSach = "Bách Khoa Toàn Thư";
            Assert.AreEqual(sa.Insert(s), false);
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
