using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDangNhapvaDangKy
{
    [TestClass]
    public class DangNhap
    {
        private QuanLyThuVien.DAO.DangNhap_DAO dn;

        [TestInitialize]
        public void CNDangNhap()
        {
            this.dn = new QuanLyThuVien.DAO.DangNhap_DAO();
        }

        [TestMethod]
        public void DNAdmin()
        {
            Assert.AreEqual(dn.login("admin", ""), true);
        }
        [TestMethod]
        public void Nhapkdu()
        {
            Assert.AreEqual(dn.login("", ""), false);
        }
        [TestMethod]
        public void DNUser()
        {
            Assert.AreEqual(dn.login("Linhle123", "L123"), true);
        }
        [TestMethod]
        public void ThieuTDN()
        {
            Assert.AreEqual(dn.login("", "1234L"), false);
        }
        [TestMethod]
        public void ThieuMK()
        {
            Assert.AreEqual(dn.login("mlinh123", ""), false);
        }
        [TestMethod]
        public void DNSaiMK()
        {
            Assert.AreEqual(dn.login("Linhle123", "123"), false);
        }
        [TestMethod]
        public void DNSaiTDN()
        {
            Assert.AreEqual(dn.login("linhle1", "L123"), false);
        }
        
    }
}
