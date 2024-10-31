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
    public partial class uctTTKyThi : UserControl
    {
        private bool themmoi = false;
        static DBContext tn = new DBContext();
        public uctTTKyThi()
        {
            InitializeComponent();
        }

        private void dgvDSKT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvDSKT.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKT.Text = dgvDSKT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenKT.Text = dgvDSKT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTGLamBai.Text = dgvDSKT.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtSLCauHoi.Text = dgvDSKT.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbbTrangThaiThi.Text = dgvDSKT.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
        }
        
        private void uctTTKyThi_Load(object sender, EventArgs e)
        {
            List<Ky_Thi> k = tn.Ky_Thi.ToList();
            FillDSKT(k);
        }
        private void FillDSKT(List<Ky_Thi> k)
        {
            dgvDSKT.Rows.Clear();
            foreach (Ky_Thi kt in k)
            {
                int rowNew = dgvDSKT.Rows.Add();
                dgvDSKT.Rows[rowNew].Cells[0].Value = kt.Ma_Ky_Thi;
                dgvDSKT.Rows[rowNew].Cells[1].Value = kt.Ten_Ky_Thi;
                dgvDSKT.Rows[rowNew].Cells[2].Value = kt.Thoi_Gian_Bat_Dau;
                dgvDSKT.Rows[rowNew].Cells[3].Value = kt.Thoi_Gian_Ket_Thuc;
                dgvDSKT.Rows[rowNew].Cells[4].Value = kt.Thoi_Gian_Lam_Bai;
                dgvDSKT.Rows[rowNew].Cells[5].Value = kt.So_Luong_Cau_Hoi;
                dgvDSKT.Rows[rowNew].Cells[6].Value = kt.Trang_Thai_Thi;
            }
        }
        void SetNull()
        {
            txtMaKT.Text = "";
            txtTenKT.Text = "";
            txtTGLamBai.Text = "";
            txtSLCauHoi.Text = "";
            cbbTrangThaiThi.Text = "";
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
            if (txtMaKT.Text.Trim() == "" || txtTenKT.Text.Trim() == "" || 
                txtTGLamBai.Text.Trim() == "" || txtSLCauHoi.Text == "" || 
                cbbTrangThaiThi.Text.Trim() == "")
                return true;
            return false;
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKT.Text == "" || txtTenKT.Text == "" || txtTGLamBai.Text == "" ||
                txtSLCauHoi.Text == "" || cbbTrangThaiThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            themmoi = true;
            setButton(false);
            txtMaKT.Focus();
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
            int row = GetSelectedRow(txtMaKT.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy Kỳ thi cần xoá nhé", "Thông báo");
            }
            else
            {
                var kyThi = tn.Ky_Thi.FirstOrDefault(s => s.Ma_Ky_Thi == txtMaKT.Text.Trim());

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
                    var danhgia = tn.Ky_Thi.FirstOrDefault(s => s.Ma_Ky_Thi == txtMaKT.Text.Trim());
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

                txtMaKT.Text = dgvDSKT.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenKT.Text = dgvDSKT.Rows[rowIndex].Cells[1].Value.ToString();
                txtTGLamBai.Text = dgvDSKT.Rows[rowIndex].Cells[4].Value.ToString();
                txtSLCauHoi.Text = dgvDSKT.Rows[rowIndex].Cells[5].Value.ToString();
                cbbTrangThaiThi.Text = dgvDSKT.Rows[rowIndex].Cells[6].Value.ToString();
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

            if (themmoi && CheckTrungMaKT(txtMaKT.Text.Trim()))
            {
                MessageBox.Show("Mã kỳ thi đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            string pattern = @"^[a-zA-Z0-9]+$";
            string maKT1 = txtMaKT.Text.Trim();

            // Kiểm tra mã kỳ thi có chứa ký tự không hợp lệ không
            if (!Regex.IsMatch(maKT1, pattern))
            {
                MessageBox.Show("Mã kỳ thi không được chứa dấu hoặc ký tự đặc biệt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMaKT.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã kỳ thi không được quá 10 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            string trangThai = cbbTrangThaiThi.Text.Trim();
            if (trangThai != "Đã diễn ra" && trangThai != "Chưa diễn ra" && trangThai != "Đang diễn ra")
            {
                MessageBox.Show("Trạng thái thi chỉ có thể là 'Đã diễn ra' hoặc 'Chưa diễn ra' hoặc 'Đang diễn ra'!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            // Kiểm tra xem có phải là số không
            if (!int.TryParse(txtTGLamBai.Text.Trim(), out int tgLamBai))
            {
                MessageBox.Show("Thời gian làm bài phải là số nguyên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }
            if (!int.TryParse(txtSLCauHoi.Text.Trim(), out int slCauHoi))
            {
                MessageBox.Show("Số lượng câu hỏi phải là số nguyên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            // Kiểm tra ràng buộc thời gian làm bài.
            int tgLamBai1 = int.Parse(txtTGLamBai.Text.Trim());
            if (tgLamBai1 <= 15 || tgLamBai1 > 180)
            {
                MessageBox.Show("Thời gian làm bài phải lơn hơn bằng 15 và bé hơn bằng 180", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setButton(true);
                return;
            }

            if (themmoi) // Thêm mới kỳ thi
            {
                
                string Makt = txtMaKT.Text.Trim();
                string Tenkt = txtTenKT.Text.Trim();
                string Trangtt = cbbTrangThaiThi.Text.Trim();
                int TGLB = int.Parse(txtTGLamBai.Text.Trim());
                int SLCH = int.Parse(txtSLCauHoi.Text.Trim());
                Ky_Thi kt = new Ky_Thi()
                {
                    Ma_Ky_Thi = Makt,
                    Ten_Ky_Thi = Tenkt,
                    Thoi_Gian_Bat_Dau = dtpBatDau.Value,
                    Thoi_Gian_Ket_Thuc = dtpKetThuc.Value,
                    Thoi_Gian_Lam_Bai = TGLB,
                    So_Luong_Cau_Hoi = SLCH,
                    Trang_Thai_Thi = Trangtt,
                };
                tn.Ky_Thi.Add(kt);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else // Sửa kỳ thi
            {
                var editKT = tn.Ky_Thi.FirstOrDefault(k => k.Ma_Ky_Thi == txtMaKT.Text.Trim());
                if (editKT != null)
                {
                    editKT.Ten_Ky_Thi = txtTenKT.Text.Trim();
                    editKT.Thoi_Gian_Lam_Bai = int.Parse(txtTGLamBai.Text.Trim());
                    editKT.So_Luong_Cau_Hoi = int.Parse(txtSLCauHoi.Text.Trim());
                    editKT.Trang_Thai_Thi = cbbTrangThaiThi.Text.Trim();
                }
                MessageBox.Show("Sửa thành công", "Thông báo");
            }

            tn.SaveChanges();
            FillDSKT(tn.Ky_Thi.ToList()); // Cập nhật lại DataGridView.
            setButton(true);
            SetNull(); // Xóa trắng form.
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }
    }
}
