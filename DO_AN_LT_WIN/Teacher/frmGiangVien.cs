using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Teacher
{
    public partial class frmGiangVien : Form
    {
        public bool isThoat = true;
        public string magiangvien;
        public frmGiangVien()
        {
            InitializeComponent();
            panel1.Visible = false;
        }


        private void btnQLKyThi_Click(object sender, EventArgs e)
        {
            uctTTKyThi userControl = new uctTTKyThi();
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void btnTraDiem_Click(object sender, EventArgs e)
        {
            frm_TraCuuDiem form1 = new frm_TraCuuDiem();
            form1.magiangvien = magiangvien;
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog();
        }

        private void btnQuanlycauhoi_Click(object sender, EventArgs e)
        {
            frm_MonVaChuong form1 = new frm_MonVaChuong();
            form1.magiangvien = magiangvien;
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog();
        }

        public event EventHandler DangXuat;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                isThoat = false;
                DangXuat?.Invoke(this, new EventArgs());
                this.Close();
            }
        }

       

        private void frmGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    isThoat = false;
                    Application.Exit();
                }
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
