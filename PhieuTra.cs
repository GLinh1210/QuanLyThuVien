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
    public partial class PhieuTra : Form
    {
        public PhieuTra()
        {
            InitializeComponent();
        }
        PhieuTra_BUS traBUS = new PhieuTra_BUS();

        private void BtnSua_Click(object sender, EventArgs e)
        {
            PhieuTra_DTO s = new PhieuTra_DTO();
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
                s.NgayTra = dtTra.Value;
         
                if (!traBUS.SuaT(s))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                Reset(sender, e);
                PhieuTra_Load(sender, e);
            }
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            PhieuTra_DTO pm = new PhieuTra_DTO();
                if (txtMP.Text != "" && cbMDG.Text != "" && cbMS.Text != "")
                {
                    pm.MaDocGia = cbMDG.Text;
                    pm.MaPhieu = txtMP.Text;
                    pm.MaSach = cbMS.Text;
                    pm.NgayTra = dtTra.Value;

                  int check = traBUS.ThemT(pm);
                    if (check == 0)
                    {
                        MessageBox.Show("Thêm không thành công");
                        

                    }
                    else if (check == -1)
                        MessageBox.Show("Thêm thành công");
                    Reset(sender, e);
                    PhieuTra_Load(sender, e);
 
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
            
        }

        

        private void BtXoa_Click(object sender, EventArgs e)
        {
            int check = traBUS.XoaT(txtMP.Text);
            if (txtMP.Text != "")
            {
                if (check == -1)
                {
                    MessageBox.Show("Đã xóa phiếu mượn");
                    Reset(sender, e);
                    PhieuTra_Load(sender, e);
                }
                else if (check == 0)
                    MessageBox.Show("Xóa không thành công");
            }
        }

        private void PhieuTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            
            dtgTra.DataSource = traBUS.GetList();
        
        }
        public void Reset(object sender, EventArgs e)
        {
            txtMP.ResetText();
            txtTim.ResetText();
            cbMDG.ResetText();
            cbMS.ResetText();
            dtTra.Value = dtTra.MaxDate;
        }

        private void dtgMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgTra.CurrentRow.Index;
            txtMP.Text = dtgTra.Rows[i].Cells[0].Value.ToString();
            cbMDG.Text = dtgTra.Rows[i].Cells[1].Value.ToString();
            cbMS.Text = dtgTra.Rows[i].Cells[2].Value.ToString();
            dtTra.Text = dtgTra.Rows[i].Cells[3].Value.ToString();
            

        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuTra_FormClosing(object sender, FormClosingEventArgs e)
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
                dtgTra.DataSource = traBUS.GetList();
            }
            else
                dtgTra.DataSource = traBUS.TimKiemT(txtTim.Text, "MaPhieu");
        }

    }
}
    

