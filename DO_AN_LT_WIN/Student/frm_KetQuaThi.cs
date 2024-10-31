using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DO_AN_LT_WIN.Student
{
    public partial class frm_KetQuaThi : Form
    {
        public string masinhvien;
        public string mamon;
        public string makythi;
        public int socaudung;
        public float dim;
        public string makq;
        DBContext DBContext = new DBContext();
        public Dictionary<string,string> selectedAnswers = new Dictionary<string, string>();
        private List<Cau_Hoi> cauHoiList;
        public frm_KetQuaThi()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void frm_KetQuaThi_Load(object sender, EventArgs e)
        {
            lbl_SCauDung.Text = socaudung.ToString();
            lbl_Dim.Text = dim.ToString();
            var selectedExam = DBContext.Ky_Thi.FirstOrDefault(k => k.Ma_Ky_Thi == makythi);
            if (selectedExam == null)
            {
                MessageBox.Show("Không tìm thấy kỳ thi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedExam.So_Luong_Cau_Hoi == 15)
            {
                btn_Cau16.Visible = false; btn_Cau17.Visible = false;
                btn_Cau18.Visible = false; btn_Cau19.Visible = false; btn_Cau20.Visible = false;
            }
            LoadDanhSachCauHoi(mamon);
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

                rdocheck(cauHoi.Ma_Cau_Hoi);
            }

        }
        private void rdocheck(string questionId)
        {
            // Lấy đáp án đúng từ bảng Cau_Hoi
            var phuongAnDung = DBContext.Cau_Hoi
                .Where(ch => ch.Ma_Cau_Hoi == questionId)
                .Select(ch => ch.Phuong_An_Dung)
                .FirstOrDefault();

            // Kiểm tra nếu câu trả lời của câu hỏi đã có trong từ điển
            if (selectedAnswers.TryGetValue(questionId, out string selectedAnswer))
            {
                // Thiết lập radio button đã được chọn dựa trên câu trả lời đã lưu
                rdo_A.Checked = selectedAnswer == "A";
                rdo_B.Checked = selectedAnswer == "B";
                rdo_C.Checked = selectedAnswer == "C";
                rdo_D.Checked = selectedAnswer == "D";

                // Tô màu nút tương ứng thành màu xanh nếu đáp án đúng, màu đỏ nếu đáp án sai
                if (selectedAnswer == "A") rdo_A.BackColor = selectedAnswer == phuongAnDung ? Color.Green : Color.Red;
                else if (selectedAnswer == "B") rdo_B.BackColor = selectedAnswer == phuongAnDung ? Color.Green : Color.Red;
                else if (selectedAnswer == "C") rdo_C.BackColor = selectedAnswer == phuongAnDung ? Color.Green : Color.Red;
                else if (selectedAnswer == "D") rdo_D.BackColor = selectedAnswer == phuongAnDung ? Color.Green : Color.Red;
            }
            else
            {
                // Xóa tất cả lựa chọn nếu chưa có câu trả lời được ghi nhận
                rdo_A.Checked = rdo_B.Checked = rdo_C.Checked = rdo_D.Checked = false;
                rdo_A.BackColor = rdo_B.BackColor = rdo_C.BackColor = rdo_D.BackColor = SystemColors.Control;
            }

            // Tô màu xanh cho đáp án đúng
            if (phuongAnDung == "A") rdo_A.BackColor = Color.Green;
            else if (phuongAnDung == "B") rdo_B.BackColor = Color.Green;
            else if (phuongAnDung == "C") rdo_C.BackColor = Color.Green;
            else if (phuongAnDung == "D") rdo_D.BackColor = Color.Green;
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
            btn_Cau16.Tag = 15;
            btn_Cau17.Tag = 16;
            btn_Cau18.Tag = 17;
            btn_Cau19.Tag = 18;
            btn_Cau20.Tag = 19;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int questionIndex = (int)(clickedButton.Tag);

                rdo_A.BackColor = Color.White;
                rdo_B.BackColor = Color.White;
                rdo_C.BackColor = Color.White;
                rdo_D.BackColor = Color.White;

                LoadCauHoiTheoMonHoc(questionIndex);
            }
        }

        private void frm_KetQuaThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_YKienveDe_Click(object sender, EventArgs e)
        {
            frm_DanhGiaSV form1 = new frm_DanhGiaSV();
            form1.makq = makq;
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog();
        }
    }
}
