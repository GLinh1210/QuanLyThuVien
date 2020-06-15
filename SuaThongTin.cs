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
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using QuanLyThuVien.BUS;

namespace QuanLyThuVien
{
    public partial class SuaThongTin : Form
    {
        public SuaThongTin()
        {
            InitializeComponent();
        }

        private void SuaThongTin_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DTO_DEMO dg = new DTO_DEMO();
            BUS_DEMO dgBus = new BUS_DEMO();
          
            if (textMDG.Text == "")
            {
                MessageBox.Show("Phải nhập mã độc giả muốn sửa!!!");
                textMDG.Focus();
            }
            else
            {
                dg.MaDocGia = textMDG.Text;
            }
            if (textMDG.Text == "" || textTDN.Text == "" || textTDG.Text == "" || (radNam.Checked == false) && (radNu.Checked == false) || textDiaChi.Text == "" || dateTimeNS.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {
                dg.MaDocGia = textMDG.Text;
                dg.HoTen = textTDN.Text;
                dg.TenDocGia = textTDG.Text;
                dg.NamSinh = dateTimeNS.Value;
                if (radNam.Checked == true)
                    dg.GioiTinh = "Nam";
                else if (radNu.Checked == true)
                    dg.GioiTinh = "Nữ";
                dg.NamSinh = dateTimeNS.Value;
                dg.DiaChi = textDiaChi.Text;
                if (!dgBus.btSua(dg))
                    MessageBox.Show("Sửa không thành công!!!");
                else
                    MessageBox.Show("Sửa thành công");
                SuaThongTin_Load(sender, e);
                ResetForm();
            }
        }

        private void ResetForm()
        {
            throw new NotImplementedException();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textMDG.Text == "" || textTDN.Text == "" || textTDG.Text == "" || (radNam.Checked == false) && (radNu.Checked == false) || textDiaChi.Text == "" || dateTimeNS.Text == "")
            {
                MessageBox.Show("Phải điền đủ thông tin!!!");
            }
            else
            {
                DTO_DEMO dg = new DTO_DEMO();             
                dg.MaDocGia = textMDG.Text;
                dg.HoTen = textTDN.Text;
                dg.TenDocGia = textTDG.Text;
                dg.NamSinh = dateTimeNS.Value;
                if (radNam.Checked == true)
                    dg.GioiTinh = "Nam";
                else if (radNu.Checked == true)
                    dg.GioiTinh = "Nữ";
                dg.DiaChi = textDiaChi.Text;
                int check = dg.btLuu1(dg);
                if (check == 0)
                    MessageBox.Show("Thêm không thành công !!!");
                else if (check == -1)
                    MessageBox.Show("Thêm sách thành công");
                SuaThongTin_Load(sender, e);
                ResetForm();

            }
        }

    }
}
