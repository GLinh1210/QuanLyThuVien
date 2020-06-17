namespace QuanLyThuVien
{
    partial class TrangChu
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
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDG = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnThaydoi = new System.Windows.Forms.Button();
            this.btnMT = new System.Windows.Forms.Button();
            this.btnTSach = new System.Windows.Forms.Button();
            this.quanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Location = new System.Drawing.Point(158, 278);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(122, 94);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Quản Lý Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDG
            // 
            this.btnDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDG.Location = new System.Drawing.Point(806, 278);
            this.btnDG.Name = "btnDG";
            this.btnDG.Size = new System.Drawing.Size(122, 94);
            this.btnDG.TabIndex = 1;
            this.btnDG.Text = "Quản Lý Độc Giả";
            this.btnDG.UseVisualStyleBackColor = false;
            this.btnDG.Click += new System.EventHandler(this.btnDG_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.Location = new System.Drawing.Point(373, 278);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(122, 94);
            this.btnMuon.TabIndex = 2;
            this.btnMuon.Text = "Quản Lý Mượn Sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(574, 278);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(122, 94);
            this.btnTra.TabIndex = 3;
            this.btnTra.Text = "Quản Lý Trả Sách";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = global::QuanLyThuVien.Properties.Resources.public_cart_button_03_hi;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(462, 477);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 66);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(373, 87);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(122, 94);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnThaydoi
            // 
            this.btnThaydoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThaydoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThaydoi.Location = new System.Drawing.Point(574, 87);
            this.btnThaydoi.Name = "btnThaydoi";
            this.btnThaydoi.Size = new System.Drawing.Size(122, 94);
            this.btnThaydoi.TabIndex = 6;
            this.btnThaydoi.Text = "Thay đổi thông tin";
            this.btnThaydoi.UseVisualStyleBackColor = false;
            this.btnThaydoi.Click += new System.EventHandler(this.btnThaydoi_Click);
            // 
            // btnMT
            // 
            this.btnMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMT.Location = new System.Drawing.Point(806, 87);
            this.btnMT.Name = "btnMT";
            this.btnMT.Size = new System.Drawing.Size(122, 94);
            this.btnMT.TabIndex = 7;
            this.btnMT.Text = "Thông tin mượn trả";
            this.btnMT.UseVisualStyleBackColor = false;
            this.btnMT.Click += new System.EventHandler(this.btnMT_Click);
            // 
            // btnTSach
            // 
            this.btnTSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSach.Location = new System.Drawing.Point(158, 87);
            this.btnTSach.Name = "btnTSach";
            this.btnTSach.Size = new System.Drawing.Size(122, 94);
            this.btnTSach.TabIndex = 8;
            this.btnTSach.Text = "Tra cứu sách";
            this.btnTSach.UseVisualStyleBackColor = false;
            this.btnTSach.Click += new System.EventHandler(this.btnTSach_Click);
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
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources._1_3oNgt5C2JC5FucjUm2SPxg_696x464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.btnTSach);
            this.Controls.Add(this.btnMT);
            this.Controls.Add(this.btnThaydoi);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.btnDG);
            this.Controls.Add(this.btnSach);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDG;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnThaydoi;
        private System.Windows.Forms.Button btnMT;
        private System.Windows.Forms.Button btnTSach;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
    }
}