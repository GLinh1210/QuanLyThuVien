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
using QuanLyThuVien.DTO;


namespace QuanLyThuVien
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        DangNhap_BUS dn = new DangNhap_BUS();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            fLogin lg = new fLogin();
            lg.Close();
            DialogResult d = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            fSach s = new fSach();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }


    }
}
