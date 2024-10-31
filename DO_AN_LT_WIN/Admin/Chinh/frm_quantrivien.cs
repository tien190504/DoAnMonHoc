using DO_AN_LT_WIN.Admin.Chung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Admin.Chinh
{
    public partial class frm_quantrivien : Form
    {
        public bool isThoat = true;

        private ucChuong ucChuong;
        private ucKyThi ucKyThi;
        private ucMonHoc ucMonHoc;
        // Khai báo các UserControl
        private ucChung ucChung;
        private ucStudentManagement ucStudents;
        private ucTeacherManagement ucTeachers;


        public frm_quantrivien()
        {
            InitializeComponent();
            anButton(false);
            // Khởi tạo các UserControl
            ucChung = new ucChung();
            ucStudents = new ucStudentManagement();
            ucTeachers = new ucTeacherManagement();
            ucMonHoc = new ucMonHoc();
            ucKyThi = new ucKyThi();
            ucChuong = new ucChuong();

            // Thêm các UserControl vào Form
            ucStudents.Dock = DockStyle.Fill; // Để UserControl hiển thị toàn bộ diện tích của Form
            ucTeachers.Dock = DockStyle.Fill;
            ucMonHoc.Dock = DockStyle.Fill;
            ucChung.Dock = DockStyle.Fill;
            ucKyThi.Dock = DockStyle.Fill;

            p_user.Controls.Add(ucChung);
            p_user.Controls.Add(ucStudents);
            p_user.Controls.Add(ucTeachers);
            p_user.Controls.Add(ucChuong);
            p_user.Controls.Add(ucKyThi);
            p_user.Controls.Add(ucMonHoc);

            // Đảm bảo UserControl nào sẽ hiển thị đầu tiên
            ucChung.BringToFront();
        }
        private void frm_quantrivien_Load(object sender, EventArgs e)
        {

        }
        void anButton(bool an)
        {
            btnMonHoc.Visible = an;
            btnChuong.Visible = an;
            btnKyThi.Visible = an;
            p_chung.Visible = an;
        }
        // Sự kiện khi nhấn nút Chung
        private void btn_chung_Click(object sender, EventArgs e)
        {
            if(btnChuong.Visible == true)   anButton(false);
            else anButton(true);
            ucChung.BringToFront();
        }
        // Sự kiện khi nhấn nút Quản lý Học sinh
        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            anButton(false);
            ucStudents.BringToFront();
        }

        // Sự kiện khi nhấn nút Quản lý Giáo viên
        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            anButton(false);
            ucTeachers.BringToFront();
        }

        public event EventHandler DangXuat;

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                isThoat = false; // Đặt isThoat = false để tránh thoát ứng dụng
                DangXuat?.Invoke(this, new EventArgs());
                this.Close(); // Đóng form hiện tại, sự kiện FormClosing sẽ không thoát ứng dụng
            }
        }


        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ucMonHoc.BringToFront();
        }

        private void btnChuong_Click(object sender, EventArgs e)
        {
            ucChuong.BringToFront();
        }

        private void btnKyThi_Click(object sender, EventArgs e)
        {
            ucKyThi.BringToFront();
        }

        private void frm_quantrivien_FormClosing(object sender, FormClosingEventArgs e)
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
                    Environment.Exit(0);
                }
            }
            else
            {
                e.Cancel = true; // Hủy việc đóng form
                this.Hide();     // Ẩn form hiện tại để quay lại màn hình đăng nhập
            }
        }
    }

}
