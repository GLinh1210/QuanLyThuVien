using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class fGiaoDien : Form
    {
        public fGiaoDien()
        {
            InitializeComponent();
            Form f = new Form();
            f.Parent = this;
            f.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }
    }
}
