using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQLSach
{
    [TestClass]
    public class XoaS
    {
        private QuanLyThuVien.DAO.Sach_DAO sa;
        private QuanLyThuVien.DTO.Sach_DTO s;
        [TestInitialize]
        public void CNXoa()
        {
            this.sa = new QuanLyThuVien.DAO.Sach_DAO();
        }

        [TestMethod]
        public void XoaTrongMS()
        {
            this.s = new QuanLyThuVien.DTO.Sach_DTO();
            s.MaSach = "";

            Assert.AreEqual(sa.Delete(s.MaSach), false);
        }
        [TestMethod]
        public void XoaSaiMS()
        {
            this.s = new QuanLyThuVien.DTO.Sach_DTO();
            s.MaSach = "1009";

            Assert.AreEqual(sa.Delete(s.MaSach), false);
        }
        [TestMethod]
        public void XoaSach()
        {
            this.s = new QuanLyThuVien.DTO.Sach_DTO();
            s.MaSach = "1007";

            Assert.AreEqual(sa.Delete(s.MaSach), true);
        }
    }
}
