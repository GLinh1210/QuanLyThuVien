using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DTO;
using QuanLyThuVien.BUS;

namespace QuanLyThuVien
{
    
    public partial class DoiMK : Form
    {
        string tdn;
        public DoiMK(string dn)
        {
            InitializeComponent();
            this.tdn = dn;
        }
       
        DoiMK_BUS mk = new DoiMK_BUS();
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            Account_DTO acc = new Account_DTO();
            
            if (txtMKM.Text != txtMKM2.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp. Vui lòng kiểm tra lại");
                return;
            }
     
            if (mk.CheckExist( tdn , txtMKC.Text) == true)
            {
                acc.TenDangNhap = tdn;
                acc.MatKhau = txtMKM.Text;
                mk.DoiMatKhau(acc);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công");
            }
            
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void DoiMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }
        

    }
}
