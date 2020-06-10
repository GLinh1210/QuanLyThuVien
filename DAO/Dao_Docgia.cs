using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class Dao_Docgia : Data
    {
        public DataTable loadDocGia()
        {
            string sqlString = @"select * from DOCGIA";
            return GetData(sqlString);
        }
        public bool Insert(Dao_Docgia dg)
        {
            if (GetData("select* from DOCGIA where MaDocGia = '" + dg.MaDocGia + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into DOCGIA values('{0}','{1}','{2}','{3}','{4}')",
                dg.MaDocGia, dg.HoTen, dg.GioiTinh,dg.NamSinh, dg.DiaChi);

            Excute(sql);
            return true;
        }
        public void Delete(string mDG)
        {
            Excute("delete from DOCGIA where MaDocGia = '" + mDG + "'");
        }

        public void Update(DTO_Docgia dg)
        {
            string sql = string.Format("update DOCGIA set HoTen = N'{0}', GioiTinh = N'{1}', NamSinh = '{2}', DiaChi = N'{3}' where MaDocGia = '{4}'",
                dg.HoTen, dg.GioiTinh, dg.NamSinh, dg.DiaChi, dg.MaDocGia);
            Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from DOCGIA where MaDocGia like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
        
    }
    }
}
