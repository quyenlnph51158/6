﻿namespace GUI
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTongSoLuong = new TextBox();
            label12 = new Label();
            txtTongDauSach = new TextBox();
            dgvquanlynv = new DataGridView();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnXoa = new Button();
            label10 = new Label();
            txtVitri = new TextBox();
            cbbTrangThaiSach = new ComboBox();
            label9 = new Label();
            dtpNgayXuatBan = new DateTimePicker();
            label4 = new Label();
            txtSoLuong = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            ccbtacgia = new ComboBox();
            label1 = new Label();
            cbbnxb = new ComboBox();
            label2 = new Label();
            ccbtheloai = new ComboBox();
            laba = new Label();
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            label5 = new Label();
            btnhienthi = new Button();
            label6 = new Label();
            label7 = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            btnsua = new Button();
            txtGiaSach = new TextBox();
            btnthem = new Button();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTongSoLuong
            // 
            txtTongSoLuong.Location = new Point(525, 21);
            txtTongSoLuong.Name = "txtTongSoLuong";
            txtTongSoLuong.Size = new Size(139, 27);
            txtTongSoLuong.TabIndex = 131;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(356, 24);
            label12.Name = "label12";
            label12.Size = new Size(145, 20);
            label12.TabIndex = 130;
            label12.Text = "Tổng số lượng sách";
            // 
            // txtTongDauSach
            // 
            txtTongDauSach.Location = new Point(151, 21);
            txtTongDauSach.Name = "txtTongDauSach";
            txtTongDauSach.Size = new Size(139, 27);
            txtTongDauSach.TabIndex = 129;
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(6, 221);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(813, 394);
            dgvquanlynv.TabIndex = 127;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSoLuong);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtTongDauSach);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(dgvquanlynv);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(734, 148);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(825, 626);
            groupBox3.TabIndex = 120;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Sách";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(35, 24);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 128;
            label11.Text = "Tổng đầu sách";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(151, 96);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Sách";
            txtTimKiem.Size = new Size(552, 27);
            txtTimKiem.TabIndex = 111;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 99);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 110;
            label8.Text = "Tìm Kiếm ";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 128);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(511, 522);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 124;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(26, 334);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 122;
            label10.Text = "Vị Trí";
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(143, 331);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(479, 27);
            txtVitri.TabIndex = 123;
            // 
            // cbbTrangThaiSach
            // 
            cbbTrangThaiSach.FormattingEnabled = true;
            cbbTrangThaiSach.Location = new Point(143, 297);
            cbbTrangThaiSach.Name = "cbbTrangThaiSach";
            cbbTrangThaiSach.Size = new Size(476, 28);
            cbbTrangThaiSach.TabIndex = 121;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(29, 300);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 120;
            label9.Text = "Trạng Thái";
            // 
            // dtpNgayXuatBan
            // 
            dtpNgayXuatBan.Location = new Point(143, 219);
            dtpNgayXuatBan.Name = "dtpNgayXuatBan";
            dtpNgayXuatBan.Size = new Size(254, 27);
            dtpNgayXuatBan.TabIndex = 119;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 255);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 117;
            label4.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(143, 252);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(479, 27);
            txtSoLuong.TabIndex = 118;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtVitri);
            groupBox2.Controls.Add(cbbTrangThaiSach);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpNgayXuatBan);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ccbtacgia);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbbnxb);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(ccbtheloai);
            groupBox2.Controls.Add(laba);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnhienthi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtMaSach);
            groupBox2.Controls.Add(txtTenSach);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(txtGiaSach);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Location = new Point(5, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 620);
            groupBox2.TabIndex = 119;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 96);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 98;
            label3.Text = "Mã Thể Loại ";
            // 
            // ccbtacgia
            // 
            ccbtacgia.FormattingEnabled = true;
            ccbtacgia.Location = new Point(143, 54);
            ccbtacgia.Name = "ccbtacgia";
            ccbtacgia.Size = new Size(479, 28);
            ccbtacgia.TabIndex = 116;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 96;
            label1.Text = "Mã Sách ";
            // 
            // cbbnxb
            // 
            cbbnxb.FormattingEnabled = true;
            cbbnxb.Location = new Point(143, 121);
            cbbnxb.Name = "cbbnxb";
            cbbnxb.Size = new Size(479, 28);
            cbbnxb.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 97;
            label2.Text = "Mã Tác Giả";
            // 
            // ccbtheloai
            // 
            ccbtheloai.FormattingEnabled = true;
            ccbtheloai.Location = new Point(143, 88);
            ccbtheloai.Name = "ccbtheloai";
            ccbtheloai.Size = new Size(479, 28);
            ccbtheloai.TabIndex = 115;
            // 
            // laba
            // 
            laba.AutoSize = true;
            laba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            laba.Location = new Point(26, 195);
            laba.Name = "laba";
            laba.Size = new Size(68, 20);
            laba.TabIndex = 99;
            laba.Text = "Giá Sách";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(25, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 90);
            groupBox1.TabIndex = 113;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mô Tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(4, 26);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(590, 58);
            txtMoTa.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 158);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 100;
            label5.Text = "Tên Sách";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(20, 522);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 112;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 129);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 101;
            label6.Text = "Mã NXB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(26, 224);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 102;
            label7.Text = "Ngày Xuất Bản";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(143, 21);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(479, 27);
            txtMaSach.TabIndex = 103;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(143, 155);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(479, 27);
            txtTenSach.TabIndex = 104;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(337, 522);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 108;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // txtGiaSach
            // 
            txtGiaSach.Location = new Point(143, 188);
            txtGiaSach.Name = "txtGiaSach";
            txtGiaSach.Size = new Size(479, 27);
            txtGiaSach.TabIndex = 105;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(170, 522);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 107;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(622, 17);
            label13.Name = "label13";
            label13.Size = new Size(192, 38);
            label13.TabIndex = 132;
            label13.Text = "Quản Lý Sách";
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "QuanLySach";
            Size = new Size(1562, 777);
            Load += QuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTongSoLuong;
        private Label label12;
        private TextBox txtTongDauSach;
        private DataGridView dgvquanlynv;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox txtTimKiem;
        private Label label8;
        private Button btnXoa;
        private Label label10;
        private TextBox txtVitri;
        private ComboBox cbbTrangThaiSach;
        private Label label9;
        private DateTimePicker dtpNgayXuatBan;
        private Label label4;
        private TextBox txtSoLuong;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox ccbtacgia;
        private Label label1;
        private ComboBox cbbnxb;
        private Label label2;
        private ComboBox ccbtheloai;
        private Label laba;
        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private Label label5;
        private Button btnhienthi;
        private Label label6;
        private Label label7;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Button btnsua;
        private TextBox txtGiaSach;
        private Button btnthem;
        private Label label13;
    }
}
