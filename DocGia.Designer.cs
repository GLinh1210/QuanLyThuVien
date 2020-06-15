namespace QuanLyThuVien
{
    partial class DocGia
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
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.grbDocGia = new System.Windows.Forms.GroupBox();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.textTenDangNhap = new System.Windows.Forms.TextBox();
            this.textMaCanTim = new System.Windows.Forms.TextBox();
            this.DateTimeNamSinh = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textTenDocGia = new System.Windows.Forms.TextBox();
            this.textMaDocGia = new System.Windows.Forms.TextBox();
            this.NamSinh = new System.Windows.Forms.Label();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.GioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.TimDocGia = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.TenDocGia = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.MaDocGia = new System.Windows.Forms.Label();
            this.dOCGIATableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.grbDocGia.SuspendLayout();
            this.GioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dataGridView1);
            this.grbDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSach.Location = new System.Drawing.Point(34, 260);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(853, 229);
            this.grbDanhSach.TabIndex = 9;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh Sách Độc Giả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDocGiaDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.namSinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCGIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // grbDocGia
            // 
            this.grbDocGia.Controls.Add(this.lbTenDangNhap);
            this.grbDocGia.Controls.Add(this.textTenDangNhap);
            this.grbDocGia.Controls.Add(this.textMaCanTim);
            this.grbDocGia.Controls.Add(this.DateTimeNamSinh);
            this.grbDocGia.Controls.Add(this.button1);
            this.grbDocGia.Controls.Add(this.label1);
            this.grbDocGia.Controls.Add(this.textDiaChi);
            this.grbDocGia.Controls.Add(this.textTenDocGia);
            this.grbDocGia.Controls.Add(this.textMaDocGia);
            this.grbDocGia.Controls.Add(this.NamSinh);
            this.grbDocGia.Controls.Add(this.Sua);
            this.grbDocGia.Controls.Add(this.Xoa);
            this.grbDocGia.Controls.Add(this.GioiTinh);
            this.grbDocGia.Controls.Add(this.TimDocGia);
            this.grbDocGia.Controls.Add(this.DiaChi);
            this.grbDocGia.Controls.Add(this.TenDocGia);
            this.grbDocGia.Controls.Add(this.Them);
            this.grbDocGia.Controls.Add(this.MaDocGia);
            this.grbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDocGia.Location = new System.Drawing.Point(34, 12);
            this.grbDocGia.Name = "grbDocGia";
            this.grbDocGia.Size = new System.Drawing.Size(853, 242);
            this.grbDocGia.TabIndex = 8;
            this.grbDocGia.TabStop = false;
            this.grbDocGia.Text = "Chi Tiết Độc Giả";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(24, 81);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(65, 20);
            this.lbTenDangNhap.TabIndex = 16;
            this.lbTenDangNhap.Text = "Họ Tên:";
            // 
            // textTenDangNhap
            // 
            this.textTenDangNhap.Location = new System.Drawing.Point(142, 74);
            this.textTenDangNhap.Name = "textTenDangNhap";
            this.textTenDangNhap.Size = new System.Drawing.Size(227, 26);
            this.textTenDangNhap.TabIndex = 15;
            // 
            // textMaCanTim
            // 
            this.textMaCanTim.Location = new System.Drawing.Point(548, 42);
            this.textMaCanTim.Name = "textMaCanTim";
            this.textMaCanTim.Size = new System.Drawing.Size(200, 26);
            this.textMaCanTim.TabIndex = 14;
            // 
            // DateTimeNamSinh
            // 
            this.DateTimeNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeNamSinh.Location = new System.Drawing.Point(142, 155);
            this.DateTimeNamSinh.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.DateTimeNamSinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.DateTimeNamSinh.Name = "DateTimeNamSinh";
            this.DateTimeNamSinh.Size = new System.Drawing.Size(227, 26);
            this.DateTimeNamSinh.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(766, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(649, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lỗi nhập sai";
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(142, 196);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(227, 26);
            this.textDiaChi.TabIndex = 9;
            // 
            // textTenDocGia
            // 
            this.textTenDocGia.Location = new System.Drawing.Point(142, 114);
            this.textTenDocGia.Name = "textTenDocGia";
            this.textTenDocGia.Size = new System.Drawing.Size(227, 26);
            this.textTenDocGia.TabIndex = 7;
            // 
            // textMaDocGia
            // 
            this.textMaDocGia.Location = new System.Drawing.Point(142, 36);
            this.textMaDocGia.Name = "textMaDocGia";
            this.textMaDocGia.Size = new System.Drawing.Size(226, 26);
            this.textMaDocGia.TabIndex = 6;
            // 
            // NamSinh
            // 
            this.NamSinh.AutoSize = true;
            this.NamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamSinh.Location = new System.Drawing.Point(24, 158);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(82, 20);
            this.NamSinh.TabIndex = 5;
            this.NamSinh.Text = "Năm Sinh:";
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(716, 127);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(68, 29);
            this.Sua.TabIndex = 1;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(664, 174);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(68, 29);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // GioiTinh
            // 
            this.GioiTinh.Controls.Add(this.radNu);
            this.GioiTinh.Controls.Add(this.radNam);
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.Location = new System.Drawing.Point(449, 121);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(116, 94);
            this.GioiTinh.TabIndex = 4;
            this.GioiTinh.TabStop = false;
            this.GioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(25, 56);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 24);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(25, 28);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(60, 24);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // TimDocGia
            // 
            this.TimDocGia.AutoSize = true;
            this.TimDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimDocGia.Location = new System.Drawing.Point(403, 49);
            this.TimDocGia.Name = "TimDocGia";
            this.TimDocGia.Size = new System.Drawing.Size(139, 20);
            this.TimDocGia.TabIndex = 3;
            this.TimDocGia.Text = "Nhập Mã Độc Giả:";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.Location = new System.Drawing.Point(25, 197);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(64, 20);
            this.DiaChi.TabIndex = 2;
            this.DiaChi.Text = "Địa Chỉ:";
            // 
            // TenDocGia
            // 
            this.TenDocGia.AutoSize = true;
            this.TenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDocGia.Location = new System.Drawing.Point(23, 120);
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.Size = new System.Drawing.Size(102, 20);
            this.TenDocGia.TabIndex = 1;
            this.TenDocGia.Text = "Tên Độc Giả:";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(610, 127);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(68, 29);
            this.Them.TabIndex = 2;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSize = true;
            this.MaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGia.Location = new System.Drawing.Point(24, 42);
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Size = new System.Drawing.Size(97, 20);
            this.MaDocGia.TabIndex = 0;
            this.MaDocGia.Text = "Mã Độc Giả:";
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            this.namSinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            this.namSinhDataGridViewTextBoxColumn.HeaderText = "NamSinh";
            this.namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            this.namSinhDataGridViewTextBoxColumn.Width = 106;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(920, 501);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbDocGia);
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocGia_FormClosing);
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.grbDocGia.ResumeLayout(false);
            this.grbDocGia.PerformLayout();
            this.GioiTinh.ResumeLayout(false);
            this.GioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbDocGia;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.TextBox textTenDangNhap;
        private System.Windows.Forms.TextBox textMaCanTim;
        private System.Windows.Forms.DateTimePicker DateTimeNamSinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.TextBox textTenDocGia;
        private System.Windows.Forms.TextBox textMaDocGia;
        private System.Windows.Forms.Label NamSinh;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.GroupBox GioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label TimDocGia;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label TenDocGia;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label MaDocGia;
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