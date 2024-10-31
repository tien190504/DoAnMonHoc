namespace DO_AN_LT_WIN.Teacher
{
    partial class frm_MonVaChuong
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
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.cb_chuong = new System.Windows.Forms.ComboBox();
            this.btn_XemCacCauHoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_mon
            // 
            this.cb_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(166, 27);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(273, 33);
            this.cb_mon.TabIndex = 0;
            this.cb_mon.SelectedIndexChanged += new System.EventHandler(this.Cb_mon_SelectedIndexChanged);
            // 
            // cb_chuong
            // 
            this.cb_chuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_chuong.FormattingEnabled = true;
            this.cb_chuong.Location = new System.Drawing.Point(166, 66);
            this.cb_chuong.Name = "cb_chuong";
            this.cb_chuong.Size = new System.Drawing.Size(273, 33);
            this.cb_chuong.TabIndex = 2;
            // 
            // btn_XemCacCauHoi
            // 
            this.btn_XemCacCauHoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_XemCacCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XemCacCauHoi.Location = new System.Drawing.Point(486, 50);
            this.btn_XemCacCauHoi.Name = "btn_XemCacCauHoi";
            this.btn_XemCacCauHoi.Size = new System.Drawing.Size(170, 35);
            this.btn_XemCacCauHoi.TabIndex = 3;
            this.btn_XemCacCauHoi.Text = "Xem các câu hỏi";
            this.btn_XemCacCauHoi.UseVisualStyleBackColor = false;
            this.btn_XemCacCauHoi.Click += new System.EventHandler(this.btn_XemCacCauHoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chương";
            // 
            // frm_MonVaChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XemCacCauHoi);
            this.Controls.Add(this.cb_chuong);
            this.Controls.Add(this.cb_mon);
            this.Name = "frm_MonVaChuong";
            this.Load += new System.EventHandler(this.MonVaChuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.ComboBox cb_chuong;
        private System.Windows.Forms.Button btn_XemCacCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}