using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
    class DoiMK_DAO : DataProvier
    {
        public void DoiMK(Account_DTO mk)
        {
            string sql = string.Format("update ACCOUNT set MatKhau = N'{0}'  where TenDangNhap = '{1}'",
                mk.MatKhau , mk.TenDangNhap );
            Excute(sql);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            string sql = string.Format("select* from ACCOUNT where MatKhau = '{0}' and TenDangNhap = '{1}'", _mkc, _tdn);
            if (GetData(sql).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
