namespace QuanLyThuVien
{
    partial class SuaThongTin
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
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.textMDG = new System.Windows.Forms.ComboBox();
            this.textTDN = new System.Windows.Forms.ComboBox();
            this.textTDG = new System.Windows.Forms.ComboBox();
            this.textDiaChi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(78, 318);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(103, 30);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(250, 318);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(103, 30);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.button3_Click);
            // 
            // textMDG
            // 
            this.textMDG.FormattingEnabled = true;
            this.textMDG.Location = new System.Drawing.Point(166, 36);
            this.textMDG.Name = "textMDG";
            this.textMDG.Size = new System.Drawing.Size(203, 24);
            this.textMDG.TabIndex = 3;
            // 
            // textTDN
            // 
            this.textTDN.FormattingEnabled = true;
            this.textTDN.Location = new System.Drawing.Point(166, 76);
            this.textTDN.Name = "textTDN";
            this.textTDN.Size = new System.Drawing.Size(203, 24);
            this.textTDN.TabIndex = 4;
            // 
            // textTDG
            // 
            this.textTDG.FormattingEnabled = true;
            this.textTDG.Location = new System.Drawing.Point(166, 120);
            this.textTDG.Name = "textTDG";
            this.textTDG.Size = new System.Drawing.Size(203, 24);
            this.textTDG.TabIndex = 5;
            // 
            // textDiaChi
            // 
            this.textDiaChi.FormattingEnabled = true;
            this.textDiaChi.Location = new System.Drawing.Point(166, 235);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(203, 24);
            this.textDiaChi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Năm Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Độc Giả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.dateTimeNS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textMDG);
            this.groupBox1.Controls.Add(this.textTDN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textTDG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textDiaChi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 284);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Thông Tin";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(282, 159);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 20);
            this.radNu.TabIndex = 20;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(180, 159);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(59, 20);
            this.radNam.TabIndex = 19;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dateTimeNS
            // 
            this.dateTimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNS.Location = new System.Drawing.Point(166, 194);
            this.dateTimeNS.Name = "dateTimeNS";
            this.dateTimeNS.Size = new System.Drawing.Size(202, 22);
            this.dateTimeNS.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa Chỉ:";
            // 
            // SuaThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(453, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Name = "SuaThongTin";
            this.Text = "Quản Lý Thông Tin";
            this.Load += new System.EventHandler(this.SuaThongTin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ComboBox textMDG;
        private System.Windows.Forms.ComboBox textTDN;
        private System.Windows.Forms.ComboBox textTDG;
        private System.Windows.Forms.ComboBox textDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dateTimeNS;
    }
}