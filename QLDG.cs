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
    public partial class QLDG : Form
    {
        public QLDG()
        {
            InitializeComponent();
        }
        QLDG_BUS dgB = new QLDG_BUS();

        private void btnTDG_Click(object sender, EventArgs e)
        {
            if (txtMDG.Text == "" || txtTDN.Text == "" || txtHT.Text == "" || (rbtnNam.Checked == false) && (rbtnNu.Checked == false) || txtDiaChi.Text == "" || dtNS.Text == "")
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                DocGia_DTO dk = new DocGia_DTO();
                Account_DTO dn = new Account_DTO();
                dn.MaDocGia = txtMDG.Text;
                dn.TenDangNhap = txtTDN.Text;
                dk.HoTen = txtHT.Text;
                dk.NamSinh = dtNS.Value;
                if (rbtnNam.Checked == true)
                    dk.GioiTinh = "Nam";
                else if (rbtnNu.Checked == true)
                    dk.GioiTinh = "Nữ";
                dk.DiaChi = txtDiaChi.Text;
                int check = dgB.ThemDG1(dk, dn);
                if (check == 0)
                    MessageBox.Show("Thêm không thành công !!!");
                else if (check == -1)
                    MessageBox.Show("Thêm sách thành công");
                QLDG_Load(sender, e);
                ResetForm();

            }
        }

        private void QLDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            dtgDG.DataSource = dgB.GetList();
        }

        private void ResetForm()
        {
            txtDiaChi.ResetText();
            txtHT.ResetText();
            txtMDG.ResetText();
            txtTDN.ResetText();
            txtTim.ResetText();
            dtNS.ResetText();
            rbtnNu.Checked = false;
            rbtnNam.Checked = false;
        }

        private void dtgDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgDG.CurrentRow.Index;

            txtMDG.Text = dtgDG.Rows[i].Cells[0].Value.ToString();
            txtTDN.Text = dtgDG.Rows[i].Cells[1].Value.ToString();
            txtHT.Text = dtgDG.Rows[i].Cells[2].Value.ToString();
            if (dtgDG.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                rbtnNam.Checked = true;
            }
            else if (dtgDG.CurrentRow.Cells[3].Value.ToString() == "False")
            {
                rbtnNu.Checked = true;
            }
            dtNS.Value = (DateTime)dtgDG.Rows[i].Cells[4].Value;
            txtDiaChi.Text = dtgDG.Rows[i].Cells[5].Value.ToString();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (txtTim.Text == "")
            {
                dtgDG.DataSource = dgB.GetList();
            }
            else
                dtgDG.DataSource = dgB.TimDG1(txtTim.Text, "MaDocGia");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMDG.Text != "")
            {
                dgB.XoaDG1(txtMDG.Text);
                MessageBox.Show("Đã xóa độc giả");
                ResetForm();
                QLDG_Load(sender, e);
            }
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DocGia_DTO dk = new DocGia_DTO();
            Account_DTO dn = new Account_DTO();
            if (txtMDG.Text == "")
            {
                MessageBox.Show("Phải nhập mã độc giả muốn sửa!!!");
                txtMDG.Focus();
            }
            else
            {
                dn.MaDocGia = txtMDG.Text;
            }
            if (txtMDG.Text == "" || txtTDN.Text == "" || txtHT.Text == "" || (rbtnNam.Checked == false) && (rbtnNu.Checked == false) || txtDiaChi.Text == "" || dtNS.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {

                dn.MaDocGia = txtMDG.Text;
                dn.TenDangNhap = txtTDN.Text;
                dk.HoTen = txtHT.Text;
                dk.NamSinh = dtNS.Value;
                if (rbtnNam.Checked == true)
                    dk.GioiTinh = "Nam";
                else if (rbtnNu.Checked == true)
                    dk.GioiTinh = "Nữ";
                dk.NamSinh = dtNS.Value;
                dk.DiaChi = txtDiaChi.Text;
                if (!dgB.SuaDG1(dk, dn))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                QLDG_Load(sender, e);
                ResetForm();
            }
        }

    }
}
