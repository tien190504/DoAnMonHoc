using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DO_AN_LT_WIN.Student
{
    public partial class frm_BaiThi : Form
    {
        public bool isThoat = true;

        DBContext DBContext = new DBContext();
        public string mamonhoc;
        public string makythi;
        public string MaSinhVien;
        public frm_BaiThi()
        {
            InitializeComponent();
        }

        private void frm_BaiThi_Load(object sender, EventArgs e)
        {
            List<Ky_Thi> listKyThi = DBContext.Ky_Thi.ToList();
            List<Mon_Hoc> listMonHoc = DBContext.Mon_Hoc.ToList();
            FillKyThiCombobox(listKyThi);
            FillMonHocCombobox(listMonHoc);
            var selectedUser = DBContext.Users.FirstOrDefault(k => k.Ma_Sinh_Vien == MaSinhVien);
            var selectedSV = DBContext.Sinh_Vien.FirstOrDefault(k => k.Ma_Sinh_Vien == MaSinhVien);
            txt_HoVaTen.Text = selectedUser.Ho + " " + selectedUser.Ten;
            txt_Khoa.Text = selectedSV.Khoa;
            txt_MaSInhVien.Text = selectedSV.Ma_Sinh_Vien;

            DateTime ngaynhaphoc = DateTime.Parse(selectedSV.Ngay_Nhap_Hoc.ToString());
            string formattedDate = ngaynhaphoc.ToString("dd/MM/yyyy");

            txt_NgayNhapHoc.Text = formattedDate;
            DateTime ngaysinh = DateTime.Parse(selectedUser.Ngay_Sinh.ToString());
            string formattedDate1 = ngaysinh.ToString("dd/MM/yyyy");
            txt_ngaysinh.Text = formattedDate1;
            txt_sdt.Text = selectedUser.So_Dien_Thoai;
            txt_email.Text = selectedUser.Email;
            txt_diachi.Text = selectedUser.Dia_Chi;
        }
        private void btn_ThiCu_Click(object sender, EventArgs e)
        {
            gb_ChiTietBaiThi.Visible = true; 
            gb_ThongTinBaiThi.Visible = true;
            gb_ThongTinSinhVien.Visible = false;
            btn_Thi.Visible = true;
        }
        private void FillKyThiCombobox(List<Ky_Thi> listKyThi)
        {
            this.cb_BaiThi.DataSource = listKyThi;
            this.cb_BaiThi.DisplayMember = "Ten_Ky_Thi";
            this.cb_BaiThi.ValueMember = "Ma_Ky_Thi";
        }

        private void FillMonHocCombobox(List<Mon_Hoc> listMonHoc)
        {
            this.cb_Mon.DataSource = listMonHoc;
            this.cb_Mon.DisplayMember = "Ten_Mon_Hoc";
            this.cb_Mon.ValueMember = "Ma_Mon_Hoc";
        }

        private void btn_Thi_Click(object sender, EventArgs e)
        {
            mamonhoc = cb_Mon.SelectedValue.ToString();
            string selectedMaKyThi = cb_BaiThi.SelectedValue?.ToString();
            var selectedExam = DBContext.Ky_Thi.FirstOrDefault(k => k.Ma_Ky_Thi == selectedMaKyThi);
            if (selectedExam.Trang_Thai_Thi.Contains("Đã kết thúc"))
            {
                MessageBox.Show("Bài thi đã kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (selectedExam.Trang_Thai_Thi.Contains("Chưa diễn ra"))
            {
                MessageBox.Show("Bài thi chưa diễn ra. Vui lòng quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (selectedExam != null)
            {
                lbl_TenBaiThi.Text = selectedExam.Ten_Ky_Thi;
                lbl_SoCauHoi.Text = selectedExam.So_Luong_Cau_Hoi.ToString();
                lbl_ThoiGian.Text = selectedExam.Thoi_Gian_Lam_Bai.ToString() + " Phút";
                lbl_BatDau.Text = selectedExam.Thoi_Gian_Bat_Dau.ToString();
                lbl_KetThuc.Text = selectedExam.Thoi_Gian_Ket_Thuc.ToString();
            }
            else
            {
                // Clear the labels if no exam is found
                lbl_TenBaiThi.Text = "";
                lbl_SoCauHoi.Text = "";
                lbl_ThoiGian.Text = "";
                lbl_BatDau.Text = "";
                lbl_KetThuc.Text = "";
                MessageBox.Show("Exam not found in the database.");
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thi ngay bây giờ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (selectedExam.So_Luong_Cau_Hoi == 15)
                {
                    frm_TrangThiGiuaKy form1 = new frm_TrangThiGiuaKy(mamonhoc);
                    form1.makythi = selectedMaKyThi;
                    form1.masinhvien = MaSinhVien;
                    form1.StartPosition = FormStartPosition.CenterParent;
                    form1.ShowDialog();
                }
                else
                {
                    frm_TrangThi form2 = new frm_TrangThi(mamonhoc);
                    form2.makythi = selectedMaKyThi;
                    form2.masinhvien = MaSinhVien;
                    form2.StartPosition = FormStartPosition.CenterParent;
                    form2.ShowDialog();
                }
            }
            else
            {

            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            lbl_TenBaiThi.Text = "";
            lbl_SoCauHoi.Text = "";
            lbl_ThoiGian.Text = "";
            lbl_BatDau.Text = "";
            lbl_KetThuc.Text = "";
            string selectedMaKyThi = cb_BaiThi.SelectedValue?.ToString();
            
            if (selectedMaKyThi != null)
            {
                var selectedExam = DBContext.Ky_Thi.FirstOrDefault(k => k.Ma_Ky_Thi == selectedMaKyThi);
                if(selectedExam.Trang_Thai_Thi.Contains("Đã kết thúc"))
                {
                    MessageBox.Show("Bài thi đã kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (selectedExam.Trang_Thai_Thi.Contains("Chưa diễn ra"))
                {
                    MessageBox.Show("Bài thi chưa diễn ra. Vui lòng quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (selectedExam != null)
                {
                    lbl_TenBaiThi.Text = selectedExam.Ten_Ky_Thi;
                    lbl_SoCauHoi.Text = selectedExam.So_Luong_Cau_Hoi.ToString();
                    lbl_ThoiGian.Text = selectedExam.Thoi_Gian_Lam_Bai.ToString() + " Phút";
                    lbl_BatDau.Text = selectedExam.Thoi_Gian_Bat_Dau.ToString();
                    lbl_KetThuc.Text = selectedExam.Thoi_Gian_Ket_Thuc.ToString();
                }
                else
                {
                    // Clear the labels if no exam is found
                    lbl_TenBaiThi.Text = "";
                    lbl_SoCauHoi.Text = "";
                    lbl_ThoiGian.Text = "";
                    lbl_BatDau.Text = "";
                    lbl_KetThuc.Text = "";
                    MessageBox.Show("Exam not found in the database.");
                }
            }
        }
        private void btn_MyProfile_Click(object sender, EventArgs e)
        {
            gb_ThongTinSinhVien.Visible = true;
        }

        private void btn_TraCuuKetQua_Click(object sender, EventArgs e)
        {
            frm_KetQuaThi form2 = new frm_KetQuaThi();
            form2.masinhvien = MaSinhVien;
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog();
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

        private void frm_BaiThi_FormClosing(object sender, FormClosingEventArgs e)
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
