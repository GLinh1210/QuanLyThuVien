using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien
{
    public partial class fDangky : Form
    {
        DataProvier _dt = new DataProvier();
        DangKy_BUS _dk = new DangKy_BUS();
        DangNhap_DTO dnDTO = new DangNhap_DTO();
        DangKy_DTO dkDTO = new DangKy_DTO();
        DangKy_DAO dkDao = new DangKy_DAO();

        public fDangky()
        {
            InitializeComponent();

        }
     

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            
        }
        private void fDangky_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        private void btnDK1_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "" || txtTendn.Text == "" || txtPass.Text == "" || txtDiachi.Text == "" || DTNamsinh.Text == "" || (rbtnNam.Checked == false) && (rbtnNu.Checked == false))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                
            }
            Random rd = new Random();
            dnDTO.MaDocGia = rd.Next(100, 999).ToString();
            dnDTO.MatKhau = txtPass.Text;
            dnDTO.TenDangNhap = txtTendn.Text;
            dkDTO.HoTen = txthoten.Text;
            dkDTO.DiaChi = txtDiachi.Text;
            if (rbtnNam.Checked == true)
                dkDTO.GioiTinh = "Nam  ";
            else if (rbtnNu.Checked == true)
                dkDTO.GioiTinh = "Nữ   ";

            if (DTNamsinh.Text == "")
                dkDTO.NamSinh = DateTime.Now;
            else
                dkDTO.NamSinh = DTNamsinh.Value;
            
            bool kthoa = false;
            for (int i = 0; i < txtPass.Text.Length; i++)
            {
                if (txtPass.Text[i] >= 'A' && txtPass.Text[i] <= 'Z')
                {
                    kthoa = true;
                }
            }
            if (kthoa == true && txtPass.Text != "")
            {
                

                if ((_dk.Them(dnDTO, dkDTO)) == true)
                    MessageBox.Show("Thêm thành công. Quay lại trang Login để đăng nhập!");
    
                else
                    MessageBox.Show("Thêm không thành công");
                ResetForm();
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Mật khẩu phải gồm 1 ký tự in hoa");
                txtPass.ResetText();
                txtPass.Focus();

            }
            
        }
        private void ResetForm()
        {

            txtTendn.ResetText();
            txtPass.ResetText();
            txthoten.ResetText();
            txtDiachi.ResetText();
            rbtnNu.Checked = false;
            rbtnNam.Checked = false;
            DTNamsinh.Value = DTNamsinh.MaxDate ;

        }

    }
}
