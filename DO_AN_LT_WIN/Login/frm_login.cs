using DO_AN_LT_WIN.Entities;

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DO_AN_LT_WIN.Admin.Chinh;
using DO_AN_LT_WIN.Teacher;
using DO_AN_LT_WIN.Student;

namespace DO_AN_LT_WIN.Login
{
    public partial class frm_login : Form
    {
        DBContext context = new DBContext();
        
        public frm_login()
        {
            InitializeComponent();
            SetPlaceholder(txt_matkhau, "Mật khẩu");
            SetPlaceholder(txt_taikhoan, "Tên tài khoản");
            cb_hienmk.CheckedChanged += cb_hienmk_CheckedChanged;
            txt_matkhau.UseSystemPasswordChar = true;


            //txt_taikhoan.Text = "user_sv01"; txt_matkhau.Text = "Password31";
            //txt_taikhoan.Text = "user_gv01"; txt_matkhau.Text = "Password01";
            //txt_taikhoan.Text = "admin"; txt_matkhau.Text = "admin";
        }

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        // Xử lý nút Thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        // Hàm xử lý sự kiện Đăng Xuất
        private void DangXuatQTV(object sender, EventArgs e)
        {
            frm_quantrivien frm = sender as frm_quantrivien;
            if (frm != null)
            {
                frm.isThoat = false;
                frm.Close();
            }
            this.Show(); // Hiển thị lại form đăng nhập
        }
        
        private void DangXuatGV(object sender, EventArgs e)
        {
            frmGiangVien frm = sender as frmGiangVien;
            if (frm != null)
            {
                frm.isThoat = false;
                frm.Close();
            }
            this.Show();
        }

        private void DangXuatSV(object sender, EventArgs e)
        {
            frm_BaiThi frm = sender as frm_BaiThi;
            if (frm != null)
            {
                frm.isThoat = false;
                frm.Close();
            }
            this.Show();
        }

        // Xử lý nút Đăng Nhập
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            string role = kiemtradangnhap(username, password);

            if (role == "admin")
            {
                frm_quantrivien frm_Quantrivien = new frm_quantrivien();
                frm_Quantrivien.Show();
                this.Hide();
                frm_Quantrivien.DangXuat += DangXuatQTV;
            }
            else if (role == "sinhvien")
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
                if (user != null)
                {
                    frm_BaiThi frm_Sinhvien = new frm_BaiThi();
                    frm_Sinhvien.MaSinhVien = user.Ma_Sinh_Vien; // Gán mã sinh viên vào form
                    frm_Sinhvien.Show();
                    this.Hide();
                    frm_Sinhvien.DangXuat += DangXuatSV;
                }
            }
            else if (role == "giangvien")
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
                frmGiangVien frm_Teacher = new frmGiangVien();
                frm_Teacher.magiangvien = user.Ma_Giang_Vien;
                frm_Teacher.Show();
                this.Hide();
                frm_Teacher.DangXuat += DangXuatGV;
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kiểm tra đăng nhập với dữ liệu trong DBContext
        private string kiemtradangnhap(string tentaikhoan, string matkhau)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == tentaikhoan && u.Password == matkhau);

            if (user != null)
            {
                if (user.Ma_Sinh_Vien == null && user.Ma_Giang_Vien == null)
                {
                    return "admin";
                }
                else if (user.Ma_Giang_Vien == null)
                {
                    return "sinhvien";
                }
                else if (user.Ma_Sinh_Vien == null)
                {
                    return "giangvien";
                }
            }
            return null;
        }

        private void cb_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienmk.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
