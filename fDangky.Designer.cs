﻿namespace QuanLyThuVien
{
    partial class fDangky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDK1 = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTendn = new System.Windows.Forms.TextBox();
            this.DTNamsinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenDG = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDK1
            // 
            this.btnDK1.Location = new System.Drawing.Point(32, 480);
            this.btnDK1.Name = "btnDK1";
            this.btnDK1.Size = new System.Drawing.Size(165, 70);
            this.btnDK1.TabIndex = 6;
            this.btnDK1.Text = "Đăng ký";
            this.btnDK1.UseVisualStyleBackColor = true;
            this.btnDK1.Click += new System.EventHandler(this.btnDK1_Click);
            // 
            // btnThoat1
            // 
            this.btnThoat1.Location = new System.Drawing.Point(529, 480);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(165, 70);
            this.btnThoat1.TabIndex = 7;
            this.btnThoat1.Text = "Quay Lại";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtTendn);
            this.panel2.Controls.Add(this.DTNamsinh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rbtnNu);
            this.panel2.Controls.Add(this.rbtnNam);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txthoten);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTenDG);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 445);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Đăng Nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(228, 183);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(281, 30);
            this.txtPass.TabIndex = 18;
            // 
            // txtTendn
            // 
            this.txtTendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendn.Location = new System.Drawing.Point(228, 126);
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.Size = new System.Drawing.Size(281, 28);
            this.txtTendn.TabIndex = 17;
            // 
            // DTNamsinh
            // 
            this.DTNamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNamsinh.Location = new System.Drawing.Point(228, 307);
            this.DTNamsinh.MaxDate = new System.DateTime(2020, 6, 8, 16, 23, 38, 0);
            this.DTNamsinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTNamsinh.Name = "DTNamsinh";
            this.DTNamsinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTNamsinh.Size = new System.Drawing.Size(281, 28);
            this.DTNamsinh.TabIndex = 16;
            this.DTNamsinh.TabStop = false;
            this.DTNamsinh.UseWaitCursor = true;
            this.DTNamsinh.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(187, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 49);
            this.label6.TabIndex = 15;
            this.label6.Text = "Điền form đăng ký";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(333, 377);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(58, 29);
            this.rbtnNu.TabIndex = 14;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(228, 377);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(74, 29);
            this.rbtnNam.TabIndex = 13;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(228, 248);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(281, 26);
            this.txtDiachi.TabIndex = 9;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(228, 68);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(281, 26);
            this.txthoten.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm sinh: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenDG
            // 
            this.lbTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDG.Location = new System.Drawing.Point(42, 68);
            this.lbTenDG.Name = "lbTenDG";
            this.lbTenDG.Size = new System.Drawing.Size(130, 36);
            this.lbTenDG.TabIndex = 0;
            this.lbTenDG.Text = "Họ và Tên:";
            this.lbTenDG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.btnDK1);
            this.Name = "fDangky";
            this.Text = "fDangky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangky_FormClosing);
            this.Load += new System.EventHandler(this.fDangky_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDK1;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenDG;
        private System.Windows.Forms.DateTimePicker DTNamsinh;
        private System.Windows.Forms.TextBox txtTendn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}