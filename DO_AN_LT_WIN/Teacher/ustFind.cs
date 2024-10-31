using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Teacher
{
    public partial class uctFind : UserControl
    {
        static DBContext tn = new DBContext();
        User u = new User();
        Bai_Thi bai = new Bai_Thi();
        Ky_Thi ky = new Ky_Thi();
        Mon_Hoc mon = new Mon_Hoc();
        public uctFind()
        {
            InitializeComponent();
            
        }

        private void dgvFind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void HienThiMon()
        {
            // Làm rỗng combobox trước khi thêm dữ liệu mới
            cbbMon.Items.Clear();

            // Truy vấn lấy danh sách môn học từ cơ sở dữ liệu
            var subjects = tn.Mon_Hoc.ToList();

            // Thêm các môn học vào combobox
            foreach (var subject in subjects)
            {
                cbbMon.Items.Add(new { Text = subject.Ten_Mon_Hoc, Value = subject.Ma_Mon_Hoc });
            }

            // Thiết lập hiển thị cho combobox
            cbbMon.DisplayMember = "Text";
            cbbMon.ValueMember = "Value";

            // Nếu bạn muốn chọn mặc định, có thể thêm dòng này
            // cbbMon.SelectedIndex = 0; // Chọn môn đầu tiên trong danh sách
        }

        private void LoadAutoCompleteData()
        {
            var Masv = new AutoCompleteStringCollection();
            var Tensv = new AutoCompleteStringCollection();
            var Mabt = new AutoCompleteStringCollection();
            var Kythi = new AutoCompleteStringCollection();
            var Mon = new AutoCompleteStringCollection();


            // Giả sử tk.Students là danh sách sinh viên
            foreach (var sv in tn.Users)
            {
                Tensv.Add(sv.Ten);
            }

            foreach (var p in tn.Bai_Thi)
            {
                Masv.Add(p.Ma_Sinh_Vien);
                Mabt.Add(p.Ma_Bai_Thi);
            }

            foreach (var p in tn.Ky_Thi)
            {
                Kythi.Add(p.Ten_Ky_Thi);
            }

            foreach (var p in tn.Mon_Hoc)
            {
                Mon.Add(p.Ten_Mon_Hoc);
            }

            txtMaSV.AutoCompleteCustomSource = Masv;
            txtTenSV.AutoCompleteCustomSource = Tensv;
            txtMaBaiThi.AutoCompleteCustomSource = Mabt;
            txtKyThi.AutoCompleteCustomSource = Kythi;
            cbbMon.AutoCompleteCustomSource = Mon;
        }
        private void UpdateResultCount(int count)
        {
            count--;
        }
        private void uctFind_Load(object sender, EventArgs e)
        {
            UpdateResultCount(1);

            // Cài đặt thuộc tính autocomplete cho txtMSSV
            txtMaSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cài đặt thuộc tính autocomplete cho txtHoTen
            txtTenSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenSV.AutoCompleteSource = AutoCompleteSource.CustomSource;


            txtMaBaiThi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaBaiThi.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtKyThi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtKyThi.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbbMon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LoadAutoCompleteData();
            HienThiMon();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string Masv = txtMaSV.Text.Trim();
            string Tensv = txtTenSV.Text.Trim();
            string Makt = txtMaBaiThi.Text.Trim();
            string Kythi = txtKyThi.Text.Trim();
            string Mon = cbbMon.Text.Trim();

            dgvFind.Rows.Clear();

            // Kết hợp dữ liệu từ các bảng
            string sql = @"
                        SELECT u.Ma_Sinh_Vien, u.Ten, u.Ngay_Sinh, kqt.Diem, sv.Khoa
                        FROM [User] u
                        JOIN Sinh_Vien sv ON u.Ma_Sinh_Vien = sv.Ma_Sinh_Vien
                        JOIN Bai_Thi bt ON sv.Ma_Sinh_Vien = bt.Ma_Sinh_Vien
                        JOIN Ky_Thi kt ON bt.Ma_Ky_Thi = kt.Ma_Ky_Thi
                        JOIN CT_Mon_Hoc ctmh ON kt.Ma_Ky_Thi = ctmh.Ma_Ky_Thi
                        JOIN Mon_Hoc mh ON ctmh.Ma_Mon_Hoc = mh.Ma_Mon_Hoc
                        JOIN Ket_Qua_Thi kqt ON bt.Ma_Bai_Thi = kqt.Ma_Bai_Thi
                        WHERE (u.Ma_Sinh_Vien LIKE '%' + @Masv + '%' OR @Masv IS NULL)
                            AND (u.Ten LIKE '%' + @Tensv + '%' OR @Tensv IS NULL)
                            AND (bt.Ma_Bai_Thi LIKE '%' + @Makt + '%' OR @Makt IS NULL)
                            AND (kt.Ten_Ky_Thi LIKE '%' + @Kythi + '%' OR @Kythi IS NULL)
                            AND (mh.Ten_Mon_Hoc LIKE '%' + @Mon + '%' OR @Mon IS NULL)";

            var parameters = new[]
            {
                new SqlParameter("@Masv", string.IsNullOrEmpty(Masv) ? (object)DBNull.Value : Masv),
                new SqlParameter("@Tensv", string.IsNullOrEmpty(Tensv) ? (object)DBNull.Value : Tensv),
                new SqlParameter("@Makt", string.IsNullOrEmpty(Makt) ? (object)DBNull.Value : Makt),
                new SqlParameter("@Kythi", string.IsNullOrEmpty(Kythi) ? (object)DBNull.Value : Kythi),
                new SqlParameter("@Mon", string.IsNullOrEmpty(Mon) ? (object)DBNull.Value : Mon)
            };

            // Thực hiện truy vấn và lấy kết quả
            var results0 = tn.Users.AsQueryable();
            var results1 = tn.Bai_Thi.AsQueryable();
            var results2 = tn.Ky_Thi.AsQueryable();
            var results3 = tn.Mon_Hoc.AsQueryable();
            var results4 = tn.Sinh_Vien.AsQueryable();
            var results5 = tn.Ket_Qua_Thi.AsQueryable();
            // Hiển thị kết quả trên DataGridView
            var results = tn.Database.SqlQuery<StudentResult>(sql, parameters).ToList();

            // Hiển thị kết quả trên DataGridView
            if (results.Any())
            {
                foreach (var c in results)
                {
                    int rowNew = dgvFind.Rows.Add();
                    dgvFind.Rows[rowNew].Cells[0].Value = c.Ma_Sinh_Vien; // Cột Mã Sinh Viên
                    dgvFind.Rows[rowNew].Cells[1].Value = c.Ten; // Cột Tên
                    dgvFind.Rows[rowNew].Cells[2].Value = c.Ngay_Sinh; // Cột Ngày Sinh
                    dgvFind.Rows[rowNew].Cells[3].Value = c.Diem; // Cột Điểm
                    dgvFind.Rows[rowNew].Cells[4].Value = c.Khoa; // Cột Khoa
                }
                UpdateResultCount(dgvFind.Rows.Count);
            }
            else
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public class StudentResult
        {
            public string Ma_Sinh_Vien { get; set; }
            public string Ten { get; set; }
            public DateTime Ngay_Sinh { get; set; }
            public double Diem { get; set; }
            public string Khoa { get; set; }
        }
        void SetNull()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtMaBaiThi.Text = "";
            txtKyThi.Text = "";
            cbbMon.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetNull();
        }
    }
}
