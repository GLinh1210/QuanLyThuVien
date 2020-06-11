namespace QuanLyThuVien
{
    partial class PhieuMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaPhieu = new System.Windows.Forms.TextBox();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.BtXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtThem = new System.Windows.Forms.Button();
            this.BtCapNhat = new System.Windows.Forms.Button();
            this.BtNhapLai = new System.Windows.Forms.Button();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.BtSua = new System.Windows.Forms.Button();
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.SACHTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã độc giả";
            // 
            // TxtMaPhieu
            // 
            this.TxtMaPhieu.Location = new System.Drawing.Point(109, 31);
            this.TxtMaPhieu.Name = "TxtMaPhieu";
            this.TxtMaPhieu.Size = new System.Drawing.Size(165, 20);
            this.TxtMaPhieu.TabIndex = 6;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Location = new System.Drawing.Point(114, 160);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(159, 20);
            this.dtNgayMuon.TabIndex = 10;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(115, 202);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(159, 20);
            this.dtNgayTra.TabIndex = 11;
            // 
            // BtXoa
            // 
            this.BtXoa.Location = new System.Drawing.Point(523, 138);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(117, 51);
            this.BtXoa.TabIndex = 14;
            this.BtXoa.Text = "Xóa";
            this.BtXoa.UseVisualStyleBackColor = true;
            this.BtXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 178);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 146);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BtThem
            // 
            this.BtThem.Location = new System.Drawing.Point(521, 33);
            this.BtThem.Name = "BtThem";
            this.BtThem.Size = new System.Drawing.Size(119, 59);
            this.BtThem.TabIndex = 16;
            this.BtThem.Text = "Thêm";
            this.BtThem.UseVisualStyleBackColor = true;
            this.BtThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // BtCapNhat
            // 
            this.BtCapNhat.Location = new System.Drawing.Point(360, 138);
            this.BtCapNhat.Name = "BtCapNhat";
            this.BtCapNhat.Size = new System.Drawing.Size(117, 51);
            this.BtCapNhat.TabIndex = 17;
            this.BtCapNhat.Text = "Cập nhật";
            this.BtCapNhat.UseVisualStyleBackColor = true;
            this.BtCapNhat.Click += new System.EventHandler(this.BtCapNhat_Click);
            // 
            // BtNhapLai
            // 
            this.BtNhapLai.Location = new System.Drawing.Point(360, 37);
            this.BtNhapLai.Name = "BtNhapLai";
            this.BtNhapLai.Size = new System.Drawing.Size(117, 51);
            this.BtNhapLai.TabIndex = 18;
            this.BtNhapLai.Text = "Nhập lại";
            this.BtNhapLai.UseVisualStyleBackColor = true;
            this.BtNhapLai.Click += new System.EventHandler(this.BtNhapLai_Click);
            // 
            // cbMaDG
            // 
            this.cbMaDG.DataSource = this.dOCGIABindingSource;
            this.cbMaDG.DisplayMember = "MaDocGia";
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(109, 72);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(162, 21);
            this.cbMaDG.TabIndex = 19;
            this.cbMaDG.ValueMember = "MaDocGia";
            // 
            // cbMaSach
            // 
            this.cbMaSach.DataSource = this.sACHBindingSource;
            this.cbMaSach.DisplayMember = "MaSach";
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(112, 112);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(162, 21);
            this.cbMaSach.TabIndex = 20;
            this.cbMaSach.ValueMember = "MaSach";
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(434, 202);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(119, 59);
            this.BtSua.TabIndex = 21;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.cbMaSach);
            this.Controls.Add(this.cbMaDG);
            this.Controls.Add(this.BtNhapLai);
            this.Controls.Add(this.BtCapNhat);
            this.Controls.Add(this.BtThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtXoa);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.TxtMaPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.Load += new System.EventHandler(this.PhieuMuon_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtThem;
        private System.Windows.Forms.Button BtCapNhat;
        private System.Windows.Forms.Button BtNhapLai;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Button BtSua;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}