namespace QuanLyDocGia
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
            this.ChiTiet = new System.Windows.Forms.GroupBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textMaDocGia = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.NamSinh = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.Label();
            this.MaDocGia = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.DanhSachDocGia = new System.Windows.Forms.GroupBox();
            this.listViewDanhSach = new System.Windows.Forms.ListView();
            this.columHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChiTiet.SuspendLayout();
            this.GioiTinh.SuspendLayout();
            this.DanhSachDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChiTiet
            // 
            this.ChiTiet.Controls.Add(this.DateTime);
            this.ChiTiet.Controls.Add(this.textDiaChi);
            this.ChiTiet.Controls.Add(this.textHoTen);
            this.ChiTiet.Controls.Add(this.textMaDocGia);
            this.ChiTiet.Controls.Add(this.GioiTinh);
            this.ChiTiet.Controls.Add(this.label6);
            this.ChiTiet.Controls.Add(this.label5);
            this.ChiTiet.Controls.Add(this.DiaChi);
            this.ChiTiet.Controls.Add(this.NamSinh);
            this.ChiTiet.Controls.Add(this.HoTen);
            this.ChiTiet.Controls.Add(this.MaDocGia);
            this.ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTiet.Location = new System.Drawing.Point(12, 12);
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Size = new System.Drawing.Size(966, 192);
            this.ChiTiet.TabIndex = 0;
            this.ChiTiet.TabStop = false;
            this.ChiTiet.Text = "Chi Tiết Độc Giả";
            this.ChiTiet.Enter += new System.EventHandler(this.ChiTiet_Enter);
            // 
            // DateTime
            // 
            this.DateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime.Location = new System.Drawing.Point(521, 56);
            this.DateTime.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.DateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(214, 29);
            this.DateTime.TabIndex = 3;
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(521, 125);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(215, 29);
            this.textDiaChi.TabIndex = 10;
            this.textDiaChi.TextChanged += new System.EventHandler(this.textDiaChi_TextChanged);
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(134, 125);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(215, 29);
            this.textHoTen.TabIndex = 8;
            // 
            // textMaDocGia
            // 
            this.textMaDocGia.Location = new System.Drawing.Point(134, 57);
            this.textMaDocGia.Name = "textMaDocGia";
            this.textMaDocGia.Size = new System.Drawing.Size(215, 29);
            this.textMaDocGia.TabIndex = 7;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Controls.Add(this.radNu);
            this.GioiTinh.Controls.Add(this.radNam);
            this.GioiTinh.Location = new System.Drawing.Point(765, 39);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(169, 123);
            this.GioiTinh.TabIndex = 6;
            this.GioiTinh.TabStop = false;
            this.GioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(36, 69);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(59, 29);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(36, 35);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(77, 29);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.Location = new System.Drawing.Point(433, 131);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(64, 20);
            this.DiaChi.TabIndex = 3;
            this.DiaChi.Text = "Địa Chỉ:";
            // 
            // NamSinh
            // 
            this.NamSinh.AutoSize = true;
            this.NamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamSinh.Location = new System.Drawing.Point(433, 57);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(82, 20);
            this.NamSinh.TabIndex = 2;
            this.NamSinh.Text = "Năm Sinh:";
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.Location = new System.Drawing.Point(13, 125);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(65, 20);
            this.HoTen.TabIndex = 1;
            this.HoTen.Text = "Họ Tên:";
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSize = true;
            this.MaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGia.Location = new System.Drawing.Point(13, 57);
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Size = new System.Drawing.Size(97, 20);
            this.MaDocGia.TabIndex = 0;
            this.MaDocGia.Text = "Mã Độc Giả:";
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(29, 224);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(70, 40);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(29, 270);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(70, 40);
            this.Sua.TabIndex = 2;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(29, 316);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(70, 40);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // Luu
            // 
            this.Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luu.Location = new System.Drawing.Point(29, 362);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(70, 40);
            this.Luu.TabIndex = 4;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(29, 409);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(70, 40);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DanhSachDocGia
            // 
            this.DanhSachDocGia.Controls.Add(this.listViewDanhSach);
            this.DanhSachDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachDocGia.Location = new System.Drawing.Point(118, 210);
            this.DanhSachDocGia.Name = "DanhSachDocGia";
            this.DanhSachDocGia.Size = new System.Drawing.Size(860, 267);
            this.DanhSachDocGia.TabIndex = 1;
            this.DanhSachDocGia.TabStop = false;
            this.DanhSachDocGia.Text = "Danh Sách Độc Giả";
            // 
            // listViewDanhSach
            // 
            this.listViewDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columHeader1,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDanhSach.Location = new System.Drawing.Point(16, 28);
            this.listViewDanhSach.Name = "listViewDanhSach";
            this.listViewDanhSach.Size = new System.Drawing.Size(825, 207);
            this.listViewDanhSach.TabIndex = 0;
            this.listViewDanhSach.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // columHeader1
            // 
            this.columHeader1.Text = "Mã Độc Giả";
            this.columHeader1.Width = 168;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giới Tính";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm Sinh";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.Width = 203;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DanhSachDocGia);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.ChiTiet);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1009, 489);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChiTiet.ResumeLayout(false);
            this.ChiTiet.PerformLayout();
            this.GioiTinh.ResumeLayout(false);
            this.GioiTinh.PerformLayout();
            this.DanhSachDocGia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChiTiet;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textMaDocGia;
        private System.Windows.Forms.GroupBox GioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label NamSinh;
        private System.Windows.Forms.Label HoTen;
        private System.Windows.Forms.Label MaDocGia;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.GroupBox DanhSachDocGia;
        private System.Windows.Forms.ListView listViewDanhSach;
        private System.Windows.Forms.ColumnHeader columHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker DateTime;
    }
}

