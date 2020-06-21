using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTDTT
{
    [TestClass]
    public class TDTT
    {
        private QuanLyThuVien.DAO.DocGia_DAO DG;
        private QuanLyThuVien.DTO.DocGia_DTO dg;



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
            dg.DiaChi = "113 Nguyễn Kiệm";
            Assert.AreEqual(DG.SuaDG(dg, tdn), true);

        }
    }
}
