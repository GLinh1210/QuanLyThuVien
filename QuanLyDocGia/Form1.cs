using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyDocGia
{
    public partial class Form1 : UserControl
    {
        DataTable dtDocGia;
        Bus_Docgia objDocGia = new Bus_Docgia();
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            NapListViewDSDocGia();
            ChiTiet.Enabled = false;
            radNam.Checked = true;
        }
        private void NapListViewDSDocGia()
        {
            dtDocGia = objDocGia.getTableDocGia();
            DanhSachDocGia.Items.Clear();
            foreach (DataRow dr in dtDocGia.Rows)
            {
                ListViewItem li = DanhSachDocGia.Items.Add(dr["MaDG"].ToString());
                li.Tag = dr["MaDG"].ToString();
                li.SubItems.Add(dr["TenDG"].ToString());
                li.SubItems.Add((bool)dr["GioiTinh"] == false ? "Nam" : "Nữ");
                string ngaymuon = Convert.ToDateTime(dr["NgayMuon"].ToString()).ToShortDateString();
                li.SubItems.Add(ngaymuon);
                li.SubItems.Add(dr["DiaChi"].ToString());
                li.ImageIndex = 0;

            }
        }    
        private void setButton()
        {
            Them.Text = "Thêm";
            MaDocGia.Text = "";
            HoTen.Text = "";
            radNam.Checked = true;
            NamSinh.Text = "";
            DiaChi.Text = "";
            Xoa.Enabled = true;
            Sua.Enabled = true;
            DanhSachDocGia.Enabled = true;
        }
        private void LuuThemDG()
        {
            try
            {
                DanhSachDocGia.Items.Clear();
                DataRow dr = dtDocGia.NewRow();
                dr["MaDG"] = MaDocGia.Text;
                dr["TenDG"] = HoTen.Text;
                dr["GioiTinh"] = radNu.Checked ? true : false;
                dr["NamSinh"] = NamSinh.Text;
                dr["DiaChi"] = DiaChi.Text;
                dtDocGia.Rows.Add(dr);
                objDocGia.CapNhatTable_DocGia(dtDocGia);
                setButton();
                NapListViewDSDocGia();
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception)
            {
                NapListViewDSDocGia();
                MessageBox.Show("Lưu dữ liệu thất bại!");
            }
        }
        private void LuuSuaDG()
        {
            try
            {
                dtDocGia = objDocGia.getTableDocGia_Theo_MaDG(DanhSachDocGia.SelectedItems[0].Text);
                dtDocGia.Rows[0]["MaDG"] = MaDocGia.Text;
                dtDocGia.Rows[0]["TenDG"] = HoTen.Text;
                dtDocGia.Rows[0]["GioiTinh"] = radNu.Checked ? true : false;
                dtDocGia.Rows[0]["NamSinh"] = NamSinh.Text;
                dtDocGia.Rows[0]["DiaChi"] = DiaChi.Text;
                objDocGia.CapNhatTable_DocGia(dtDocGia);
                MessageBox.Show("Lưu sửa dữ liệu thành công!");
                NapListViewDSDocGia();
            }
            catch (Exception)
            {

                MessageBox.Show("Thất bại!", "Error");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MaDocGia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã Độc Giả!", "Thông báo");
                MaDocGia.Focus();
            }
            else if (HoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên Độc Giả!", "Thông báo");
                HoTen.Focus();
            }
            else if (DiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ độc giả!", "Thông báo");
                DiaChi.Focus();
            }
            else
            {
                if (DanhSachDocGia.SelectedItems.Count == 0)
                    LuuThemDG();
                else
                    LuuSuaDG();
            }
        }
        private void Them_Click(object sender, EventArgs e)
        {
            if (Them.Text == "Thêm")
            {
                Them.Text = "Hủy";
                ChiTiet.Enabled = true;
                MaDocGia.Text = "";
                HoTen.Text = "";
                NamSinh.Text = "";
                DiaChi.Text = "";
                MaDocGia.Focus();
                Xoa.Enabled = false;
                Sua.Enabled = false;
                DanhSachDocGia.Enabled = false;
            }
            else
            {
                setButton();
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (DanhSachDocGia.SelectedItems.Count > 0)
            {
                if (Sua.Text == "Sửa")
                {
                    Sua.Text = "Hủy";
                    ChiTiet.Enabled = true;
                    Them.Enabled = false;
                    Xoa.Enabled = false;
                    Luu.Enabled = true;
                    NamSinh.Text = "";
                    MaDocGia.Focus();
                }
                else
                {
                    Sua.Text = "Sửa";
                    ChiTiet.Enabled = false;
                    Them.Enabled = true;
                    Xoa.Enabled = true;
                    Luu.Enabled = false;
                    NamSinh.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn dữ liệu cần sửa!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DanhSachDocGia.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    DataRow[] dr = dtDocGia.Select("MaDG='" + MaDocGia.Text + "'");
                    dr[0].Delete();
                    objDocGia.CapNhatTable_DocGia(dtDocGia);
                    // clear text
                    MaDocGia.Text = "";
                    HoTen.Text = "";
                    radNam.Checked = true;
                    NamSinh.Text = "";
                    DiaChi.Text = "";
                    ChiTiet.Enabled = false;
                    NapListViewDSDocGia();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dữ liệu cần xóa!", "Thông báo");
            }
        }

        private void QuanLyDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
