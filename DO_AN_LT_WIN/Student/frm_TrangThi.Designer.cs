namespace DO_AN_LT_WIN.Student
{
    partial class frm_TrangThi
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
            this.gb_noidungcauhoi = new System.Windows.Forms.GroupBox();
            this.lbl_NoiDungCauHoi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_cautraloi = new System.Windows.Forms.GroupBox();
            this.rdo_D = new System.Windows.Forms.RadioButton();
            this.rdo_C = new System.Windows.Forms.RadioButton();
            this.rdo_B = new System.Windows.Forms.RadioButton();
            this.rdo_A = new System.Windows.Forms.RadioButton();
            this.lbl_D = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.gb_Cau = new System.Windows.Forms.GroupBox();
            this.btn_Cau20 = new System.Windows.Forms.Button();
            this.btn_Cau19 = new System.Windows.Forms.Button();
            this.btn_Cau18 = new System.Windows.Forms.Button();
            this.btn_Cau17 = new System.Windows.Forms.Button();
            this.btn_Cau16 = new System.Windows.Forms.Button();
            this.btn_Cau15 = new System.Windows.Forms.Button();
            this.btn_Cau14 = new System.Windows.Forms.Button();
            this.btn_Cau13 = new System.Windows.Forms.Button();
            this.btn_Cau12 = new System.Windows.Forms.Button();
            this.btn_Cau11 = new System.Windows.Forms.Button();
            this.btn_Cau10 = new System.Windows.Forms.Button();
            this.btn_Cau9 = new System.Windows.Forms.Button();
            this.btn_Cau8 = new System.Windows.Forms.Button();
            this.btn_Cau7 = new System.Windows.Forms.Button();
            this.btn_Cau6 = new System.Windows.Forms.Button();
            this.btn_Cau5 = new System.Windows.Forms.Button();
            this.btn_Cau4 = new System.Windows.Forms.Button();
            this.btn_Cau3 = new System.Windows.Forms.Button();
            this.btn_Cau2 = new System.Windows.Forms.Button();
            this.btn_Cau1 = new System.Windows.Forms.Button();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.btn_NopBai = new System.Windows.Forms.Button();
            this.lbl_MaCauHoi = new System.Windows.Forms.Label();
            this.gb_noidungcauhoi.SuspendLayout();
            this.gb_cautraloi.SuspendLayout();
            this.gb_Cau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_noidungcauhoi
            // 
            this.gb_noidungcauhoi.Controls.Add(this.lbl_NoiDungCauHoi);
            this.gb_noidungcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_noidungcauhoi.Location = new System.Drawing.Point(12, 12);
            this.gb_noidungcauhoi.Name = "gb_noidungcauhoi";
            this.gb_noidungcauhoi.Size = new System.Drawing.Size(480, 344);
            this.gb_noidungcauhoi.TabIndex = 0;
            this.gb_noidungcauhoi.TabStop = false;
            this.gb_noidungcauhoi.Text = "Nội dung câu hỏi";
            // 
            // lbl_NoiDungCauHoi
            // 
            this.lbl_NoiDungCauHoi.AutoSize = true;
            this.lbl_NoiDungCauHoi.Location = new System.Drawing.Point(16, 29);
            this.lbl_NoiDungCauHoi.Name = "lbl_NoiDungCauHoi";
            this.lbl_NoiDungCauHoi.Size = new System.Drawing.Size(0, 20);
            this.lbl_NoiDungCauHoi.TabIndex = 0;
            // 
            // gb_cautraloi
            // 
            this.gb_cautraloi.Controls.Add(this.rdo_D);
            this.gb_cautraloi.Controls.Add(this.rdo_C);
            this.gb_cautraloi.Controls.Add(this.rdo_B);
            this.gb_cautraloi.Controls.Add(this.rdo_A);
            this.gb_cautraloi.Controls.Add(this.lbl_D);
            this.gb_cautraloi.Controls.Add(this.lbl_C);
            this.gb_cautraloi.Controls.Add(this.lbl_B);
            this.gb_cautraloi.Controls.Add(this.lbl_A);
            this.gb_cautraloi.Enabled = false;
            this.gb_cautraloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cautraloi.Location = new System.Drawing.Point(12, 362);
            this.gb_cautraloi.Name = "gb_cautraloi";
            this.gb_cautraloi.Size = new System.Drawing.Size(1059, 163);
            this.gb_cautraloi.TabIndex = 1;
            this.gb_cautraloi.TabStop = false;
            this.gb_cautraloi.Text = "Câu trả lời";
            // 
            // rdo_D
            // 
            this.rdo_D.AutoSize = true;
            this.rdo_D.Location = new System.Drawing.Point(33, 121);
            this.rdo_D.Name = "rdo_D";
            this.rdo_D.Size = new System.Drawing.Size(17, 16);
            this.rdo_D.TabIndex = 7;
            this.rdo_D.TabStop = true;
            this.rdo_D.UseVisualStyleBackColor = true;
            this.rdo_D.Click += new System.EventHandler(this.rdo_D_CheckedChanged);
            // 
            // rdo_C
            // 
            this.rdo_C.AutoSize = true;
            this.rdo_C.Location = new System.Drawing.Point(33, 91);
            this.rdo_C.Name = "rdo_C";
            this.rdo_C.Size = new System.Drawing.Size(17, 16);
            this.rdo_C.TabIndex = 6;
            this.rdo_C.TabStop = true;
            this.rdo_C.UseVisualStyleBackColor = true;
            this.rdo_C.Click += new System.EventHandler(this.rdo_C_CheckedChanged);
            // 
            // rdo_B
            // 
            this.rdo_B.AutoSize = true;
            this.rdo_B.Location = new System.Drawing.Point(33, 61);
            this.rdo_B.Name = "rdo_B";
            this.rdo_B.Size = new System.Drawing.Size(17, 16);
            this.rdo_B.TabIndex = 5;
            this.rdo_B.TabStop = true;
            this.rdo_B.UseVisualStyleBackColor = true;
            this.rdo_B.CheckedChanged += new System.EventHandler(this.rdo_B_CheckedChanged);
            // 
            // rdo_A
            // 
            this.rdo_A.AutoSize = true;
            this.rdo_A.Location = new System.Drawing.Point(33, 31);
            this.rdo_A.Name = "rdo_A";
            this.rdo_A.Size = new System.Drawing.Size(17, 16);
            this.rdo_A.TabIndex = 4;
            this.rdo_A.TabStop = true;
            this.rdo_A.UseVisualStyleBackColor = true;
            this.rdo_A.CheckedChanged += new System.EventHandler(this.rdo_A_CheckedChanged);
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D.Location = new System.Drawing.Point(6, 121);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(23, 18);
            this.lbl_D.TabIndex = 3;
            this.lbl_D.Text = "D.";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C.Location = new System.Drawing.Point(6, 91);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(23, 18);
            this.lbl_C.TabIndex = 2;
            this.lbl_C.Text = "C.";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.Location = new System.Drawing.Point(6, 61);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(22, 18);
            this.lbl_B.TabIndex = 1;
            this.lbl_B.Text = "B.";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(6, 31);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(21, 18);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "A.";
            // 
            // gb_Cau
            // 
            this.gb_Cau.Controls.Add(this.btn_Cau20);
            this.gb_Cau.Controls.Add(this.btn_Cau19);
            this.gb_Cau.Controls.Add(this.btn_Cau18);
            this.gb_Cau.Controls.Add(this.btn_Cau17);
            this.gb_Cau.Controls.Add(this.btn_Cau16);
            this.gb_Cau.Controls.Add(this.btn_Cau15);
            this.gb_Cau.Controls.Add(this.btn_Cau14);
            this.gb_Cau.Controls.Add(this.btn_Cau13);
            this.gb_Cau.Controls.Add(this.btn_Cau12);
            this.gb_Cau.Controls.Add(this.btn_Cau11);
            this.gb_Cau.Controls.Add(this.btn_Cau10);
            this.gb_Cau.Controls.Add(this.btn_Cau9);
            this.gb_Cau.Controls.Add(this.btn_Cau8);
            this.gb_Cau.Controls.Add(this.btn_Cau7);
            this.gb_Cau.Controls.Add(this.btn_Cau6);
            this.gb_Cau.Controls.Add(this.btn_Cau5);
            this.gb_Cau.Controls.Add(this.btn_Cau4);
            this.gb_Cau.Controls.Add(this.btn_Cau3);
            this.gb_Cau.Controls.Add(this.btn_Cau2);
            this.gb_Cau.Controls.Add(this.btn_Cau1);
            this.gb_Cau.Location = new System.Drawing.Point(498, 12);
            this.gb_Cau.Name = "gb_Cau";
            this.gb_Cau.Size = new System.Drawing.Size(573, 344);
            this.gb_Cau.TabIndex = 1;
            this.gb_Cau.TabStop = false;
            // 
            // btn_Cau20
            // 
            this.btn_Cau20.Location = new System.Drawing.Point(100, 135);
            this.btn_Cau20.Name = "btn_Cau20";
            this.btn_Cau20.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau20.TabIndex = 19;
            this.btn_Cau20.Text = "Câu 20";
            this.btn_Cau20.UseVisualStyleBackColor = true;
            this.btn_Cau20.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau19
            // 
            this.btn_Cau19.Location = new System.Drawing.Point(12, 135);
            this.btn_Cau19.Name = "btn_Cau19";
            this.btn_Cau19.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau19.TabIndex = 18;
            this.btn_Cau19.Text = "Câu 19";
            this.btn_Cau19.UseVisualStyleBackColor = true;
            this.btn_Cau19.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau18
            // 
            this.btn_Cau18.Location = new System.Drawing.Point(452, 97);
            this.btn_Cau18.Name = "btn_Cau18";
            this.btn_Cau18.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau18.TabIndex = 17;
            this.btn_Cau18.Text = "Câu 18";
            this.btn_Cau18.UseVisualStyleBackColor = true;
            this.btn_Cau18.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau17
            // 
            this.btn_Cau17.Location = new System.Drawing.Point(364, 97);
            this.btn_Cau17.Name = "btn_Cau17";
            this.btn_Cau17.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau17.TabIndex = 16;
            this.btn_Cau17.Text = "Câu 17";
            this.btn_Cau17.UseVisualStyleBackColor = true;
            this.btn_Cau17.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau16
            // 
            this.btn_Cau16.Location = new System.Drawing.Point(276, 97);
            this.btn_Cau16.Name = "btn_Cau16";
            this.btn_Cau16.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau16.TabIndex = 15;
            this.btn_Cau16.Text = "Câu 16";
            this.btn_Cau16.UseVisualStyleBackColor = true;
            this.btn_Cau16.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau15
            // 
            this.btn_Cau15.Location = new System.Drawing.Point(188, 97);
            this.btn_Cau15.Name = "btn_Cau15";
            this.btn_Cau15.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau15.TabIndex = 14;
            this.btn_Cau15.Text = "Câu 15";
            this.btn_Cau15.UseVisualStyleBackColor = true;
            this.btn_Cau15.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau14
            // 
            this.btn_Cau14.Location = new System.Drawing.Point(100, 97);
            this.btn_Cau14.Name = "btn_Cau14";
            this.btn_Cau14.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau14.TabIndex = 13;
            this.btn_Cau14.Text = "Câu 14";
            this.btn_Cau14.UseVisualStyleBackColor = true;
            this.btn_Cau14.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau13
            // 
            this.btn_Cau13.Location = new System.Drawing.Point(12, 97);
            this.btn_Cau13.Name = "btn_Cau13";
            this.btn_Cau13.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau13.TabIndex = 12;
            this.btn_Cau13.Text = "Câu 13";
            this.btn_Cau13.UseVisualStyleBackColor = true;
            this.btn_Cau13.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau12
            // 
            this.btn_Cau12.Location = new System.Drawing.Point(452, 59);
            this.btn_Cau12.Name = "btn_Cau12";
            this.btn_Cau12.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau12.TabIndex = 11;
            this.btn_Cau12.Text = "Câu 12";
            this.btn_Cau12.UseVisualStyleBackColor = true;
            this.btn_Cau12.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau11
            // 
            this.btn_Cau11.Location = new System.Drawing.Point(364, 59);
            this.btn_Cau11.Name = "btn_Cau11";
            this.btn_Cau11.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau11.TabIndex = 10;
            this.btn_Cau11.Text = "Câu 11";
            this.btn_Cau11.UseVisualStyleBackColor = true;
            this.btn_Cau11.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau10
            // 
            this.btn_Cau10.Location = new System.Drawing.Point(276, 59);
            this.btn_Cau10.Name = "btn_Cau10";
            this.btn_Cau10.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau10.TabIndex = 9;
            this.btn_Cau10.Text = "Câu 10";
            this.btn_Cau10.UseVisualStyleBackColor = true;
            this.btn_Cau10.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau9
            // 
            this.btn_Cau9.Location = new System.Drawing.Point(188, 59);
            this.btn_Cau9.Name = "btn_Cau9";
            this.btn_Cau9.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau9.TabIndex = 8;
            this.btn_Cau9.Text = "Câu 9";
            this.btn_Cau9.UseVisualStyleBackColor = true;
            this.btn_Cau9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau8
            // 
            this.btn_Cau8.Location = new System.Drawing.Point(100, 59);
            this.btn_Cau8.Name = "btn_Cau8";
            this.btn_Cau8.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau8.TabIndex = 7;
            this.btn_Cau8.Text = "Câu 8";
            this.btn_Cau8.UseVisualStyleBackColor = true;
            this.btn_Cau8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau7
            // 
            this.btn_Cau7.Location = new System.Drawing.Point(12, 59);
            this.btn_Cau7.Name = "btn_Cau7";
            this.btn_Cau7.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau7.TabIndex = 6;
            this.btn_Cau7.Text = "Câu 7";
            this.btn_Cau7.UseVisualStyleBackColor = true;
            this.btn_Cau7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau6
            // 
            this.btn_Cau6.Location = new System.Drawing.Point(452, 21);
            this.btn_Cau6.Name = "btn_Cau6";
            this.btn_Cau6.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau6.TabIndex = 5;
            this.btn_Cau6.Text = "Câu 6";
            this.btn_Cau6.UseVisualStyleBackColor = true;
            this.btn_Cau6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau5
            // 
            this.btn_Cau5.Location = new System.Drawing.Point(364, 21);
            this.btn_Cau5.Name = "btn_Cau5";
            this.btn_Cau5.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau5.TabIndex = 4;
            this.btn_Cau5.Text = "Câu 5";
            this.btn_Cau5.UseVisualStyleBackColor = true;
            this.btn_Cau5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau4
            // 
            this.btn_Cau4.Location = new System.Drawing.Point(276, 21);
            this.btn_Cau4.Name = "btn_Cau4";
            this.btn_Cau4.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau4.TabIndex = 3;
            this.btn_Cau4.Text = "Câu 4";
            this.btn_Cau4.UseVisualStyleBackColor = true;
            this.btn_Cau4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau3
            // 
            this.btn_Cau3.Location = new System.Drawing.Point(188, 21);
            this.btn_Cau3.Name = "btn_Cau3";
            this.btn_Cau3.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau3.TabIndex = 2;
            this.btn_Cau3.Text = "Câu 3";
            this.btn_Cau3.UseVisualStyleBackColor = true;
            this.btn_Cau3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau2
            // 
            this.btn_Cau2.Location = new System.Drawing.Point(100, 21);
            this.btn_Cau2.Name = "btn_Cau2";
            this.btn_Cau2.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau2.TabIndex = 1;
            this.btn_Cau2.Text = "Câu 2";
            this.btn_Cau2.UseVisualStyleBackColor = true;
            this.btn_Cau2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Cau1
            // 
            this.btn_Cau1.Location = new System.Drawing.Point(12, 21);
            this.btn_Cau1.Name = "btn_Cau1";
            this.btn_Cau1.Size = new System.Drawing.Size(82, 32);
            this.btn_Cau1.TabIndex = 0;
            this.btn_Cau1.Text = "Câu 1";
            this.btn_Cau1.UseVisualStyleBackColor = true;
            this.btn_Cau1.Click += new System.EventHandler(this.Button_Click);
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGian.Location = new System.Drawing.Point(190, 557);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(165, 22);
            this.lbl_ThoiGian.TabIndex = 2;
            this.lbl_ThoiGian.Text = "Thời gian còn lại:";
            // 
            // btn_NopBai
            // 
            this.btn_NopBai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_NopBai.Location = new System.Drawing.Point(12, 647);
            this.btn_NopBai.Name = "btn_NopBai";
            this.btn_NopBai.Size = new System.Drawing.Size(1059, 45);
            this.btn_NopBai.TabIndex = 3;
            this.btn_NopBai.Text = "Nộp bài";
            this.btn_NopBai.UseVisualStyleBackColor = false;
            this.btn_NopBai.Click += new System.EventHandler(this.btn_nopBai_Click);
            // 
            // lbl_MaCauHoi
            // 
            this.lbl_MaCauHoi.AutoSize = true;
            this.lbl_MaCauHoi.Location = new System.Drawing.Point(381, 607);
            this.lbl_MaCauHoi.Name = "lbl_MaCauHoi";
            this.lbl_MaCauHoi.Size = new System.Drawing.Size(0, 16);
            this.lbl_MaCauHoi.TabIndex = 4;
            this.lbl_MaCauHoi.Visible = false;
            // 
            // frm_TrangThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 750);
            this.Controls.Add(this.lbl_MaCauHoi);
            this.Controls.Add(this.btn_NopBai);
            this.Controls.Add(this.lbl_ThoiGian);
            this.Controls.Add(this.gb_Cau);
            this.Controls.Add(this.gb_cautraloi);
            this.Controls.Add(this.gb_noidungcauhoi);
            this.Name = "frm_TrangThi";
            this.Text = "Trang thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TrangThi_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_TrangThi_FormClosed);
            this.Load += new System.EventHandler(this.frm_TrangThi_Load);
            this.gb_noidungcauhoi.ResumeLayout(false);
            this.gb_noidungcauhoi.PerformLayout();
            this.gb_cautraloi.ResumeLayout(false);
            this.gb_cautraloi.PerformLayout();
            this.gb_Cau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_noidungcauhoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_Cau;
        private System.Windows.Forms.GroupBox gb_cautraloi;
        private System.Windows.Forms.Button btn_Cau18;
        private System.Windows.Forms.Button btn_Cau17;
        private System.Windows.Forms.Button btn_Cau16;
        private System.Windows.Forms.Button btn_Cau15;
        private System.Windows.Forms.Button btn_Cau14;
        private System.Windows.Forms.Button btn_Cau13;
        private System.Windows.Forms.Button btn_Cau12;
        private System.Windows.Forms.Button btn_Cau11;
        private System.Windows.Forms.Button btn_Cau10;
        private System.Windows.Forms.Button btn_Cau9;
        private System.Windows.Forms.Button btn_Cau8;
        private System.Windows.Forms.Button btn_Cau7;
        private System.Windows.Forms.Button btn_Cau5;
        private System.Windows.Forms.Button btn_Cau4;
        private System.Windows.Forms.Button btn_Cau3;
        private System.Windows.Forms.Button btn_Cau2;
        private System.Windows.Forms.Button btn_Cau1;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Button btn_NopBai;
        private System.Windows.Forms.Button btn_Cau6;
        private System.Windows.Forms.RadioButton rdo_A;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.RadioButton rdo_D;
        private System.Windows.Forms.RadioButton rdo_C;
        private System.Windows.Forms.RadioButton rdo_B;
        private System.Windows.Forms.Label lbl_NoiDungCauHoi;
        private System.Windows.Forms.Button btn_Cau20;
        private System.Windows.Forms.Button btn_Cau19;
        private System.Windows.Forms.Label lbl_MaCauHoi;
    }
}