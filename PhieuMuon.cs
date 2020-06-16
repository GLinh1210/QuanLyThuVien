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
    public partial class PhieuMuon : Form
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }
        PhieuMuon_BUS muonBUS = new PhieuMuon_BUS();

        private void BtnSua_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO s = new PhieuMuon_DTO();
            if (txtMP.Text == "")
            {
                MessageBox.Show("Phải nhập mã phiếu muốn sửa!!!");
                txtMP.Focus();
            }
            else
            {
                s.MaPhieu = txtMP.Text;
            }
            if (txtMP.Text == "" || cbMDG.Text == "" || cbMS.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {

                s.MaDocGia = cbMDG.Text;
                s.MaPhieu = txtMP.Text;
                s.MaSach = cbMS.Text;
                s.NgayMuon = dtMuon.Value;
                s.NgayPhaiTra = dtTra.Value;
         
                if (!muonBUS.SuaM(s))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                Reset(sender, e);
                PhieuMuon_Load(sender, e);
            }
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
                if (txtMP.Text != "" && cbMDG.Text != "" && cbMS.Text != "")
                {
                    pm.MaDocGia = cbMDG.Text;
                    pm.MaPhieu = txtMP.Text;
                    pm.MaSach = cbMS.Text;
                    pm.NgayMuon = dtMuon.Value;
                    pm.NgayPhaiTra = dtTra.Value;

                  int check = muonBUS.ThemM(pm);
                    if (check == 0)
                    {
                        MessageBox.Show("Thêm không thành công");
                        

                    }
                    else if (check == -1)
                        MessageBox.Show("Thêm thành công");
                    Reset(sender, e);
                    PhieuMuon_Load(sender, e);
 
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
            
        }

        

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (txtMP.Text != "")
            {
                muonBUS.XoaM(txtMP.Text);
                Reset(sender, e);
                PhieuMuon_Load(sender, e);
            }
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            dtgMuon.DataSource = muonBUS.GetList();
        
        }
        public void Reset(object sender, EventArgs e)
        {
            txtMP.ResetText();
            txtTim.ResetText();
            cbMDG.ResetText();
            cbMS.ResetText();
            dtMuon.Value = dtMuon.MaxDate;
            dtTra.Value = dtTra.MaxDate;
        }

        private void dtgMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgMuon.CurrentRow.Index;
            txtMP.Text = dtgMuon.Rows[i].Cells[0].Value.ToString();
            cbMDG.Text = dtgMuon.Rows[i].Cells[1].Value.ToString();
            cbMS.Text = dtgMuon.Rows[i].Cells[2].Value.ToString();
            dtMuon.Text = dtgMuon.Rows[i].Cells[3].Value.ToString();
            dtTra.Text = dtgMuon.Rows[i].Cells[4].Value.ToString();

        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dtgMuon.DataSource = muonBUS.GetList();
            }
            else
                dtgMuon.DataSource = muonBUS.TimKiemM(txtTim.Text, "MaPhieu");
        }

    }
}
