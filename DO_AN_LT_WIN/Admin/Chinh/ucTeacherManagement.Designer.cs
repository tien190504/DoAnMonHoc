namespace DO_AN_LT_WIN.Admin.Chinh
{
    partial class ucTeacherManagement
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
            this.dgv_giangvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_chucvu = new System.Windows.Forms.ComboBox();
            this.cbo_trinhdo = new System.Windows.Forms.ComboBox();
            this.cbo_khoa = new System.Windows.Forms.ComboBox();
            this.lbl_trinhdo = new System.Windows.Forms.Label();
            this.lbl_chucvu = new System.Windows.Forms.Label();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_magiangvien = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_sodienthoai = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ho = new System.Windows.Forms.Label();
            this.lbl_mssv = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giangvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_giangvien
            // 
            this.dgv_giangvien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_giangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giangvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column13,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column11,
            this.Column8,
            this.Column14});
            this.dgv_giangvien.Location = new System.Drawing.Point(473, 3);
            this.dgv_giangvien.Name = "dgv_giangvien";
            this.dgv_giangvien.ReadOnly = true;
            this.dgv_giangvien.RowHeadersWidth = 51;
            this.dgv_giangvien.RowTemplate.Height = 24;
            this.dgv_giangvien.Size = new System.Drawing.Size(683, 598);
            this.dgv_giangvien.TabIndex = 3;
            this.dgv_giangvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_giangvien_CellContentClick);
            this.dgv_giangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_giangvien_CellContentClick);
            this.dgv_giangvien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_giangvien_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Số GV";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Họ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giới Tính";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Ngày Sinh";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số Điện Thoại";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Địa Chỉ";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Khoa";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Trình Độ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Chức Vụ";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_chucvu);
            this.panel1.Controls.Add(this.cbo_trinhdo);
            this.panel1.Controls.Add(this.cbo_khoa);
            this.panel1.Controls.Add(this.lbl_trinhdo);
            this.panel1.Controls.Add(this.lbl_chucvu);
            this.panel1.Controls.Add(this.lbl_khoa);
            this.panel1.Controls.Add(this.rb_nu);
            this.panel1.Controls.Add(this.rb_nam);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.dtp_ngaysinh);
            this.panel1.Controls.Add(this.txt_diachi);
            this.panel1.Controls.Add(this.txt_sodienthoai);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.txt_ho);
            this.panel1.Controls.Add(this.txt_magiangvien);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_userid);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_diachi);
            this.panel1.Controls.Add(this.lbl_sodienthoai);
            this.panel1.Controls.Add(this.lbl_ngaysinh);
            this.panel1.Controls.Add(this.lbl_gioitinh);
            this.panel1.Controls.Add(this.lbl_ho);
            this.panel1.Controls.Add(this.lbl_mssv);
            this.panel1.Controls.Add(this.lbl_ten);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_userid);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 598);
            this.panel1.TabIndex = 4;
            // 
            // cbo_chucvu
            // 
            this.cbo_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_chucvu.FormattingEnabled = true;
            this.cbo_chucvu.Items.AddRange(new object[] {
            "Giáo sư",
            "Phó giáo sư",
            "Giảng viên chính",
            "Giảng viên"});
            this.cbo_chucvu.Location = new System.Drawing.Point(120, 418);
            this.cbo_chucvu.Name = "cbo_chucvu";
            this.cbo_chucvu.Size = new System.Drawing.Size(200, 24);
            this.cbo_chucvu.TabIndex = 42;
            // 
            // cbo_trinhdo
            // 
            this.cbo_trinhdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trinhdo.FormattingEnabled = true;
            this.cbo_trinhdo.Items.AddRange(new object[] {
            "Tiến Sĩ",
            "Thạc Sĩ"});
            this.cbo_trinhdo.Location = new System.Drawing.Point(120, 466);
            this.cbo_trinhdo.Name = "cbo_trinhdo";
            this.cbo_trinhdo.Size = new System.Drawing.Size(200, 24);
            this.cbo_trinhdo.TabIndex = 41;
            // 
            // cbo_khoa
            // 
            this.cbo_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_khoa.FormattingEnabled = true;
            this.cbo_khoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kinh tế",
            "Toán học",
            "Vật lý",
            "Hóa học",
            "Sinh học",
            "Khoa học máy tính",
            "Công nghệ thực phẩm",
            "Khoa học xã hội",
            "Ngôn ngữ Anh",
            "Kĩ thuật cơ khí",
            "Điện tử viễn thông",
            "Toán ứng dụng",
            "Công nghệ sinh học",
            "Kĩ thuật xây dựng",
            "Kinh tế quốc tế",
            "Khoa học máy tính",
            "Công nghệ môi trường",
            "Kĩ thuật phần mềm",
            "Kĩ thuật hóa học",
            "Ngôn ngữ học",
            "Kĩ thuật ô tô",
            "Công nghệ thông tin",
            "Hóa học",
            "Sinh học",
            "Vật lý",
            "Toán học",
            "Kinh tế",
            "Công nghệ sinh học",
            "Điện tử viễn thông"});
            this.cbo_khoa.Location = new System.Drawing.Point(120, 370);
            this.cbo_khoa.Name = "cbo_khoa";
            this.cbo_khoa.Size = new System.Drawing.Size(200, 24);
            this.cbo_khoa.TabIndex = 40;
            // 
            // lbl_trinhdo
            // 
            this.lbl_trinhdo.AutoSize = true;
            this.lbl_trinhdo.Location = new System.Drawing.Point(23, 469);
            this.lbl_trinhdo.Name = "lbl_trinhdo";
            this.lbl_trinhdo.Size = new System.Drawing.Size(57, 16);
            this.lbl_trinhdo.TabIndex = 39;
            this.lbl_trinhdo.Text = "Trình Độ";
            // 
            // lbl_chucvu
            // 
            this.lbl_chucvu.AutoSize = true;
            this.lbl_chucvu.Location = new System.Drawing.Point(22, 426);
            this.lbl_chucvu.Name = "lbl_chucvu";
            this.lbl_chucvu.Size = new System.Drawing.Size(56, 16);
            this.lbl_chucvu.TabIndex = 38;
            this.lbl_chucvu.Text = "Chức Vụ";
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Location = new System.Drawing.Point(22, 378);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(38, 16);
            this.lbl_khoa.TabIndex = 37;
            this.lbl_khoa.Text = "Khoa";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(289, 285);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 36;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(120, 287);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 35;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Blue;
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(345, 544);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(80, 41);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Blue;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(54, 544);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(80, 41);
            this.btn_them.TabIndex = 33;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(120, 329);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngaysinh.TabIndex = 32;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(345, 149);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(100, 22);
            this.txt_diachi.TabIndex = 30;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(345, 99);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(100, 22);
            this.txt_sodienthoai.TabIndex = 29;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(345, 48);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 28;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(345, 231);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(100, 22);
            this.txt_ten.TabIndex = 31;
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(120, 232);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(100, 22);
            this.txt_ho.TabIndex = 27;
            // 
            // txt_magiangvien
            // 
            this.txt_magiangvien.Location = new System.Drawing.Point(120, 188);
            this.txt_magiangvien.Name = "txt_magiangvien";
            this.txt_magiangvien.Size = new System.Drawing.Size(100, 22);
            this.txt_magiangvien.TabIndex = 26;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(120, 139);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 22);
            this.txt_password.TabIndex = 25;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(120, 90);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 22);
            this.txt_username.TabIndex = 24;
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(120, 48);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(100, 22);
            this.txt_userid.TabIndex = 23;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(247, 55);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "Email";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(247, 156);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(47, 16);
            this.lbl_diachi.TabIndex = 20;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // lbl_sodienthoai
            // 
            this.lbl_sodienthoai.AutoSize = true;
            this.lbl_sodienthoai.Location = new System.Drawing.Point(247, 106);
            this.lbl_sodienthoai.Name = "lbl_sodienthoai";
            this.lbl_sodienthoai.Size = new System.Drawing.Size(92, 16);
            this.lbl_sodienthoai.TabIndex = 19;
            this.lbl_sodienthoai.Text = "Số Điện Thoại";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(23, 336);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(69, 16);
            this.lbl_ngaysinh.TabIndex = 18;
            this.lbl_ngaysinh.Text = "Ngày Sinh";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Location = new System.Drawing.Point(22, 289);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(54, 16);
            this.lbl_gioitinh.TabIndex = 17;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_ho
            // 
            this.lbl_ho.AutoSize = true;
            this.lbl_ho.Location = new System.Drawing.Point(22, 239);
            this.lbl_ho.Name = "lbl_ho";
            this.lbl_ho.Size = new System.Drawing.Size(25, 16);
            this.lbl_ho.TabIndex = 16;
            this.lbl_ho.Text = "Họ";
            // 
            // lbl_mssv
            // 
            this.lbl_mssv.AutoSize = true;
            this.lbl_mssv.Location = new System.Drawing.Point(22, 195);
            this.lbl_mssv.Name = "lbl_mssv";
            this.lbl_mssv.Size = new System.Drawing.Size(48, 16);
            this.lbl_mssv.TabIndex = 15;
            this.lbl_mssv.Text = "Mã GV";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(256, 238);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(31, 16);
            this.lbl_ten.TabIndex = 14;
            this.lbl_ten.Text = "Tên";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(22, 146);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 16);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(22, 97);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 16);
            this.lbl_username.TabIndex = 22;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(22, 55);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(52, 16);
            this.lbl_userid.TabIndex = 12;
            this.lbl_userid.Text = "User ID";
            // 
            // ucTeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_giangvien);
            this.Name = "ucTeacherManagement";
            this.Size = new System.Drawing.Size(1159, 604);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giangvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_giangvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_chucvu;
        private System.Windows.Forms.ComboBox cbo_trinhdo;
        private System.Windows.Forms.ComboBox cbo_khoa;
        private System.Windows.Forms.Label lbl_trinhdo;
        private System.Windows.Forms.Label lbl_chucvu;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.TextBox txt_magiangvien;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_sodienthoai;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ho;
        private System.Windows.Forms.Label lbl_mssv;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}
