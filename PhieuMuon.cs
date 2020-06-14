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
    public partial class PhieuMuon : Form
    {
        PhieuMuon_BUS muonBUS = new PhieuMuon_BUS();


        public PhieuMuon()
        {
            InitializeComponent();
        }
        private void PhieuMuon_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);



            dataGridView1.DataSource = muonBUS.GetList();

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            TxtMaPhieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbMaDG.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbMaSach.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayMuon.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dtNgayTra.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void ResetGridview()
        {
            TxtMaPhieu.ResetText();
            cbMaDG.ResetText();
            cbMaSach.ResetText();
            dtNgayMuon.ResetText();
            dtNgayTra.ResetText();
           
        }

        private void BtNhapLai_Click(object sender, EventArgs e)
        {
            TxtMaPhieu.Clear();
            cbMaDG.ResetText();
            cbMaSach.ResetText();
          
            
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            
        }

        private void BtThem_Click(object sender, EventArgs e)
        {

            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            if (TxtMaPhieu.Text != "" && cbMaDG.Text != "" && cbMaSach.Text != "")
            {
                pm.MaDocGia = cbMaDG.Text;
                pm.MaPhieu = TxtMaPhieu.Text;
                pm.MaSach = cbMaSach.Text;
                pm.NgayMuon = dtNgayMuon.Value;
                pm.NgayPhaiTra = dtNgayTra.Value;

                int check = muonBUS.ThemB(pm);
                if (check == 0)
                {
                    MessageBox.Show("Thêm không thành công");


                }
                else if (check == -1)
                    MessageBox.Show("Thêm thành công");
                BtNhapLai_Click(sender, e);
                PhieuMuon_Load_1(sender, e);

            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin");

        
    }

        

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao==DialogResult.OK)
            {
                if (TxtMaPhieu.Text != "")
                {
                    muonBUS.XoaB(TxtMaPhieu.Text);
                    ResetGridview();
                    PhieuMuon_Load_1(sender, e);
                };
            }    
        }

       

        private void BtSua_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO s = new PhieuMuon_DTO();
            if (TxtMaPhieu.Text == "")
            {
                MessageBox.Show("Phải nhập mã phiếu muốn sửa!!!");
                TxtMaPhieu.Focus();
            }
            else
            {
                s.MaPhieu = TxtMaPhieu.Text;
            }
            if (TxtMaPhieu.Text == "" || cbMaDG.Text == "" || cbMaSach.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {

                s.MaDocGia = cbMaDG.Text;
                s.MaPhieu = TxtMaPhieu.Text;
                s.MaSach = cbMaSach.Text;
                s.NgayMuon = dtNgayMuon.Value;
                s.NgayPhaiTra = dtNgayTra.Value;

                if (!muonBUS.SuaB(s))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                BtNhapLai_Click(sender, e);
                PhieuMuon_Load_1(sender, e);
            }
        }

        private void PhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
