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
using System.Data.SqlClient;


namespace QuanLyThuVien
{
    public partial class TrangChu : Form
    {
        string tdn;
        
        public TrangChu(string dn)
        {
            InitializeComponent();
            this.tdn = dn;
            
            
        }
        TrangChu_BUS tc = new TrangChu_BUS();
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
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            //btnDG.Visible = false;
            if (tdn == "admin")
            {
                btnDoiMK.Visible = false;
                btnThaydoi.Visible = false;
                btnTSach.Visible = false;
                btnMT.Visible = false;
            }
            else
            {
                btnSach.Visible = false;
                btnDG.Visible = false;
                btnMuon.Visible = false;
                btnTra.Visible = false;
            }
            




        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMK mk = new DoiMK(tdn);
            this.Hide();
            mk.ShowDialog();
            this.Show();

        }

        private void btnTSach_Click(object sender, EventArgs e)
        {
            TCS tcs = new TCS();
            this.Hide();
            tcs.ShowDialog();
            this.Show();
        }

        private void btnMT_Click(object sender, EventArgs e)
        {
            TTMT mt = new TTMT(tdn);
            this.Hide();
            mt.ShowDialog();
            this.Show();

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            PhieuMuon tcs = new PhieuMuon();
            this.Hide();
            tcs.ShowDialog();
            this.Show();

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            PhieuTra tcs = new PhieuTra();
            this.Hide();
            tcs.ShowDialog();
            this.Show();

        }

  


        
    }
}
