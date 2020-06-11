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
        
        public PhieuMuon()
        {
            InitializeComponent();
        }
        PhieuMuon_BUS PMBUS = new PhieuMuon_BUS();

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
          
            
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (TxtMaPhieu.Text == "" || cbMaDG.Text == "" || cbMaSach.Text == "" )
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                PhieuMuon_DTO m = new PhieuMuon_DTO();
                if (TxtMaPhieu.Text == m.MaPhieu)
                {
                    MessageBox.Show("Mã sách đã tồn tại!!!");
                    TxtMaPhieu.ResetText();
                    TxtMaPhieu.Focus();
                }
                else
                {
                    m.MaPhieu = TxtMaPhieu.Text;
                    m.MaDocGia = cbMaDG.Text;
                    m.MaSach = cbMaSach.Text;
                    m.NgayPhaiTra = dtNgayTra.Value;
                    m.NgayMuon = dtNgayMuon.Value;
                    
                    int check = PMBUS.Them(m);
                    if (check == 0)
                        MessageBox.Show("Thêm không thành công !!!");
                    else if (check == -1)
                        MessageBox.Show("Thêm sách thành công");

                    PhieuMuon_Load_1(sender, e);
                    ResetGridview();

                }
            }
        }

        

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao==DialogResult.OK)
            {
                if (TxtMaPhieu.Text != "")
                {
                    PMBUS.Xoa(TxtMaPhieu.Text);
                    ResetGridview();
                    PhieuMuon_Load_1(sender, e);
                };
            }    
        }

        private void PhieuMuon_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.DOCGIA);
            dataGridView1.DataSource = PMBUS.GetList();
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO m = new PhieuMuon_DTO();
            if (TxtMaPhieu.Text == "")
            {
                MessageBox.Show("Phải nhập mã sách muốn sửa!!!");
                TxtMaPhieu.Focus();
            }
            else
            {
                m.MaPhieu = TxtMaPhieu.Text;
            }
            if (cbMaDG.Text == "" || cbMaSach.Text == "" || dtNgayMuon.Text == "" || dtNgayTra.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {

                m.MaDocGia = cbMaDG.Text;
                m.MaSach = cbMaSach.Text;
                if (!PMBUS.Sua(m))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                PhieuMuon_Load_1(sender, e);
                ResetGridview();
            }
        }
    }
}
