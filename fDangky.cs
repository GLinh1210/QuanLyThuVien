//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;


//namespace QuanLyThuVien
//{
//    public partial class fDangky : Form
//    {
//        AccessData acc;
//        public fDangky()
//        {
//            InitializeComponent();
//            for (int i = 1; i <= 31; i++)
//            {
//                this.cbNgay.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Ngày : 1 - 31 ngày
//            }

//            for (int i = 0; i <= 12; i++)
//            {
//                this.cbThang.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Tháng : 1 - 12 tháng
//            }

//            int curYear = DateTime.Now.Year; // Lấy ra năm hiện tại
//            for (int i = curYear; i >= 1900; i--)
//            {
//                this.cbNam.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Năm: 1900 - Năm hiên tại
//            }
//        }

//        private void btnThoat1_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }
//        private void fDangky_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            DialogResult d = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//            if (d == DialogResult.No)
//            {
//                e.Cancel = true;
//            }
//        }

//        private void btnDK1_Click(object sender, EventArgs e)
//        {
//            Ngay n = new Ngay(); // Tạo đối tượng Ngày => Kiểm tra tính hợp lệ của ngày
//            if (n.KiemTraHopLe(cbNgay, cbThang, cbNam) == 1)
//            {
//                acc = new AccessData();
//                string gender = ""; // Tạo biến gender => Để chứa giá trị Male hoặc Female
//                string birth = ""; // Tạo biến birth => Để chứa ngày tháng năm sinh (12/12/1900)
//                if (this.rbtnNam.Checked == true)
//                {
//                    gender = "Nam"; // Nếu RadioButton Male được check => Lưu Male vào gender
//                }
//                else
//                {
//                    if (this.rbtnNu.Checked == true)
//                    {
//                        gender = "Nữ"; // Nếu RadioButton Female được check => Lưu Female vào gender
//                    }
//                }
//                // Lấy ngày tháng năm từ ComboBox và lưu vào cho biến birth
//                birth = cbNgay.SelectedItem.ToString() + "/" + cbThang.SelectedItem.ToString() + "/" + cbNam.SelectedItem.ToString();
//                //
//                string sql = "INSERT INTO DOCGIA VALUES('" + txtTendn.Text + "', '" + txthoten.Text + "',  '" + gender + "', '" + birth + "','" + txtDiachi.Text + "')"; // Query Insert data
//                acc.ExcuteNonQuery(sql); // Thực thi Query
//                MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Nếu đang ký thành công => Sẽ có thông báo Thành Công và đồng thời các TextBox sẽ mất giá trị do [B]ClearTextBox()[/B].
//                ClearTextBox();
//            }
//            else
//            {
//                // Nếu ngày tháng ko hợp lê thì nó sẽ hiển thị lại bằng các tên bên dưới.
//                cbNgay.Text = "Date:";
//                cbThang.Text = "Month:";
//                cbNam.Text = "Year:";
//            }
//        }
//             private void ClearTextBox()
//        {
//            txtTendn.Clear();
//            txtPass.Clear();
//            txtDiachi.Clear();
//            cbNgay.Text = "Day:";
//            cbThang.Text = "Month:";
//            cbNam.Text = "Year:";
//        }
        
//    }
//}
