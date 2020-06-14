using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien
{
    public partial class PhieuTra : Form
    {
        PhieuTra_BUS PTBUS = new PhieuTra_BUS();
        public PhieuTra()
        {
            InitializeComponent();
        }
      



        private void PhieuTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            dataGridView2.DataSource = PTBUS.GetList();
        }
    

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtMaPhieu.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            cbMaDG.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbMaSach.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            dtNgayTra.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
        }
        private void ResetGridview()
        {
            txtMaPhieu.ResetText();
            cbMaDG.ResetText();
            cbMaSach.ResetText();
            dtNgayTra.ResetText();

        }

        private void BtNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            cbMaDG.ResetText();
            cbMaSach.ResetText();

        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            PhieuTra_DTO pm = new PhieuTra_DTO();
            if (txtMaPhieu.Text != "" && cbMaDG.Text != "" && cbMaSach.Text != "")
            {
                pm.MaDocGia = cbMaDG.Text;
                pm.MaPhieu = txtMaPhieu.Text;
                pm.MaSach = cbMaSach.Text;
                pm.NgayTra = dtNgayTra.Value;

                int check = PTBUS.ThemB(pm);
                if (check == 0)
                {
                    MessageBox.Show("Thêm không thành công");


                }
                else if (check == -1)
                    MessageBox.Show("Thêm thành công");
                BtNhapLai_Click(sender, e);
                PhieuTra_Load(sender, e);

            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin");


        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                if (txtMaPhieu.Text != "")
                {
                    PTBUS.XoaB(txtMaPhieu.Text);
                    ResetGridview();
                    PhieuTra_Load(sender, e);
                };
            }
        }

        private void PhieuTra_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            PhieuTra_DTO s = new PhieuTra_DTO();
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Phải nhập mã phiếu muốn sửa!!!");
                txtMaPhieu.Focus();
            }
            else
            {
                s.MaPhieu = txtMaPhieu.Text;
            }
            if (txtMaPhieu.Text == "" || cbMaDG.Text == "" || cbMaSach.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {

                s.MaDocGia = cbMaDG.Text;
                s.MaPhieu = txtMaPhieu.Text;
                s.MaSach = cbMaSach.Text;
                s.NgayTra = dtNgayTra.Value;

                if (!PTBUS.SuaB(s))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                BtNhapLai_Click(sender, e);
                PhieuTra_Load(sender, e);
            }
        }
    }
}
        
            


       