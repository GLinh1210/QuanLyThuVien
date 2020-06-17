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
    public partial class ThayDoiTT : Form
    {
        string tdn;
        public ThayDoiTT(string dn)
        {
            InitializeComponent();
            this.tdn = dn;
        }
        DocGia_BUS dgBUS = new DocGia_BUS();

        private void btnCN_Click(object sender, EventArgs e)
        {
            DocGia_DTO dg = new DocGia_DTO();
         
                dg.HoTen = txtHT.Text;
                dg.NamSinh = dtNS.Value;
                if (rbtnNam.Checked == true)
                    dg.GioiTinh = "Nam";
                else if (rbtnNu.Checked == true)
                    dg.GioiTinh = "Nữ";
                dg.DiaChi = txtDC.Text;
                if (!dgBUS.SuaDG1(dg, tdn))
                    MessageBox.Show("Cập nhật thông tin của bạn không thành công!!!");
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                    ThayDoiTT_Load(sender, e);
                }
            

                

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThayDoiTT_Load(object sender, EventArgs e)
        {
            txtHT.ResetText();
            txtDC.ResetText();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            dtNS.ResetText();
         

            

        }

        private void ThayDoiTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
     
    }
}
