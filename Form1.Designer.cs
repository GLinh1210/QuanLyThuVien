namespace QuanLyThuVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.btExit = new System.Windows.Forms.Button();
            this.btChoMuon = new System.Windows.Forms.Button();
            this.btMuonMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbMaDocGia = new System.Windows.Forms.ComboBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.cbChonMaSach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label17 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.dtHan = new System.Windows.Forms.DateTimePicker();
            this.dtMuon = new System.Windows.Forms.DateTimePicker();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btExit);
            this.tabPage1.Controls.Add(this.btChoMuon);
            this.tabPage1.Controls.Add(this.btMuonMoi);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý mượn sách";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvDanhSach);
            this.groupBox4.Location = new System.Drawing.Point(13, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(793, 134);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách cho mượn";
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.HideSelection = false;
            this.lvDanhSach.Location = new System.Drawing.Point(12, 22);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(759, 100);
            this.lvDanhSach.TabIndex = 0;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(678, 186);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(129, 56);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Kết thúc";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btChoMuon
            // 
            this.btChoMuon.Location = new System.Drawing.Point(678, 104);
            this.btChoMuon.Name = "btChoMuon";
            this.btChoMuon.Size = new System.Drawing.Size(129, 56);
            this.btChoMuon.TabIndex = 12;
            this.btChoMuon.Text = "CHo mượn";
            this.btChoMuon.UseVisualStyleBackColor = true;
            // 
            // btMuonMoi
            // 
            this.btMuonMoi.Location = new System.Drawing.Point(678, 17);
            this.btMuonMoi.Name = "btMuonMoi";
            this.btMuonMoi.Size = new System.Drawing.Size(129, 56);
            this.btMuonMoi.TabIndex = 11;
            this.btMuonMoi.Text = "Mượn mới";
            this.btMuonMoi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgayTra);
            this.groupBox2.Controls.Add(this.dtNgayMuon);
            this.groupBox2.Controls.Add(this.cbMaDocGia);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 230);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cho mượn";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(135, 186);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(127, 20);
            this.dtNgayTra.TabIndex = 13;
            this.dtNgayTra.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Location = new System.Drawing.Point(135, 148);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(127, 20);
            this.dtNgayMuon.TabIndex = 12;
            // 
            // cbMaDocGia
            // 
            this.cbMaDocGia.FormattingEnabled = true;
            this.cbMaDocGia.Location = new System.Drawing.Point(133, 33);
            this.cbMaDocGia.Name = "cbMaDocGia";
            this.cbMaDocGia.Size = new System.Drawing.Size(129, 21);
            this.cbMaDocGia.TabIndex = 10;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(135, 71);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(127, 20);
            this.txtMaSach.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(135, 107);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(127, 20);
            this.txtSoLuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày trả sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày mượn sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã độc giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTinhTrang);
            this.groupBox1.Controls.Add(this.lbTheLoai);
            this.groupBox1.Controls.Add(this.lbTenSach);
            this.groupBox1.Controls.Add(this.lbMaSach);
            this.groupBox1.Controls.Add(this.cbChonMaSach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.BackColor = System.Drawing.Color.White;
            this.lbTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTinhTrang.Enabled = false;
            this.lbTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTinhTrang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTinhTrang.Location = new System.Drawing.Point(127, 186);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(129, 20);
            this.lbTinhTrang.TabIndex = 9;
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.BackColor = System.Drawing.Color.White;
            this.lbTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTheLoai.Enabled = false;
            this.lbTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTheLoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTheLoai.Location = new System.Drawing.Point(127, 147);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(129, 20);
            this.lbTheLoai.TabIndex = 8;
            // 
            // lbTenSach
            // 
            this.lbTenSach.BackColor = System.Drawing.Color.White;
            this.lbTenSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenSach.Enabled = false;
            this.lbTenSach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTenSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTenSach.Location = new System.Drawing.Point(127, 107);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(129, 20);
            this.lbTenSach.TabIndex = 7;
            // 
            // lbMaSach
            // 
            this.lbMaSach.BackColor = System.Drawing.Color.White;
            this.lbMaSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaSach.Enabled = false;
            this.lbMaSach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbMaSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMaSach.Location = new System.Drawing.Point(127, 71);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(129, 20);
            this.lbMaSach.TabIndex = 6;
            // 
            // cbChonMaSach
            // 
            this.cbChonMaSach.FormattingEnabled = true;
            this.cbChonMaSach.Location = new System.Drawing.Point(127, 37);
            this.cbChonMaSach.Name = "cbChonMaSach";
            this.cbChonMaSach.Size = new System.Drawing.Size(129, 21);
            this.cbChonMaSach.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn mã sách";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btThoat);
            this.tabPage2.Controls.Add(this.btLuu);
            this.tabPage2.Controls.Add(this.btTra);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý trả sách";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView2);
            this.groupBox5.Location = new System.Drawing.Point(14, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(790, 118);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách trả sách";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 23);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(765, 94);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(625, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Trả sách";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(425, 219);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(152, 65);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(229, 219);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(152, 65);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btTra
            // 
            this.btTra.Location = new System.Drawing.Point(40, 219);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(152, 65);
            this.btTra.TabIndex = 1;
            this.btTra.Text = "trả sách";
            this.btTra.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtTra);
            this.groupBox3.Controls.Add(this.dtHan);
            this.groupBox3.Controls.Add(this.dtMuon);
            this.groupBox3.Controls.Add(this.cbMaDG);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.txtMaS);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(8, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 189);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thực hiện trả sách";
            // 
            // dtTra
            // 
            this.dtTra.Location = new System.Drawing.Point(589, 136);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(114, 20);
            this.dtTra.TabIndex = 16;
            // 
            // dtHan
            // 
            this.dtHan.Location = new System.Drawing.Point(589, 89);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(114, 20);
            this.dtHan.TabIndex = 15;
            // 
            // dtMuon
            // 
            this.dtMuon.Location = new System.Drawing.Point(589, 43);
            this.dtMuon.Name = "dtMuon";
            this.dtMuon.Size = new System.Drawing.Size(114, 20);
            this.dtMuon.TabIndex = 14;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(117, 44);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(164, 21);
            this.cbMaDG.TabIndex = 13;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(117, 136);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(164, 20);
            this.txtSL.TabIndex = 12;
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(117, 88);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(164, 20);
            this.txtMaS.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(446, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ngày mượn sách";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hạn trả sách";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(446, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ngày trả sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Số lượng mượn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã độc giả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btChoMuon;
        private System.Windows.Forms.Button btMuonMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChonMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvDanhSach;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.ComboBox cbMaDocGia;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.DateTimePicker dtHan;
        private System.Windows.Forms.DateTimePicker dtMuon;
    }
}

