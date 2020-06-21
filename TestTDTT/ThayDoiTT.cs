using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTDTT
{
    [TestClass]
    public class ThayDoiTT
    {
        private QuanLyThuVien.DAO.DocGia_DAO DG;
        private QuanLyThuVien.DTO.DocGia_DTO dg;
        private QuanLyThuVien.DAO.DoiMK_DAO mk;
        private QuanLyThuVien.DTO.Account_DTO acc;

        [TestInitialize]
        public void CNDoiMK()
        {

            this.mk = new QuanLyThuVien.DAO.DoiMK_DAO();
        }
        [TestInitialize]
        public void CNTDTT()
        {
            
            this.DG = new QuanLyThuVien.DAO.DocGia_DAO();
        }

        [TestMethod]
        public void ThayDoiTTDG()
        {
            string tdn = "TestThayDoi";
            this.dg = new QuanLyThuVien.DTO.DocGia_DTO();
            dg.HoTen = "Thay Đổi";
            dg.GioiTinh = "Nữ";
            dg.NamSinh = DateTime.Today;
            dg.DiaChi = "Nguyễn Kiệm";
            Assert.AreEqual(DG.SuaDG(dg,tdn), true);

        }
    }
}
