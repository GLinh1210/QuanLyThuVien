﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQLSach
{
    [TestClass]
    public class SuaS
    {
        private QuanLyThuVien.BUS.Sach_BUS sa;
        private QuanLyThuVien.DTO.Sach_DTO s;
        
        [TestInitialize]
        public void CNSua()
        {
            this.sa = new QuanLyThuVien.BUS.Sach_BUS();
        }

        [TestMethod]
        public void MPTrong()
        {
            this.s = new QuanLyThuVien.DTO.Sach_DTO();

            s.MaSach = "";
            Assert.AreEqual(sa.Sua(s), false);

        }
    }
}
