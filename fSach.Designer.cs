namespace QuanLyThuVien
{
    partial class fSach
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
            this.dtgSach = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.lbSach = new System.Windows.Forms.Label();
            this.lbTens = new System.Windows.Forms.Label();
            this.lbTacgia = new System.Windows.Forms.Label();
            this.lbTheloai = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.QuanLySach = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nbSL = new System.Windows.Forms.NumericUpDown();
            this.cbTT = new System.Windows.Forms.ComboBox();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.TimSach = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.sACHTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.QuanLySach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).BeginInit();
            this.TimSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSach
            // 
            this.dtgSach.AutoGenerateColumns = false;
            this.dtgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.tacGiaDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn,
            this.nhaXuatBanDataGridViewTextBoxColumn,
            this.giaSachDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dtgSach.DataSource = this.sACHBindingSource;
            this.dtgSach.Location = new System.Drawing.Point(0, 338);
            this.dtgSach.Name = "dtgSach";
            this.dtgSach.RowTemplate.Height = 24;
            this.dtgSach.Size = new System.Drawing.Size(1094, 234);
            this.dtgSach.TabIndex = 0;
            this.dtgSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSach_CellContentClick);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 88;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên Sách";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            // 
            // tacGiaDataGridViewTextBoxColumn
            // 
            this.tacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.HeaderText = "Tác Giả";
            this.tacGiaDataGridViewTextBoxColumn.Name = "tacGiaDataGridViewTextBoxColumn";
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "Thể Loại";
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            // 
            // nhaXuatBanDataGridViewTextBoxColumn
            // 
            this.nhaXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NhaXuatBan";
            this.nhaXuatBanDataGridViewTextBoxColumn.HeaderText = "Nhà Xuất Bản";
            this.nhaXuatBanDataGridViewTextBoxColumn.Name = "nhaXuatBanDataGridViewTextBoxColumn";
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "Giá Sách";
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSach
            // 
            this.lbSach.AutoSize = true;
            this.lbSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSach.Location = new System.Drawing.Point(27, 30);
            this.lbSach.Name = "lbSach";
            this.lbSach.Size = new System.Drawing.Size(85, 20);
            this.lbSach.TabIndex = 1;
            this.lbSach.Text = "Mã Sách: ";
            // 
            // lbTens
            // 
            this.lbTens.AutoSize = true;
            this.lbTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTens.Location = new System.Drawing.Point(23, 77);
            this.lbTens.Name = "lbTens";
            this.lbTens.Size = new System.Drawing.Size(90, 20);
            this.lbTens.TabIndex = 2;
            this.lbTens.Text = "Tên Sách: ";
            // 
            // lbTacgia
            // 
            this.lbTacgia.AutoSize = true;
            this.lbTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacgia.Location = new System.Drawing.Point(27, 211);
            this.lbTacgia.Name = "lbTacgia";
            this.lbTacgia.Size = new System.Drawing.Size(78, 20);
            this.lbTacgia.TabIndex = 3;
            this.lbTacgia.Text = "Tác Giả: ";
            // 
            // lbTheloai
            // 
            this.lbTheloai.AutoSize = true;
            this.lbTheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheloai.Location = new System.Drawing.Point(23, 123);
            this.lbTheloai.Name = "lbTheloai";
            this.lbTheloai.Size = new System.Drawing.Size(84, 20);
            this.lbTheloai.TabIndex = 4;
            this.lbTheloai.Text = "Thể Loại: ";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(3, 169);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(123, 20);
            this.lbNXB.TabIndex = 5;
            this.lbNXB.Text = "Nhà Xuất Bản: ";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(371, 80);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(88, 20);
            this.lbGia.TabIndex = 6;
            this.lbGia.Text = "Giá Sách: ";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(371, 126);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(90, 20);
            this.lbSL.TabIndex = 7;
            this.lbSL.Text = "Số Lượng: ";
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.Location = new System.Drawing.Point(362, 30);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(99, 20);
            this.lbTT.TabIndex = 8;
            this.lbTT.Text = "Tình Trạng: ";
            // 
            // QuanLySach
            // 
            this.QuanLySach.BackColor = System.Drawing.Color.Pink;
            this.QuanLySach.Controls.Add(this.btnXoa);
            this.QuanLySach.Controls.Add(this.btnSua);
            this.QuanLySach.Controls.Add(this.btnThem);
            this.QuanLySach.Controls.Add(this.nbSL);
            this.QuanLySach.Controls.Add(this.cbTT);
            this.QuanLySach.Controls.Add(this.cbTheloai);
            this.QuanLySach.Controls.Add(this.txtTacgia);
            this.QuanLySach.Controls.Add(this.txtNXB);
            this.QuanLySach.Controls.Add(this.txtGia);
            this.QuanLySach.Controls.Add(this.txtTensach);
            this.QuanLySach.Controls.Add(this.txtMasach);
            this.QuanLySach.Controls.Add(this.lbTT);
            this.QuanLySach.Controls.Add(this.lbGia);
            this.QuanLySach.Controls.Add(this.lbSL);
            this.QuanLySach.Controls.Add(this.lbNXB);
            this.QuanLySach.Controls.Add(this.lbTens);
            this.QuanLySach.Controls.Add(this.lbTheloai);
            this.QuanLySach.Controls.Add(this.lbSach);
            this.QuanLySach.Controls.Add(this.lbTacgia);
            this.QuanLySach.Location = new System.Drawing.Point(0, 1);
            this.QuanLySach.Name = "QuanLySach";
            this.QuanLySach.Size = new System.Drawing.Size(685, 331);
            this.QuanLySach.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::QuanLyThuVien.Properties.Resources.trash_full_512;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(466, 258);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 54);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::QuanLyThuVien.Properties.Resources._126794;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(300, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 54);
            this.btnSua.TabIndex = 17;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::QuanLyThuVien.Properties.Resources._1_17259_list_add_clip_art_add_image_button_png;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(132, 258);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 54);
            this.btnThem.TabIndex = 16;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nbSL
            // 
            this.nbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbSL.Location = new System.Drawing.Point(486, 124);
            this.nbSL.Name = "nbSL";
            this.nbSL.Size = new System.Drawing.Size(120, 23);
            this.nbSL.TabIndex = 15;
            // 
            // cbTT
            // 
            this.cbTT.FormattingEnabled = true;
            this.cbTT.Items.AddRange(new object[] {
            "Còn",
            "Hết"});
            this.cbTT.Location = new System.Drawing.Point(486, 30);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(159, 24);
            this.cbTT.TabIndex = 14;
            // 
            // cbTheloai
            // 
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Items.AddRange(new object[] {
            "Kinh Doanh",
            "Lập Trình",
            "Văn Học",
            "Văn Hóa",
            "Xã Hội",
            "Toán Học",
            "Xây Dựng",
            "Du Lịch",
            "Ngân Hàng",
            "Kế Toán",
            "Tài Chính",
            "Tạp Chí",
            "Khóa Luận Tốt Nghiệp",
            "Nghiên Cứu Khoa Học",
            "Tâm Lý",
            "Tiếng Anh"});
            this.cbTheloai.Location = new System.Drawing.Point(132, 122);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(159, 24);
            this.cbTheloai.TabIndex = 13;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacgia.Location = new System.Drawing.Point(132, 211);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(159, 23);
            this.txtTacgia.TabIndex = 12;
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(132, 169);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(159, 23);
            this.txtNXB.TabIndex = 11;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(486, 77);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(159, 23);
            this.txtGia.TabIndex = 10;
            // 
            // txtTensach
            // 
            this.txtTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensach.Location = new System.Drawing.Point(132, 77);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(177, 23);
            this.txtTensach.TabIndex = 9;
            // 
            // txtMasach
            // 
            this.txtMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Location = new System.Drawing.Point(132, 30);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(159, 23);
            this.txtMasach.TabIndex = 0;
            // 
            // TimSach
            // 
            this.TimSach.BackColor = System.Drawing.Color.LavenderBlush;
            this.TimSach.Controls.Add(this.btnTim);
            this.TimSach.Controls.Add(this.label1);
            this.TimSach.Controls.Add(this.txtTim);
            this.TimSach.Controls.Add(this.lbTim);
            this.TimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimSach.Location = new System.Drawing.Point(691, 1);
            this.TimSach.Name = "TimSach";
            this.TimSach.Size = new System.Drawing.Size(394, 331);
            this.TimSach.TabIndex = 9;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackgroundImage = global::QuanLyThuVien.Properties.Resources.Konfest_PNG_JPG_Image_Pic_Photo_Free_Download_Royalty_Unlimited_clip_art_sticker_icons_search_symbol_find_magnifying_glass_64;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(317, 97);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(55, 46);
            this.btnTim.TabIndex = 12;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm Sách ";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(147, 106);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(153, 23);
            this.txtTim.TabIndex = 10;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(17, 104);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(99, 24);
            this.lbTim.TabIndex = 3;
            this.lbTim.Text = "Mã Sách : ";
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // fSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 573);
            this.Controls.Add(this.TimSach);
            this.Controls.Add(this.QuanLySach);
            this.Controls.Add(this.dtgSach);
            this.Name = "fSach";
            this.Text = "fSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSach_FormClosing);
            this.Load += new System.EventHandler(this.fSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.QuanLySach.ResumeLayout(false);
            this.QuanLySach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).EndInit();
            this.TimSach.ResumeLayout(false);
            this.TimSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSach;
        private System.Windows.Forms.Label lbSach;
        private System.Windows.Forms.Label lbTens;
        private System.Windows.Forms.Label lbTacgia;
        private System.Windows.Forms.Label lbTheloai;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Panel QuanLySach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nbSL;
        private System.Windows.Forms.ComboBox cbTT;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Panel TimSach;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}