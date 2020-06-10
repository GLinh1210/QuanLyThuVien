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
namespace QuanLyThuVien
{
    public partial class PhieuTra : Form
    {
        string str = @"Data Source=DESKTOP-8MH1NJR\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public PhieuTra()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(str);
            try
            {
                conn.Open();
                string sql = "select*from PHIEUTRA";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView2.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void PhieuTra_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtMaPhieu.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtMaDG.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtMaSach.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            dtNgayTra.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
        }

        private void BtNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtMaDG.Clear();
            txtMaSach.Clear();

        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            try
            {
                if (txtMaPhieu.Text != "" && txtMaDG.Text != "" && txtMaSach.Text != "")
                {
                    conn.Open();
                    string sql = "INSERT INTO PHIEUTRA values('" + txtMaPhieu + "','" + txtMaDG + "','" + txtMaSach + "','" + dtNgayTra + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();

                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                    conn.Close();
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "delete from PHIEUTRA where MaDocGia '" + txtMaDG + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                load();
                conn.Close();
            }
        }
    }
}
