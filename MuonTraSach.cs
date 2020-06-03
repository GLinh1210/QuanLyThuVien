using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace QuanLyThuVien
{
    public partial class MuonTraSach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8MH1NJR\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from PHIEUMUON ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GVMuonSach.DataSource = table;
        }
        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from PHIEUTRA ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GVTraSach.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddata1();


        }


        public MuonTraSach()
        {
            InitializeComponent();
        }
  

    }
}
