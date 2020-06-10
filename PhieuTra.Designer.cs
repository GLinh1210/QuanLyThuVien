namespace QuanLyThuVien
{
    partial class PhieuTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.BtXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtThem = new System.Windows.Forms.Button();
            this.BtCapNhat = new System.Windows.Forms.Button();
            this.BtNhapLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày trả";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(134, 33);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(160, 20);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(134, 92);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(160, 20);
            this.txtMaDG.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(134, 134);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(160, 20);
            this.txtMaSach.TabIndex = 6;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(135, 183);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(158, 20);
            this.dtNgayTra.TabIndex = 7;
            // 
            // BtXoa
            // 
            this.BtXoa.Location = new System.Drawing.Point(474, 154);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(136, 49);
            this.BtXoa.TabIndex = 10;
            this.BtXoa.Text = "Xóa";
            this.BtXoa.UseVisualStyleBackColor = true;
            this.BtXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(731, 97);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // BtThem
            // 
            this.BtThem.Location = new System.Drawing.Point(474, 81);
            this.BtThem.Name = "BtThem";
            this.BtThem.Size = new System.Drawing.Size(136, 49);
            this.BtThem.TabIndex = 12;
            this.BtThem.Text = "Thêm";
            this.BtThem.UseVisualStyleBackColor = true;
            this.BtThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // BtCapNhat
            // 
            this.BtCapNhat.Location = new System.Drawing.Point(323, 154);
            this.BtCapNhat.Name = "BtCapNhat";
            this.BtCapNhat.Size = new System.Drawing.Size(136, 49);
            this.BtCapNhat.TabIndex = 13;
            this.BtCapNhat.Text = "Cập nhật";
            this.BtCapNhat.UseVisualStyleBackColor = true;
            this.BtCapNhat.Click += new System.EventHandler(this.BtCapNhat_Click);
            // 
            // BtNhapLai
            // 
            this.BtNhapLai.Location = new System.Drawing.Point(323, 81);
            this.BtNhapLai.Name = "BtNhapLai";
            this.BtNhapLai.Size = new System.Drawing.Size(136, 49);
            this.BtNhapLai.TabIndex = 14;
            this.BtNhapLai.Text = "Nhập lại";
            this.BtNhapLai.UseVisualStyleBackColor = true;
            this.BtNhapLai.Click += new System.EventHandler(this.BtNhapLai_Click);
            // 
            // PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtNhapLai);
            this.Controls.Add(this.BtCapNhat);
            this.Controls.Add(this.BtThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtXoa);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuTra";
            this.Text = "PhieuTra";
            this.Load += new System.EventHandler(this.PhieuTra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtThem;
        private System.Windows.Forms.Button BtCapNhat;
        private System.Windows.Forms.Button BtNhapLai;
    }
}