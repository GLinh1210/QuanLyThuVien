using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DAO;

namespace QuanLyThuVien
{
    public partial class fLogin : Form
    {
        DangNhap_BUS dnBUS = new DangNhap_BUS();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (dnBUS.DangNhap(txtDN.Text, txtMK.Text) == true)
            {
                TrangChu tc = new TrangChu();
                this.Hide();
                tc.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            fDangky dk = new fDangky();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
    }
}
