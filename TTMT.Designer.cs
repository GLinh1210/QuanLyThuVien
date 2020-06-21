namespace QuanLyThuVien
{
    partial class TTMT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayPhaiTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maPhieuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pHIEUMUONTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter();
            this.pHIEUTRATableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.maDocGiaDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayPhaiTraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHIEUMUONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã Độc Giả";
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày Mượn";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            // 
            // ngayPhaiTraDataGridViewTextBoxColumn
            // 
            this.ngayPhaiTraDataGridViewTextBoxColumn.DataPropertyName = "NgayPhaiTra";
            this.ngayPhaiTraDataGridViewTextBoxColumn.HeaderText = "Ngày Phải Trả";
            this.ngayPhaiTraDataGridViewTextBoxColumn.Name = "ngayPhaiTraDataGridViewTextBoxColumn";
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn1,
            this.maDocGiaDataGridViewTextBoxColumn1,
            this.maSachDataGridViewTextBoxColumn1,
            this.ngayTraDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pHIEUTRABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 316);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(824, 162);
            this.dataGridView2.TabIndex = 1;
            // 
            // maPhieuDataGridViewTextBoxColumn1
            // 
            this.maPhieuDataGridViewTextBoxColumn1.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu";
            this.maPhieuDataGridViewTextBoxColumn1.Name = "maPhieuDataGridViewTextBoxColumn1";
            // 
            // maDocGiaDataGridViewTextBoxColumn1
            // 
            this.maDocGiaDataGridViewTextBoxColumn1.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn1.HeaderText = "Mã Độc Giả";
            this.maDocGiaDataGridViewTextBoxColumn1.Name = "maDocGiaDataGridViewTextBoxColumn1";
            // 
            // maSachDataGridViewTextBoxColumn1
            // 
            this.maSachDataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn1.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn1.Name = "maSachDataGridViewTextBoxColumn1";
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày Trả";
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            // 
            // pHIEUTRABindingSource
            // 
            this.pHIEUTRABindingSource.DataMember = "PHIEUTRA";
            this.pHIEUTRABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin phiếu mượn và phiếu trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin phiếu mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin phiếu trả";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = global::QuanLyThuVien.Properties.Resources._31;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(360, 484);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 56);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUTRATableAdapter
            // 
            this.pHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // TTMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(825, 552);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TTMT";
            this.Text = "TTMT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTMT_FormClosing);
            this.Load += new System.EventHandler(this.TTMT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter pHIEUTRATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayPhaiTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
    }
}