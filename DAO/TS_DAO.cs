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
    public class TS_DAO : DataProvier
    {
        public DataTable TimSach()
        {
            string sqlString = @"select * from SACH";
            return GetData(sqlString);
        }
        public DataTable Tims(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            //Excute(sqlString);
            return GetData(sqlString);
        }
    }
}
