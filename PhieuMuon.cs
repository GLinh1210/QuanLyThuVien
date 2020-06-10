using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVien
{
    public partial class PhieuMuon : Form
    {
        
         string str = @"Data Source=DESKTOP-8MH1NJR\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
         
        public PhieuMuon()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(str);
            try 
            {
                conn.Open();
                string sql = "select*from PHIEUMUON";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }
        private void PhieuMuon_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            TxtMaPhieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TxtMaDG.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            TxtMaSach.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayMuon.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dtNgayTra.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void BtNhapLai_Click(object sender, EventArgs e)
        {
            TxtMaPhieu.Clear();
            TxtMaDG.Clear();
            TxtMaSach.Clear();
            
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
                if (TxtMaPhieu.Text != "" && TxtMaDG.Text != "" && TxtMaSach.Text != "")
                {
                    conn.Open();
                    string sql = "insert into PHIEUMUON values('" + TxtMaPhieu + "','" + TxtMaDG + "','" + TxtMaSach + "','" + dtNgayMuon + "','" + dtNgayTra + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq =(int)cmd.ExecuteNonQuery();
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
            if(thongbao==DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "delete from PHIEUMUON where MaDocGia '" + TxtMaDG + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                load();
                conn.Close();
            }    
        }
    }
}
