using System;
using System.Collections.Generic;
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
        PhieuTra_BUS PTBUS = new PhieuTra_BUS();



        private void PhieuTra_Load(object sender, EventArgs e)
        {
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


        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "" || cbMaDG.Text == "" || cbMaSach.Text == "")
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                PhieuTra_DTO t = new PhieuTra_DTO();
                if (txtMaPhieu.Text == t.MaPhieu)
                {
                    MessageBox.Show("Mã sách đã tồn tại!!!");
                    txtMaPhieu.ResetText();
                    txtMaPhieu.Focus();
                }
                else
                {
                    t.MaPhieu = txtMaPhieu.Text;
                    t.MaDocGia = cbMaDG.Text;
                    t.MaSach = cbMaSach.Text;

                    int check = PTBUS.Them(t);
                    if (check == 0)
                        MessageBox.Show("Thêm không thành công !!!");
                    else if (check == -1)
                        MessageBox.Show("Thêm sách thành công");

                    PhieuTra_Load(sender, e);
                    ResetGridview();
                }
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                if (txtMaPhieu.Text != "")
                {
                    PTBUS.Xoa(txtMaPhieu.Text);
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
    }
}
        
            


       