using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Teacher
{
    public partial class uctTTCauHoi : UserControl
    {
        private bool themmoi = false;
        static DBContext tn = new DBContext();
        public uctTTCauHoi()
        {
            InitializeComponent();
        }

        private void dgvDSKT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvDSKT.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaCauHoi.Text = dgvDSKT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbbChuong.Text = dgvDSKT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNoiDung.Text = dgvDSKT.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbbDapAn.Text = dgvDSKT.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }
        private void FillDSKT(List<Cau_Hoi> k)
        {
            dgvDSKT.Rows.Clear();
            foreach (Cau_Hoi kt in k)
            {
                int rowNew = dgvDSKT.Rows.Add();
                dgvDSKT.Rows[rowNew].Cells[0].Value = kt.Ma_Cau_Hoi;
                dgvDSKT.Rows[rowNew].Cells[1].Value = kt.Noi_Dung_Cau_Hoi;
                dgvDSKT.Rows[rowNew].Cells[2].Value = kt.Ma_Chuong;
                dgvDSKT.Rows[rowNew].Cells[3].Value = kt.Phuong_An_Dung;
            }
        }
        void SetNull()
        {
            txtMaCauHoi.Text = "";
            txtNoiDung.Text = "";
            cbbChuong.Text = "";
            cbbDapAn.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        private bool checkNull()
        {
            if (txtMaCauHoi.Text.Trim() == "" || txtNoiDung.Text.Trim() == "" ||
                cbbChuong.Text.Trim() == "" || cbbDapAn.Text == "")
                return true;
            return false;
        }
        private void insertUpdata(int selectRow)
        {
            dgvDSKT.Rows[selectRow].Cells[0].Value = txtMaCauHoi.Text.Trim();
            dgvDSKT.Rows[selectRow].Cells[1].Value = txtNoiDung.Text.Trim();
            dgvDSKT.Rows[selectRow].Cells[4].Value = cbbChuong.Text.Trim();
            dgvDSKT.Rows[selectRow].Cells[5].Value = cbbDapAn.Text.Trim();
        }
        private void cbbChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChuong.SelectedItem != null)
            {
                // Lấy mã chương từ giá trị được chọn
                string maChuong = ((dynamic)cbbChuong.SelectedItem).Value;
                // Gán mã chương vào cột tương ứng trong DataGridView hoặc biến cần thiết
            }
        }
        private void HienThiChuong()
        {
            // Làm rỗng combobox trước khi thêm dữ liệu mới
            cbbChuong.Items.Clear();

            // Truy vấn lấy danh sách môn học từ cơ sở dữ liệu
            var subjects = tn.Chuongs.ToList();

            // Thêm các môn học vào combobox
            foreach (var subject in subjects)
            {
                cbbChuong.Items.Add(new { Text = subject.Ma_Chuong, Value = subject.Ma_Chuong });
            }

            // Thiết lập hiển thị cho combobox
            cbbChuong.DisplayMember = "Text";
            cbbChuong.ValueMember = "Value"; 

        }
        private void uctTTCauHoi_Load(object sender, EventArgs e)
        {
            List<Cau_Hoi> k = tn.Cau_Hoi.ToList();
            HienThiChuong();
            FillDSKT(k);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCauHoi.Text.Trim() == "" || txtNoiDung.Text.Trim() == "" ||
                cbbChuong.Text.Trim() == "" || cbbDapAn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            themmoi = true;
            setButton(false);
            txtMaCauHoi.Focus();
        }
        private int GetSelectedRow(string maKT)
        {
            // Duyệt qua tất cả các dòng trong DataGridView để tìm dòng có mã kỳ thi khớp.
            for (int i = 0; i < dgvDSKT.Rows.Count; i++)
            {
                if (dgvDSKT.Rows[i].Cells[0].Value != null &&
                    dgvDSKT.Rows[i].Cells[0].Value.ToString() == maKT)
                {
                    return i; // Trả về vị trí của dòng tìm được.
                }
            }
            return -1; // Không tìm thấy kỳ thi cần xóa.
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaCauHoi.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy Kỳ thi cần xoá nhé", "Thông báo");
            }
            else
            {
                var kyThi = tn.Ky_Thi.FirstOrDefault(s => s.Ma_Ky_Thi == txtMaCauHoi.Text.Trim());

                // Kiểm tra xem kỳ thi có trạng thái "Đang diễn ra" hay không
                if (kyThi != null && kyThi.Trang_Thai_Thi == "Đang diễn ra"
                    && kyThi.Trang_Thai_Thi == "Đã kết thúc")
                {
                    MessageBox.Show("Không thể xóa kỳ thi đang diễn ra và đã kết thúc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngăn chặn việc xóa
                }

                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo",
                    MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var danhgia = tn.Ky_Thi.FirstOrDefault(s => s.Ma_Ky_Thi == txtMaCauHoi.Text.Trim());
                    if (danhgia != null)
                    {
                        tn.Ky_Thi.Remove(danhgia);
                        tn.SaveChanges(); // Lưu
                    }
                    dgvDSKT.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }
            }
            setButton(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSKT.SelectedRows.Count > 0)
            {
                themmoi = false;
                setButton(false);
                int rowIndex = dgvDSKT.SelectedRows[0].Index;

                txtMaCauHoi.Text = dgvDSKT.Rows[rowIndex].Cells[0].Value.ToString();
                txtNoiDung.Text = dgvDSKT.Rows[rowIndex].Cells[1].Value.ToString();
                cbbChuong.Text = dgvDSKT.Rows[rowIndex].Cells[2].Value.ToString();
                cbbDapAn.Text = dgvDSKT.Rows[rowIndex].Cells[3].Value.ToString();
                MessageBox.Show("Ấn lưu để lưu thông tin");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kỳ thi cần sửa!", "Thông báo");
            }
        }
        private bool CheckTrungMaKT(string maKT)
        {
            var existingKT = tn.Ky_Thi.FirstOrDefault(k => k.Ma_Ky_Thi == maKT);
            return existingKT != null;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (themmoi && CheckTrungMaKT(txtMaCauHoi.Text.Trim()))
            {
                MessageBox.Show("Mã kỳ thi đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            string pattern = @"^[a-zA-Z0-9]+$";
            string maKT1 = txtMaCauHoi.Text.Trim();

            // Kiểm tra mã kỳ thi có chứa ký tự không hợp lệ không
            if (!Regex.IsMatch(maKT1, pattern))
            {
                MessageBox.Show("Mã kỳ thi không được chứa dấu hoặc ký tự đặc biệt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMaCauHoi.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã kỳ thi không được quá 10 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            if (themmoi) // Thêm mới kỳ thi
            {

                string Makt = txtMaCauHoi.Text.Trim();
                string noidung = txtNoiDung.Text.Trim();
                string chuong = cbbChuong.Text.Trim();
                string da = cbbDapAn.Text.Trim();
                Cau_Hoi kt = new Cau_Hoi()
                {
                    Ma_Cau_Hoi = Makt,
                    Noi_Dung_Cau_Hoi = noidung,
                    Ma_Chuong = chuong,
                    Phuong_An_Dung = da,
                };
                tn.Cau_Hoi.Add(kt);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else // Sửa kỳ thi
            {
                var editKT = tn.Cau_Hoi.FirstOrDefault(k => k.Ma_Cau_Hoi == txtMaCauHoi.Text.Trim());
                if (editKT != null)
                {
                    editKT.Noi_Dung_Cau_Hoi = txtNoiDung.Text.Trim();
                    editKT.Ma_Chuong = cbbChuong.Text.Trim();
                    editKT.Phuong_An_Dung = cbbDapAn.Text.Trim();
                }
                MessageBox.Show("Sửa thành công", "Thông báo");
            }

            tn.SaveChanges();
            FillDSKT(tn.Cau_Hoi.ToList()); // Cập nhật lại DataGridView.
            setButton(true);
            SetNull(); // Xóa trắng form.
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        
    }
}
