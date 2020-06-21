namespace QuanLyThuVien
{
    partial class QLDG
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
            this.components = new System.ComponentModel.Container();
            this.dtgDG = new System.Windows.Forms.DataGridView();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTDG = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtMDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dOCGIATableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDG
            // 
            this.dtgDG.AutoGenerateColumns = false;
            this.dtgDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDG.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDocGiaDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.namSinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.dtgDG.DataSource = this.dOCGIABindingSource;
            this.dtgDG.Location = new System.Drawing.Point(-1, 369);
            this.dtgDG.Name = "dtgDG";
            this.dtgDG.RowTemplate.Height = 24;
            this.dtgDG.Size = new System.Drawing.Size(1054, 240);
            this.dtgDG.TabIndex = 0;
            this.dtgDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDG_CellContentClick);
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã Độc Giả";
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên Đăng Nhập";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            this.namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            this.namSinhDataGridViewTextBoxColumn.HeaderText = "Năm Sinh";
            this.namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnTDG);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.dtNS);
            this.panel1.Controls.Add(this.rbtnNu);
            this.panel1.Controls.Add(this.rbtnNam);
            this.panel1.Controls.Add(this.txtHT);
            this.panel1.Controls.Add(this.txtTDN);
            this.panel1.Controls.Add(this.txtMDG);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 363);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quản Lý Thông Tin Độc Giả";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyThuVien.Properties.Resources.trash_full_512;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(526, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 68);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyThuVien.Properties.Resources._126794;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(526, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 67);
            this.btnSua.TabIndex = 19;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTDG
            // 
            this.btnTDG.BackgroundImage = global::QuanLyThuVien.Properties.Resources._1_17259_list_add_clip_art_add_image_button_png;
            this.btnTDG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTDG.Location = new System.Drawing.Point(526, 68);
            this.btnTDG.Name = "btnTDG";
            this.btnTDG.Size = new System.Drawing.Size(77, 68);
            this.btnTDG.TabIndex = 18;
            this.btnTDG.UseVisualStyleBackColor = true;
            this.btnTDG.Click += new System.EventHandler(this.btnTDG_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(221, 297);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 26);
            this.txtDiaChi.TabIndex = 17;
            // 
            // dtNS
            // 
            this.dtNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNS.Location = new System.Drawing.Point(221, 253);
            this.dtNS.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(200, 26);
            this.dtNS.TabIndex = 16;
            this.dtNS.Value = new System.DateTime(2020, 6, 19, 0, 0, 0, 0);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.Location = new System.Drawing.Point(325, 209);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(51, 24);
            this.rbtnNu.TabIndex = 15;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.Location = new System.Drawing.Point(221, 207);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(65, 24);
            this.rbtnNam.TabIndex = 14;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtHT
            // 
            this.txtHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHT.Location = new System.Drawing.Point(221, 110);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(200, 26);
            this.txtHT.TabIndex = 11;
            // 
            // txtTDN
            // 
            this.txtTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.Location = new System.Drawing.Point(221, 159);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(200, 26);
            this.txtTDN.TabIndex = 10;
            // 
            // txtMDG
            // 
            this.txtMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDG.Location = new System.Drawing.Point(221, 62);
            this.txtMDG.Name = "txtMDG";
            this.txtMDG.Size = new System.Drawing.Size(200, 26);
            this.txtMDG.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Độc Giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(692, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 363);
            this.panel2.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QuanLyThuVien.Properties.Resources.Konfest_PNG_JPG_Image_Pic_Photo_Free_Download_Royalty_Unlimited_clip_art_sticker_icons_search_symbol_find_magnifying_glass_641;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(212, 159);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 50);
            this.btnTim.TabIndex = 12;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(139, 107);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(200, 26);
            this.txtTim.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã Độc Giả";
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // QLDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1054, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgDG);
            this.Name = "QLDG";
            this.Text = "QLDG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLDG_FormClosing);
            this.Load += new System.EventHandler(this.QLDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTDG;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtMDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label7;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
    }
}