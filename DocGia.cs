using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }
        BUS_DEMO dgBus = new BUS_DEMO();
        private void DocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            dataGridView1.DataSource = dgBus.GetList();
        }
        private void Them_Click(object sender, EventArgs e)
        {
            if (textMaDocGia.Text == "" || textTenDangNhap.Text == "" || textTenDocGia.Text == "" || (radNam.Checked == false) && (radNu.Checked == false) || textDiaChi.Text == "" || DateTimeNamSinh.Text == "")
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                DangKy_DTO dk = new DangKy_DTO();
                DangNhap_DTO dn = new DangNhap_DTO();
                dn.MaDocGia = textMaDocGia.Text;
                dn.TenDangNhap = textTenDangNhap.Text;
                dk.TenDocGia = textTenDocGia.Text;
                dk.NamSinh = DateTimeNamSinh.Value;
                if (radNam.Checked == true)
                    dk.GioiTinh = "Nam";
                else if (radNu.Checked == true)
                    dk.GioiTinh = "Nữ";
                dk.DiaChi = textDiaChi.Text;
                int check = dgBus.ThemDG1(dk, dn);
                if (check == 0)
                    MessageBox.Show("Thêm không thành công !!!");
                else if (check == -1)
                    MessageBox.Show("Thêm sách thành công");
                DocGia_Load(sender, e);
                ResetForm();

            }
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            DangKy_DTO dk = new DangKy_DTO();
            DangNhap_DTO dn = new DangNhap_DTO();
            if (textMaDocGia.Text == "")
            {
                MessageBox.Show("Phải nhập mã độc giả muốn sửa!!!");
                textMaDocGia.Focus();
            }
            else
            {
                dn.MaDocGia = textMaDocGia.Text;
            }
            if (textMaDocGia.Text == "" || textTenDangNhap.Text == "" || textTenDocGia.Text == "" || (radNam.Checked == false) && (radNu.Checked == false) || textDiaChi.Text == "" || DateTimeNamSinh.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {
                dn.MaDocGia = textMaDocGia.Text;
                dn.TenDangNhap = textTenDangNhap.Text;
                dk.TenDocGia = textTenDocGia.Text;
                dk.NamSinh = DateTimeNamSinh.Value;
                if (radNam.Checked == true)
                    dk.GioiTinh = "Nam";
                else if (radNu.Checked == true)
                    dk.GioiTinh = "Nữ";
                dk.NamSinh = DateTimeNamSinh.Value;
                dk.DiaChi = textDiaChi.Text;
                if (!dgBus.SuaDG1(dk, dn))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                DocGia_Load(sender, e);
                ResetForm();
            }
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            if (textMaDocGia.Text != "")
            {
                dgBus.XoaDG1(textMaDocGia.Text);
                MessageBox.Show("Đã xóa độc giả");
                ResetForm();
                DocGia_Load(sender, e);
            }
            else
                MessageBox.Show("Xóa không thành công");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textMaCanTim.Text == "")
            {
                dataGridView1.DataSource = dgBus.GetList();
            }
            else
                dataGridView1.DataSource = dgBus.TimDG1(textMaCanTim.Text, "MaDocGia");
        }
        private void ResetForm()
        {
            textDiaChi.ResetText();
            textTenDocGia.ResetText();
            textMaDocGia.ResetText();
            textTenDangNhap.ResetText();
            textMaCanTim.ResetText();
            DateTimeNamSinh.ResetText();
            radNu.Checked = false;
            radNam.Checked = false;
        }
        private void DocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            textMaDocGia.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textTenDangNhap.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textTenDocGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                radNam.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "False")
            {
                radNu.Checked = true;
            }
            DateTimeNamSinh.Value = (DateTime)dataGridView1.Rows[i].Cells[4].Value;
            textDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
