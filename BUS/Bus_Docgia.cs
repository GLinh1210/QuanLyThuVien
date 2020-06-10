using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    class Bus_Docgia
    {
        Dao_Docgia dgDao = new Dao_Docgia();
        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(Dao_Docgia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public int Them(Dao_Docgia dg)
        {
            if (string.IsNullOrEmpty(MaDocGia))
                return 0;
            if (!dgDao.Insert(dg))
                return -1;
            return 1;
        }
        
    }
}
