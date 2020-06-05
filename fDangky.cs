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
using System.Data.Sql;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DAO;


namespace QuanLyThuVien
{
    public partial class fDangky : Form
    {
        
        public fDangky()
        {
            InitializeComponent();
            //for (int i = 1; i <= 31; i++)
            //{
            //    this.cbNgay.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Ngày : 1 - 31 ngày
            //}

            //for (int i = 0; i <= 12; i++)
            //{
            //    this.cbThang.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Tháng : 1 - 12 tháng
            //}

            //int curYear = DateTime.Now.Year; // Lấy ra năm hiện tại
            //for (int i = curYear; i >= 1900; i--)
            //{
            //    this.cbNam.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Năm: 1900 - Năm hiên tại
            //}
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fDangky_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
