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
    public partial class TCS : Form
    {
        public TCS()
        {
            InitializeComponent();
        }
        TS_BUS ts = new TS_BUS();
        Sach_DTO s = new Sach_DTO();

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimS.Text == "" )
            {
                dtgTCSach.DataSource = ts.GetList();
                lbTB.Visible = true;               
            }
            else

                lbTB.Visible = false;
                dtgTCSach.DataSource = ts.TS(txtTimS.Text, "TenSach");
        }

        private void TCS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            dtgTCSach.DataSource = ts.GetList();
            lbTB.Visible = false;
        }

        private void TCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }


    }
}
