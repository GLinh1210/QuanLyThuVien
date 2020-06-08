using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien.DAO
{
    class DangNhap_DAO : DataProvier
    {
        public bool login(string _tk, string _mk)
        {
            if (GetData("select* from ACCOUNT where TenDangNhap = '" + _tk + "' and MatKhau = '" + _mk + "'").Rows.Count > 0)
                return true;
            return false;
        }

    }
}
