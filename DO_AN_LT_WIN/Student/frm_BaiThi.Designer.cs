namespace DO_AN_LT_WIN.Student
{
    partial class frm_BaiThi
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
        public void InitializeComponent()
        {
            this.btn_ThiCu = new System.Windows.Forms.Button();
            this.gb_ThongTinBaiThi = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cb_BaiThi = new System.Windows.Forms.ComboBox();
            this.cb_Mon = new System.Windows.Forms.ComboBox();
            this.lbl_BaiThi = new System.Windows.Forms.Label();
            this.lbl_Mon = new System.Windows.Forms.Label();
            this.gb_ChiTietBaiThi = new System.Windows.Forms.GroupBox();
            this.lbl_KetThuc = new System.Windows.Forms.Label();
            this.lbl_BatDau = new System.Windows.Forms.Label();
            this.lbl_ThoiGianKetThuc = new System.Windows.Forms.Label();
            this.lbl_ThoiGianBatDau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.lbl_ThoiGianLamBai = new System.Windows.Forms.Label();
            this.lbl_SoCauHoi = new System.Windows.Forms.Label();
            this.lbl_SoLuongCauHoi = new System.Windows.Forms.Label();
            this.lbl_TenBaiThi = new System.Windows.Forms.Label();
            this.lbl_ChiTietBaiThi = new System.Windows.Forms.Label();
            this.btn_Thi = new System.Windows.Forms.Button();
            this.gb_ThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayNhapHoc = new System.Windows.Forms.TextBox();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.txt_MaSInhVien = new System.Windows.Forms.TextBox();
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_HoVaTen = new System.Windows.Forms.Label();
            this.btn_MyProfile = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.gb_ThongTinBaiThi.SuspendLayout();
            this.gb_ChiTietBaiThi.SuspendLayout();
            this.gb_ThongTinSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThiCu
            // 
            this.btn_ThiCu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ThiCu.Location = new System.Drawing.Point(12, 12);
            this.btn_ThiCu.Name = "btn_ThiCu";
            this.btn_ThiCu.Size = new System.Drawing.Size(149, 48);
            this.btn_ThiCu.TabIndex = 0;
            this.btn_ThiCu.Text = "Thi cử";
            this.btn_ThiCu.UseVisualStyleBackColor = false;
            this.btn_ThiCu.Click += new System.EventHandler(this.btn_ThiCu_Click);
            // 
            // gb_ThongTinBaiThi
            // 
            this.gb_ThongTinBaiThi.Controls.Add(this.btn_Tim);
            this.gb_ThongTinBaiThi.Controls.Add(this.cb_BaiThi);
            this.gb_ThongTinBaiThi.Controls.Add(this.cb_Mon);
            this.gb_ThongTinBaiThi.Controls.Add(this.lbl_BaiThi);
            this.gb_ThongTinBaiThi.Controls.Add(this.lbl_Mon);
            this.gb_ThongTinBaiThi.Location = new System.Drawing.Point(171, 14);
            this.gb_ThongTinBaiThi.Name = "gb_ThongTinBaiThi";
            this.gb_ThongTinBaiThi.Size = new System.Drawing.Size(899, 100);
            this.gb_ThongTinBaiThi.TabIndex = 2;
            this.gb_ThongTinBaiThi.TabStop = false;
            this.gb_ThongTinBaiThi.Visible = false;
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Tim.Location = new System.Drawing.Point(716, 21);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(108, 48);
            this.btn_Tim.TabIndex = 3;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // cb_BaiThi
            // 
            this.cb_BaiThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BaiThi.FormattingEnabled = true;
            this.cb_BaiThi.Location = new System.Drawing.Point(437, 31);
            this.cb_BaiThi.Name = "cb_BaiThi";
            this.cb_BaiThi.Size = new System.Drawing.Size(256, 24);
            this.cb_BaiThi.TabIndex = 3;
            // 
            // cb_Mon
            // 
            this.cb_Mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Mon.FormattingEnabled = true;
            this.cb_Mon.Location = new System.Drawing.Point(72, 27);
            this.cb_Mon.Name = "cb_Mon";
            this.cb_Mon.Size = new System.Drawing.Size(256, 24);
            this.cb_Mon.TabIndex = 2;
            // 
            // lbl_BaiThi
            // 
            this.lbl_BaiThi.AutoSize = true;
            this.lbl_BaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaiThi.Location = new System.Drawing.Point(369, 31);
            this.lbl_BaiThi.Name = "lbl_BaiThi";
            this.lbl_BaiThi.Size = new System.Drawing.Size(62, 20);
            this.lbl_BaiThi.TabIndex = 1;
            this.lbl_BaiThi.Text = "Bài thi:";
            // 
            // lbl_Mon
            // 
            this.lbl_Mon.AutoSize = true;
            this.lbl_Mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mon.Location = new System.Drawing.Point(15, 30);
            this.lbl_Mon.Name = "lbl_Mon";
            this.lbl_Mon.Size = new System.Drawing.Size(51, 20);
            this.lbl_Mon.TabIndex = 0;
            this.lbl_Mon.Text = "Môn: ";
            // 
            // gb_ChiTietBaiThi
            // 
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_KetThuc);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_BatDau);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_ThoiGianKetThuc);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_ThoiGianBatDau);
            this.gb_ChiTietBaiThi.Controls.Add(this.textBox1);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_GhiChu);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_ThoiGian);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_ThoiGianLamBai);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_SoCauHoi);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_SoLuongCauHoi);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_TenBaiThi);
            this.gb_ChiTietBaiThi.Controls.Add(this.lbl_ChiTietBaiThi);
            this.gb_ChiTietBaiThi.Location = new System.Drawing.Point(171, 129);
            this.gb_ChiTietBaiThi.Name = "gb_ChiTietBaiThi";
            this.gb_ChiTietBaiThi.Size = new System.Drawing.Size(899, 531);
            this.gb_ChiTietBaiThi.TabIndex = 3;
            this.gb_ChiTietBaiThi.TabStop = false;
            this.gb_ChiTietBaiThi.Text = "Chi Tiết Bài Thi";
            this.gb_ChiTietBaiThi.Visible = false;
            // 
            // lbl_KetThuc
            // 
            this.lbl_KetThuc.AutoSize = true;
            this.lbl_KetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetThuc.Location = new System.Drawing.Point(640, 67);
            this.lbl_KetThuc.Name = "lbl_KetThuc";
            this.lbl_KetThuc.Size = new System.Drawing.Size(0, 20);
            this.lbl_KetThuc.TabIndex = 12;
            // 
            // lbl_BatDau
            // 
            this.lbl_BatDau.AutoSize = true;
            this.lbl_BatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BatDau.Location = new System.Drawing.Point(640, 32);
            this.lbl_BatDau.Name = "lbl_BatDau";
            this.lbl_BatDau.Size = new System.Drawing.Size(0, 20);
            this.lbl_BatDau.TabIndex = 11;
            // 
            // lbl_ThoiGianKetThuc
            // 
            this.lbl_ThoiGianKetThuc.AutoSize = true;
            this.lbl_ThoiGianKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGianKetThuc.Location = new System.Drawing.Point(476, 67);
            this.lbl_ThoiGianKetThuc.Name = "lbl_ThoiGianKetThuc";
            this.lbl_ThoiGianKetThuc.Size = new System.Drawing.Size(151, 20);
            this.lbl_ThoiGianKetThuc.TabIndex = 10;
            this.lbl_ThoiGianKetThuc.Text = "Thời gian kết thúc: ";
            // 
            // lbl_ThoiGianBatDau
            // 
            this.lbl_ThoiGianBatDau.AutoSize = true;
            this.lbl_ThoiGianBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGianBatDau.Location = new System.Drawing.Point(476, 32);
            this.lbl_ThoiGianBatDau.Name = "lbl_ThoiGianBatDau";
            this.lbl_ThoiGianBatDau.Size = new System.Drawing.Size(142, 20);
            this.lbl_ThoiGianBatDau.TabIndex = 9;
            this.lbl_ThoiGianBatDau.Text = "Thời gian bắt đầu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(874, 362);
            this.textBox1.TabIndex = 8;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GhiChu.Location = new System.Drawing.Point(15, 139);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(72, 20);
            this.lbl_GhiChu.TabIndex = 7;
            this.lbl_GhiChu.Text = "Ghi chú:";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGian.Location = new System.Drawing.Point(178, 104);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(14, 20);
            this.lbl_ThoiGian.TabIndex = 6;
            this.lbl_ThoiGian.Text = " ";
            // 
            // lbl_ThoiGianLamBai
            // 
            this.lbl_ThoiGianLamBai.AutoSize = true;
            this.lbl_ThoiGianLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGianLamBai.Location = new System.Drawing.Point(15, 104);
            this.lbl_ThoiGianLamBai.Name = "lbl_ThoiGianLamBai";
            this.lbl_ThoiGianLamBai.Size = new System.Drawing.Size(141, 20);
            this.lbl_ThoiGianLamBai.TabIndex = 5;
            this.lbl_ThoiGianLamBai.Text = "Thời gian làm bài:";
            // 
            // lbl_SoCauHoi
            // 
            this.lbl_SoCauHoi.AutoSize = true;
            this.lbl_SoCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoCauHoi.Location = new System.Drawing.Point(178, 67);
            this.lbl_SoCauHoi.Name = "lbl_SoCauHoi";
            this.lbl_SoCauHoi.Size = new System.Drawing.Size(0, 20);
            this.lbl_SoCauHoi.TabIndex = 4;
            // 
            // lbl_SoLuongCauHoi
            // 
            this.lbl_SoLuongCauHoi.AutoSize = true;
            this.lbl_SoLuongCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuongCauHoi.Location = new System.Drawing.Point(15, 67);
            this.lbl_SoLuongCauHoi.Name = "lbl_SoLuongCauHoi";
            this.lbl_SoLuongCauHoi.Size = new System.Drawing.Size(138, 20);
            this.lbl_SoLuongCauHoi.TabIndex = 3;
            this.lbl_SoLuongCauHoi.Text = "Số lượng câu hỏi:";
            // 
            // lbl_TenBaiThi
            // 
            this.lbl_TenBaiThi.AutoSize = true;
            this.lbl_TenBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBaiThi.Location = new System.Drawing.Point(178, 32);
            this.lbl_TenBaiThi.Name = "lbl_TenBaiThi";
            this.lbl_TenBaiThi.Size = new System.Drawing.Size(0, 20);
            this.lbl_TenBaiThi.TabIndex = 2;
            // 
            // lbl_ChiTietBaiThi
            // 
            this.lbl_ChiTietBaiThi.AutoSize = true;
            this.lbl_ChiTietBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChiTietBaiThi.Location = new System.Drawing.Point(15, 32);
            this.lbl_ChiTietBaiThi.Name = "lbl_ChiTietBaiThi";
            this.lbl_ChiTietBaiThi.Size = new System.Drawing.Size(62, 20);
            this.lbl_ChiTietBaiThi.TabIndex = 1;
            this.lbl_ChiTietBaiThi.Text = "Bài thi:";
            // 
            // btn_Thi
            // 
            this.btn_Thi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Thi.Location = new System.Drawing.Point(525, 680);
            this.btn_Thi.Name = "btn_Thi";
            this.btn_Thi.Size = new System.Drawing.Size(108, 48);
            this.btn_Thi.TabIndex = 4;
            this.btn_Thi.Text = "Thi";
            this.btn_Thi.UseVisualStyleBackColor = false;
            this.btn_Thi.Visible = false;
            this.btn_Thi.Click += new System.EventHandler(this.btn_Thi_Click);
            // 
            // gb_ThongTinSinhVien
            // 
            this.gb_ThongTinSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_diachi);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_email);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_sdt);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_ngaysinh);
            this.gb_ThongTinSinhVien.Controls.Add(this.label7);
            this.gb_ThongTinSinhVien.Controls.Add(this.label6);
            this.gb_ThongTinSinhVien.Controls.Add(this.label5);
            this.gb_ThongTinSinhVien.Controls.Add(this.label4);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_NgayNhapHoc);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_Khoa);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_MaSInhVien);
            this.gb_ThongTinSinhVien.Controls.Add(this.txt_HoVaTen);
            this.gb_ThongTinSinhVien.Controls.Add(this.label3);
            this.gb_ThongTinSinhVien.Controls.Add(this.label2);
            this.gb_ThongTinSinhVien.Controls.Add(this.label1);
            this.gb_ThongTinSinhVien.Controls.Add(this.lbl_HoVaTen);
            this.gb_ThongTinSinhVien.Location = new System.Drawing.Point(162, 12);
            this.gb_ThongTinSinhVien.Name = "gb_ThongTinSinhVien";
            this.gb_ThongTinSinhVien.Size = new System.Drawing.Size(920, 723);
            this.gb_ThongTinSinhVien.TabIndex = 5;
            this.gb_ThongTinSinhVien.TabStop = false;
            this.gb_ThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(392, 419);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(252, 22);
            this.txt_diachi.TabIndex = 25;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(392, 377);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(252, 22);
            this.txt_email.TabIndex = 24;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(392, 337);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(252, 22);
            this.txt_sdt.TabIndex = 23;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(392, 296);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.ReadOnly = true;
            this.txt_ngaysinh.Size = new System.Drawing.Size(252, 22);
            this.txt_ngaysinh.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Địa chỉ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_NgayNhapHoc
            // 
            this.txt_NgayNhapHoc.Location = new System.Drawing.Point(392, 252);
            this.txt_NgayNhapHoc.Name = "txt_NgayNhapHoc";
            this.txt_NgayNhapHoc.ReadOnly = true;
            this.txt_NgayNhapHoc.Size = new System.Drawing.Size(252, 22);
            this.txt_NgayNhapHoc.TabIndex = 16;
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.Location = new System.Drawing.Point(392, 204);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.ReadOnly = true;
            this.txt_Khoa.Size = new System.Drawing.Size(252, 22);
            this.txt_Khoa.TabIndex = 15;
            // 
            // txt_MaSInhVien
            // 
            this.txt_MaSInhVien.Location = new System.Drawing.Point(392, 117);
            this.txt_MaSInhVien.Name = "txt_MaSInhVien";
            this.txt_MaSInhVien.ReadOnly = true;
            this.txt_MaSInhVien.Size = new System.Drawing.Size(252, 22);
            this.txt_MaSInhVien.TabIndex = 14;
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.Location = new System.Drawing.Point(392, 160);
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.ReadOnly = true;
            this.txt_HoVaTen.Size = new System.Drawing.Size(252, 22);
            this.txt_HoVaTen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày nhập học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sinh viên";
            // 
            // lbl_HoVaTen
            // 
            this.lbl_HoVaTen.AutoSize = true;
            this.lbl_HoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoVaTen.Location = new System.Drawing.Point(233, 156);
            this.lbl_HoVaTen.Name = "lbl_HoVaTen";
            this.lbl_HoVaTen.Size = new System.Drawing.Size(103, 25);
            this.lbl_HoVaTen.TabIndex = 9;
            this.lbl_HoVaTen.Text = "Họ và Tên";
            // 
            // btn_MyProfile
            // 
            this.btn_MyProfile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_MyProfile.Location = new System.Drawing.Point(12, 66);
            this.btn_MyProfile.Name = "btn_MyProfile";
            this.btn_MyProfile.Size = new System.Drawing.Size(149, 48);
            this.btn_MyProfile.TabIndex = 6;
            this.btn_MyProfile.Text = "Thông tin cá nhân";
            this.btn_MyProfile.UseVisualStyleBackColor = false;
            this.btn_MyProfile.Click += new System.EventHandler(this.btn_MyProfile_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_dangxuat.Location = new System.Drawing.Point(2, 680);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(149, 48);
            this.btn_dangxuat.TabIndex = 6;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // frm_BaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 740);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btn_MyProfile);
            this.Controls.Add(this.gb_ThongTinSinhVien);
            this.Controls.Add(this.btn_Thi);
            this.Controls.Add(this.gb_ChiTietBaiThi);
            this.Controls.Add(this.gb_ThongTinBaiThi);
            this.Controls.Add(this.btn_ThiCu);
            this.Name = "frm_BaiThi";
            this.Text = "My profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BaiThi_FormClosing);
            this.Load += new System.EventHandler(this.frm_BaiThi_Load);
            this.gb_ThongTinBaiThi.ResumeLayout(false);
            this.gb_ThongTinBaiThi.PerformLayout();
            this.gb_ChiTietBaiThi.ResumeLayout(false);
            this.gb_ChiTietBaiThi.PerformLayout();
            this.gb_ThongTinSinhVien.ResumeLayout(false);
            this.gb_ThongTinSinhVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThiCu;
        private System.Windows.Forms.GroupBox gb_ThongTinBaiThi;
        public System.Windows.Forms.ComboBox cb_Mon;
        private System.Windows.Forms.Label lbl_BaiThi;
        private System.Windows.Forms.Label lbl_Mon;
        public System.Windows.Forms.ComboBox cb_BaiThi;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.GroupBox gb_ChiTietBaiThi;
        private System.Windows.Forms.Button btn_Thi;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Label lbl_ThoiGianLamBai;
        private System.Windows.Forms.Label lbl_SoCauHoi;
        private System.Windows.Forms.Label lbl_SoLuongCauHoi;
        private System.Windows.Forms.Label lbl_TenBaiThi;
        private System.Windows.Forms.Label lbl_ChiTietBaiThi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gb_ThongTinSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_HoVaTen;
        private System.Windows.Forms.TextBox txt_NgayNhapHoc;
        private System.Windows.Forms.TextBox txt_Khoa;
        private System.Windows.Forms.TextBox txt_MaSInhVien;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.Label lbl_KetThuc;
        private System.Windows.Forms.Label lbl_BatDau;
        private System.Windows.Forms.Label lbl_ThoiGianKetThuc;
        private System.Windows.Forms.Label lbl_ThoiGianBatDau;
        private System.Windows.Forms.Button btn_MyProfile;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}