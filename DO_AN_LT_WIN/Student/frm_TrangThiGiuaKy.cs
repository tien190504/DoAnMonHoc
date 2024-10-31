using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Student
{
    public partial class frm_TrangThiGiuaKy : Form
    {
        DBContext DBContext = new DBContext();
        private Timer countdownTimer;
        private int timeLeft;
        private string mamonhoc;
        private List<Cau_Hoi> cauHoiList;
        private Dictionary<string, string> selectedAnswers = new Dictionary<string, string>();
        public string makythi { get; set; }
        public string masinhvien { get; set; }
        private string maKQ;
        public frm_TrangThiGiuaKy(string mamonhoc)
        {
            List<Cau_Hoi> listCauHoi = DBContext.Cau_Hoi.ToList();
            List<Phuong_An_Chon> listPA = DBContext.Phuong_An_Chon.ToList();
            InitializeComponent();
            timeLeft = 1200;
            this.mamonhoc = mamonhoc;
            LoadDanhSachCauHoi(mamonhoc);
            btn_Cau1.Focus();
            InitializeButtons();
        }
        private void frm_TrangThiGiuaKy_Load(object sender, EventArgs e)
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
            UpdateLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft <= 0)
            {
                countdownTimer.Stop();
                lbl_ThoiGian.Text = "Hết giờ!";
                btn_nopBai_Click(sender, e);
            }
            else
            {
                UpdateLabel();
            }
        }

        private void UpdateLabel()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lbl_ThoiGian.Text = $"Thời gian còn lại: {minutes:D2}:{seconds:D2}";
        }

        private void LoadDanhSachCauHoi(string maMonHoc)
        {
            var chuongList = DBContext.Chuongs
                               .Where(ch => ch.Ma_Mon_Hoc == maMonHoc)
                               .Select(ch => ch.Ma_Chuong)
                               .ToList();

            cauHoiList = DBContext.Cau_Hoi
                                  .Where(ch => chuongList.Contains(ch.Ma_Chuong))
                                  .ToList();
            
        }

        private void LoadCauHoiTheoMonHoc(int questionIndex)
        {
            if (cauHoiList != null && cauHoiList.Count > questionIndex)
            {
                var cauHoi = cauHoiList[questionIndex];
                lbl_MaCauHoi.Text = $"Mã câu hỏi: {cauHoi.Ma_Cau_Hoi}";
                lbl_NoiDungCauHoi.Text = cauHoi.Noi_Dung_Cau_Hoi;

                var phuongAnList = DBContext.Phuong_An_Chon
                                             .Where(pa => pa.Ma_Cau_Hoi == cauHoi.Ma_Cau_Hoi)
                                             .ToList();

                rdo_A.Text = phuongAnList.Count > 0 ? phuongAnList[0].Noi_Dung_Phuong_An : "";
                rdo_B.Text = phuongAnList.Count > 1 ? phuongAnList[1].Noi_Dung_Phuong_An : "";
                rdo_C.Text = phuongAnList.Count > 2 ? phuongAnList[2].Noi_Dung_Phuong_An : "";
                rdo_D.Text = phuongAnList.Count > 3 ? phuongAnList[3].Noi_Dung_Phuong_An : "";

                // Kiểm tra xem phương án đã chọn đã được lưu chưa
                if (selectedAnswers.TryGetValue(cauHoi.Ma_Cau_Hoi, out string selectedAnswer))
                {
                    // Đánh dấu phương án đã chọn
                    if (rdo_A.Text == selectedAnswer) rdo_A.Checked = true;
                    else if (rdo_B.Text == selectedAnswer) rdo_B.Checked = true;
                    else if (rdo_C.Text == selectedAnswer) rdo_C.Checked = true;
                    else if (rdo_D.Text == selectedAnswer) rdo_D.Checked = true;
                }
            }
        }

        private void InitializeButtons()
        {
            btn_Cau1.Tag = 0;
            btn_Cau2.Tag = 1;
            btn_Cau3.Tag = 2;
            btn_Cau4.Tag = 3;
            btn_Cau5.Tag = 4;
            btn_Cau6.Tag = 5;
            btn_Cau7.Tag = 6;
            btn_Cau8.Tag = 7;
            btn_Cau9.Tag = 8;
            btn_Cau10.Tag = 9;
            btn_Cau11.Tag = 10;
            btn_Cau12.Tag = 11;
            btn_Cau13.Tag = 12;
            btn_Cau14.Tag = 13;
            btn_Cau15.Tag = 14;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            gb_cautraloi.Enabled = true;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int questionIndex = (int)(clickedButton.Tag);
                rdo_A.Checked = false; rdo_B.Checked = false; rdo_C.Checked = false; rdo_D.Checked = false;
                LoadCauHoiTheoMonHoc(questionIndex);
            }
        }
       
        private void rdo_A_CheckedChanged(object sender, EventArgs e)
        {
            SaveSelectedAnswer(rdo_A);
        }

        private void rdo_B_CheckedChanged(object sender, EventArgs e)
        {
            SaveSelectedAnswer(rdo_B);
        }

        private void rdo_C_CheckedChanged(object sender, EventArgs e)
        {
            SaveSelectedAnswer(rdo_C);
        }

        private void rdo_D_CheckedChanged(object sender, EventArgs e)
        {
            SaveSelectedAnswer(rdo_D);
        }

        private void SaveSelectedAnswer(RadioButton selectedOption)
        {
            if (selectedOption.Checked && lbl_MaCauHoi.Text.StartsWith("Mã câu hỏi: "))
            {
                string maCauHoi = lbl_MaCauHoi.Text.Replace("Mã câu hỏi: ", "");
                string selectedAnswerKey = string.Empty;

                // Xác định ký tự tương ứng với phương án được chọn
                if (selectedOption == rdo_A) selectedAnswerKey = "A";
                else if (selectedOption == rdo_B) selectedAnswerKey = "B";
                else if (selectedOption == rdo_C) selectedAnswerKey = "C";
                else if (selectedOption == rdo_D) selectedAnswerKey = "D";

                selectedAnswers[maCauHoi] = selectedAnswerKey; // Lưu ký tự phương án đã chọn
            }
        }
        private void SaveExamResults(Dictionary<string, string> selectedAnswers, string maSinhVien, string maKyThi, int lanThi, string mamonhoc)
        {
            string mabaithi;
            string maketqua;
            using (var context = new DBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra nếu cả hai khóa đã tồn tại trong bảng CT_Mon_Hoc
                        if (!context.CT_Mon_Hoc.Any(m => m.Ma_Mon_Hoc == mamonhoc && m.Ma_Ky_Thi == maKyThi))
                        {
                            // Nếu chưa tồn tại, thêm CT_Mon_Hoc
                            context.CT_Mon_Hoc.Add(new CT_Mon_Hoc { Ma_Ky_Thi = maKyThi, Ma_Mon_Hoc = mamonhoc });
                            context.SaveChanges();
                        }

                        if (!context.Ky_Thi.Any(k => k.Ma_Ky_Thi == maKyThi))
                        {
                            context.Ky_Thi.Add(new Ky_Thi { Ma_Ky_Thi = maKyThi });
                            context.SaveChanges();
                        }

                        if (!context.Sinh_Vien.Any(s => s.Ma_Sinh_Vien == maSinhVien))
                        {
                            context.Sinh_Vien.Add(new Sinh_Vien { Ma_Sinh_Vien = maSinhVien });
                            context.SaveChanges();
                        }

                        // Lấy danh sách tất cả các mã bài thi
                        var allMaBaiThi = context.Bai_Thi.Select(b => b.Ma_Bai_Thi).ToList();
                        // Tìm mã bài thi lớn nhất và tăng lên 1
                        int lastId = allMaBaiThi
                            .Select(b => int.TryParse(b.Substring(4), out int id) ? id : 0) // Chỉ phân tích những mã hợp lệ
                            .DefaultIfEmpty(0)
                            .Max();
                        mabaithi = "BTGK" + (lastId + 1).ToString(); // Tạo mã mới

                        var baiThi = new Bai_Thi()
                        {
                            Ma_Bai_Thi = mabaithi,
                            Ma_Sinh_Vien = maSinhVien,
                            Ma_Ky_Thi = maKyThi,
                            Ma_Mon_Hoc = mamonhoc,
                            So_Cau_Dung = checkdapan(), // Giả sử số câu đúng là số câu trả lời
                            Lan_Thi = lanThi,
                            Thoi_Gian_Bat_Dau = DateTime.Now, // Thời gian bắt đầu
                            Thoi_Gian_Ket_Thuc = DateTime.Now.AddMinutes(15) // Thời gian kết thúc, ví dụ 15 phút sau
                        };
                        context.Bai_Thi.Add(baiThi);
                        context.SaveChanges();

                        var allMaKQ = context.Ket_Qua_Thi.Select(b => b.Ma_Ket_Qua).ToList();
                        int lastkq = allMaKQ
                            .Select(k => int.TryParse(k.Substring(3), out int id) ? id : 0) // Chỉ phân tích những mã hợp lệ
                            .DefaultIfEmpty(0)
                            .Max();
                        maketqua = "KQT" + (lastkq + 1).ToString(); // Tạo mã mới
                        maKQ = maketqua;
                        var ketQuaThi = new Ket_Qua_Thi()
                        {
                            Ma_Ket_Qua = maketqua,
                            Ma_Bai_Thi = mabaithi,
                            Diem = checkdapan() * 0.67
                        };
                        context.Ket_Qua_Thi.Add(ketQuaThi);
                        context.SaveChanges(); ;

                        // Commit transaction nếu không có lỗi
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi  
                        transaction.Rollback();
                        MessageBox.Show("Exception: " + ex.Message);
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                        }
                    }
                }
            }
        }

        private void btn_nopBai_Click(object sender, EventArgs e)
        {
            if (lbl_ThoiGian.Text.Contains("Hết giờ"))
            {
                int correctAnswers = checkdapan(); // Giả sử bạn đã thay đổi hàm checkdapan() để trả về số câu đúng

                // Lưu kết quả thi
                SaveExamResults(selectedAnswers, masinhvien, makythi, 1, mamonhoc);

                // Hiển thị thông báo thành công
                MessageBox.Show("Bạn đã nộp bài thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult xemKetQua = MessageBox.Show("Bạn muốn xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xemKetQua == DialogResult.Yes)
                {
                    frm_KetQuaThi form1 = new frm_KetQuaThi();
                    form1.makythi = makythi;
                    form1.selectedAnswers = selectedAnswers;
                    form1.mamon = mamonhoc;
                    form1.socaudung = correctAnswers; ;
                    form1.dim = (float)(correctAnswers * 0.67);
                    form1.StartPosition = FormStartPosition.CenterParent;
                    form1.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nộp bài?", "Xác nhận nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi hàm kiểm tra đáp án và lấy số câu đúng
                    int correctAnswers = checkdapan(); // Giả sử bạn đã thay đổi hàm checkdapan() để trả về số câu đúng

                    // Lưu kết quả thi
                    SaveExamResults(selectedAnswers, masinhvien, makythi, 1, mamonhoc);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Bạn đã nộp bài thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng hoặc ẩn form thi
                    DialogResult xemKetQua = MessageBox.Show("Bạn muốn xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xemKetQua == DialogResult.Yes)
                    {
                        frm_KetQuaThi form1 = new frm_KetQuaThi();
                        form1.selectedAnswers = selectedAnswers;
                        form1.makythi = makythi;
                        form1.mamon = mamonhoc;
                        form1.socaudung = correctAnswers; ;
                        form1.dim = (float)(correctAnswers * 0.67);
                        form1.makq = maKQ;
                        form1.StartPosition = FormStartPosition.CenterParent;
                        form1.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    // Người dùng chọn No, không làm gì cả
                }
            }
        }

        private int checkdapan()
        {
            int correctAnswersCount = 0; // Đếm số câu trả lời đúng
            int totalQuestions = selectedAnswers.Count; // Tổng số câu hỏi

            foreach (var entry in selectedAnswers)
            {
                string maCauHoi = entry.Key; // Mã câu hỏi
                string selectedAnswer = entry.Value; // Phương án đã chọn

                // Lấy câu hỏi từ cơ sở dữ liệu để kiểm tra đáp án đúng
                var cauHoi = DBContext.Cau_Hoi.FirstOrDefault(ch => ch.Ma_Cau_Hoi == maCauHoi);

                if (cauHoi != null)
                {
                    // So sánh phương án đã chọn với đáp án đúng
                    if (cauHoi.Phuong_An_Dung.Equals(selectedAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        correctAnswersCount++; // Tăng đếm nếu đáp án đúng
                    }
                }
            }

            // Hiển thị kết quả
            return correctAnswersCount;
        }

        public bool isThoat = true;
        private void frm_TrangThiGiuaKy_FormClosing(object sender, FormClosingEventArgs e)
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
                    btn_nopBai_Click(sender, e);
                    //Environment.Exit(0);
                    this.Close();
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
