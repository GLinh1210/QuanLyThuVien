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
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDG = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Location = new System.Drawing.Point(136, 112);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(154, 94);
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
            this.btnDG.Location = new System.Drawing.Point(574, 267);
            this.btnDG.Name = "btnDG";
            this.btnDG.Size = new System.Drawing.Size(154, 94);
            this.btnDG.TabIndex = 1;
            this.btnDG.Text = "Quản Lý Độc Giả";
            this.btnDG.UseVisualStyleBackColor = false;
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.Location = new System.Drawing.Point(341, 267);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(154, 94);
            this.btnMuon.TabIndex = 2;
            this.btnMuon.Text = "Quản Lý Mượn Sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(793, 100);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(154, 94);
            this.btnTra.TabIndex = 3;
            this.btnTra.Text = "Quản Lý Trả Sách";
            this.btnTra.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = global::QuanLyThuVien.Properties.Resources.public_cart_button_03_hi;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(458, 389);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 66);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources._1_3oNgt5C2JC5FucjUm2SPxg_696x464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.btnDG);
            this.Controls.Add(this.btnSach);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDG;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnThoat;
    }
}