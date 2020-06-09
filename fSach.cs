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
    public partial class fSach : Form
    {
        public fSach()
        {
            InitializeComponent();
        }
        Sach_BUS sachBUS = new Sach_BUS();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == "" || txtTensach.Text == "" || txtTacgia.Text == "" || txtNXB.Text == "" || cbTheloai.Text == "" || txtGia.Text == "" || cbTT.Text == "" || nbSL.Text == "")
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                Sach_DTO s = new Sach_DTO();
                if (txtMasach.Text == s.MaSach)
                {
                    MessageBox.Show("Mã sách đã tồn tại!!!");
                    txtMasach.ResetText();
                    txtMasach.Focus();
                }
                else
                {
                    s.MaSach = txtMasach.Text;
                    s.TenSach = txtTensach.Text;
                    s.TacGia = txtTacgia.Text;
                    s.NhaXuatBan = txtNXB.Text;
                    s.TheLoai = cbTheloai.Text;
                    s.TinhTrang = cbTT.Text;
                    if (txtGia.Text != "")
                        s.GiaSach = int.Parse(txtGia.Text);
                    s.SoLuong = Convert.ToInt32(nbSL.Value);
                    int check = sachBUS.Them(s);
                    if (check == 0)
                        MessageBox.Show("Thêm không thành công !!!");
                    else if (check == -1)
                        MessageBox.Show("Thêm sách thành công");

                    fSach_Load(sender, e);
                    ResetGridview();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text != "")
            {
                sachBUS.Xoa(txtMasach.Text);
                ResetGridview();
                fSach_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            Sach_DTO s = new Sach_DTO();
            if (txtMasach.Text == "")
            {
                MessageBox.Show("Phải nhập mã sách muốn sửa!!!");
                txtMasach.Focus();
            }
            else
            {
                s.MaSach = txtMasach.Text;
            }
            if (txtTensach.Text == "" || txtTacgia.Text == "" || txtNXB.Text == "" || cbTheloai.Text == "" || txtGia.Text == "" || cbTT.Text == "" || nbSL.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {
      
                s.TenSach = txtTensach.Text;
            
            
            s.TacGia = txtTacgia.Text;
            s.NhaXuatBan = txtNXB.Text;
            s.TheLoai = cbTheloai.Text;
            s.TinhTrang = cbTT.Text;
            if (txtGia.Text != "")
                s.GiaSach = int.Parse(txtGia.Text);
            s.SoLuong = Convert.ToInt32(nbSL.Value);

            if (!sachBUS.Sua(s))
                MessageBox.Show("Sửa không thành công!!!");
            else
                MessageBox.Show("Sửa thành công");
            fSach_Load(sender, e);
            ResetGridview();
            }
        }
        private void ResetGridview()
        {
            txtMasach.ResetText();
            txtTensach.ResetText();
            cbTheloai.ResetText();
            txtTacgia.ResetText();
            txtGia.ResetText();
            txtNXB.ResetText();
            nbSL.ResetText();
            cbTT.ResetText();
        }


        //private void dtgSach_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow row = dtgSach.SelectedRows[0];
        //    txtMasach.Text = row.Cells[1].Value.ToString();
        //    txtTensach.Text = row.Cells[2].Value.ToString();
        //    txtTacgia.Text = row.Cells[3].Value.ToString();
        //    cbTheloai.Text = row.Cells[4].Value.ToString();
        //    txtNXB.Text = row.Cells[5].Value.ToString();
        //    txtGia.Text = row.Cells[6].Value.ToString();
        //    nbSL.Text = row.Cells[7].Value.ToString();
        //    cbTT.Text = row.Cells[8].Value.ToString();

        //}

        private void fSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            
            dtgSach.DataSource = sachBUS.GetList();
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dtgSach.DataSource = sachBUS.GetList();
            }
            else
                dtgSach.DataSource = sachBUS.TimKiem(txtTim.Text, "MaSach");
        }

        private void dtgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgSach.CurrentRow.Index;
            //DataGridViewRow row = dtgSach.SelectedRows[0];
            txtMasach.Text = dtgSach.Rows[i].Cells[0].Value.ToString();
            txtTensach.Text = dtgSach.Rows[i].Cells[1].Value.ToString();
            txtTacgia.Text = dtgSach.Rows[i].Cells[2].Value.ToString();
            cbTheloai.Text = dtgSach.Rows[i].Cells[3].Value.ToString();
            txtNXB.Text = dtgSach.Rows[i].Cells[4].Value.ToString();
            txtGia.Text = dtgSach.Rows[i].Cells[5].Value.ToString();
            nbSL.Text = dtgSach.Rows[i].Cells[6].Value.ToString();
            cbTT.Text = dtgSach.Rows[i].Cells[7].Value.ToString();

        }
        private void fSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
