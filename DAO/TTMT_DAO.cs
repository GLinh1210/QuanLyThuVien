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
    class TTMT_DAO : DataProvier
    {
       
        public DataTable PMu(string tk)
        {
            string sqlString = string.Format("Select * from PHIEUMUON, ACCOUNT where ACCOUNT.MaDocGia = PHIEUMUON.MaDocGia and ACCOUNT.TenDangNhap = '" + tk + "'");
            //Excute(sqlString);
            return GetData(sqlString);
        }
        
        public DataTable PTr(string tk)
        {
            string sqlString = string.Format("Select * from PHIEUTRA, ACCOUNT where ACCOUNT.MaDocGia = PHIEUTRA.MaDocGia and ACCOUNT.TenDangNhap = '" + tk + "'");
            //Excute(sqlString);
            return GetData(sqlString);
        }

    }
}
