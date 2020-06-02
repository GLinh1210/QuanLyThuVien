//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;

//namespace QuanLyThuVien
//{
//    class KiemTraDN
//    {
//        public int CheckLogin(string username, string password)
//        {
//            AccessData acc = new AccessData();
//            SqlDataReader reader = acc.ExecuteReader("SELECT TenDangNhap, MatKhau FROM ACCOUNT");
//            while (reader.Read())
//            {
//                if (reader[1].ToString() == username && reader[2].ToString() == password)
//                {
//                    // reader[0] tương ứng cho textbox Username
//                    // reader[1] tương ứng cho textbox Password
//                    return 1;
//                }
//            }
//            return 0;
//        }
//    }
//}
