using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN_LT_WIN.Entities;

namespace DO_AN_LT_WIN.Admin.Chung
{
    public partial class ucKyThi : UserControl
    {
        DBContext db = new DBContext();
        public ucKyThi()
        {
            InitializeComponent();
        }

        private void ucKyThi_Load(object sender, EventArgs e)
        {
            List<Ky_Thi> kyThiList = db.Ky_Thi.ToList();
            dgvKyThi.Rows.Clear();
            fillDGVKyThi(kyThiList);
            setGridViewStyle(dgvKyThi);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.ReadOnly = true;
        }
        private void fillDGVKyThi(List<Ky_Thi> kyThiList)
        {
            dgvKyThi.Rows.Clear();
            foreach (Ky_Thi item in kyThiList)
            {
                int newRow = dgvKyThi.Rows.Add();

                dgvKyThi.Rows[newRow].Cells[0].Value = dgvKyThi.Rows.Count;
                dgvKyThi.Rows[newRow].Cells[1].Value = item.Ma_Ky_Thi.Trim();
                dgvKyThi.Rows[newRow].Cells[2].Value = item.Ten_Ky_Thi;
                dgvKyThi.Rows[newRow].Cells[3].Value = item.Thoi_Gian_Bat_Dau;
                dgvKyThi.Rows[newRow].Cells[4].Value = item.Thoi_Gian_Ket_Thuc;
                dgvKyThi.Rows[newRow].Cells[5].Value = item.Thoi_Gian_Lam_Bai;
                dgvKyThi.Rows[newRow].Cells[6].Value = item.So_Luong_Cau_Hoi;
                dgvKyThi.Rows[newRow].Cells[7].Value = item.Trang_Thai_Thi;
            }
        }
        private int GetSelectedRow(string kyThiID)
        {

            for (int i = 0; i < dgvKyThi.Rows.Count; i++)
            {
                if (dgvKyThi.Rows[i].Cells[1].Value != null &&
                    dgvKyThi.Rows[i].Cells[1].Value.ToString() == kyThiID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvKyThi.Rows[selectRow].Cells[0].Value = dgvKyThi.Rows.Count;
            dgvKyThi.Rows[selectRow].Cells[1].Value = txtMaKyThi.Text.Trim();
            dgvKyThi.Rows[selectRow].Cells[2].Value = txtTenKyThi.Text.Trim();
            dgvKyThi.Rows[selectRow].Cells[3].Value = dtpTGBatDau.Value;
            dgvKyThi.Rows[selectRow].Cells[4].Value = dtpTGKetThuc.Value;
            dgvKyThi.Rows[selectRow].Cells[5].Value = txtTGLamBai.Text.Trim();
            dgvKyThi.Rows[selectRow].Cells[6].Value = txtSLCauHoi.Text.Trim();
            dgvKyThi.Rows[selectRow].Cells[7].Value = cbxTrangThai.Text.Trim();
        }

        private void dgvKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvKyThi.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKyThi.Text = dgvKyThi.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTenKyThi.Text = dgvKyThi.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dtpTGBatDau.Text = dgvKyThi.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpTGKetThuc.Text = dgvKyThi.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtTGLamBai.Text = dgvKyThi.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtSLCauHoi.Text = dgvKyThi.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cbxTrangThai.Text = dgvKyThi.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if(cbxTrangThai.Text.Trim() == "Đã kết thúc")
                        btnSua.Enabled = false;
                    else
                        btnSua.Enabled = true;

                    if (cbxTrangThai.Text.Trim() == "Đang diễn ra")
                    {
                        txtMaKyThi.Enabled = false;
                        txtTenKyThi.Enabled=false;
                        txtSLCauHoi.Enabled = false;
                        txtTGLamBai.Enabled = false;
                        dtpTGBatDau.Enabled = false;
                        cbxTrangThai.Enabled = false;
                    }
                    else
                    {
                        txtMaKyThi.Enabled = true;
                        txtTenKyThi.Enabled = true;
                        txtSLCauHoi.Enabled = true;
                        txtTGLamBai.Enabled = true;
                        dtpTGBatDau.Enabled = true;
                        cbxTrangThai.Enabled = true;
                    }    
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKyThi.Text) || txtMaKyThi.Text.Contains(" "))
                    throw new Exception("Mã kỳ thi không hợp lệ.");
                if (int.TryParse(txtSLCauHoi.Text.Trim(), out int slCauHoi))
                {
                    if (slCauHoi <= 40 || slCauHoi >= 120)
                        throw new Exception("Số lượng câu hỏi phải lớn hơn 40 và nhỏ hơn 120.");
                }
                else
                {
                    throw new Exception("Số lượng câu hỏi không hợp lệ.");
                }
                if (int.TryParse(txtTGLamBai.Text.Trim(), out int tgLamBai))
                {
                    if (tgLamBai <= 45 || tgLamBai >= 180)
                        throw new Exception("Thời gian làm bài phải lớn hơn 45 và nhỏ hơn 180.");
                }
                else
                {
                    throw new Exception("Thời gian làm bài không hợp lệ.");
                }

                if (txtMaKyThi.Text.Trim() == "" || txtTenKyThi.Text.Trim() == "" || txtSLCauHoi.Text.Trim() == "" || txtTGLamBai.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaKyThi.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvKyThi.Rows.Add();
                    insertUpdata(selectRow);
                    Ky_Thi newKT = new Ky_Thi
                    {
                        Ma_Ky_Thi = txtMaKyThi.Text.Trim(),
                        Ten_Ky_Thi = txtTenKyThi.Text.Trim(),
                        Thoi_Gian_Bat_Dau = dtpTGBatDau.Value,
                        Thoi_Gian_Ket_Thuc = dtpTGKetThuc.Value,
                        Thoi_Gian_Lam_Bai = int.Parse(txtTGLamBai.Text.Trim()),
                        So_Luong_Cau_Hoi = int.Parse(txtSLCauHoi.Text.Trim()),
                        Trang_Thai_Thi = cbxTrangThai.Text.Trim(),
                    };

                    db.Ky_Thi.Add(newKT);
                    db.SaveChanges();
                    MessageBox.Show("Thêm kỳ thi mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có kỳ thi này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKyThi.Text) || txtMaKyThi.Text.Contains(" "))
                    throw new Exception("Mã kỳ thi không hợp lệ.");
                if (int.TryParse(txtSLCauHoi.Text.Trim(), out int slCauHoi))
                {
                    if (slCauHoi <= 40 || slCauHoi >= 120)
                        throw new Exception("Số lượng câu hỏi phải lớn hơn 40 và nhỏ hơn 120.");
                }
                else
                {
                    throw new Exception("Số lượng câu hỏi không hợp lệ.");
                }
                if (int.TryParse(txtTGLamBai.Text.Trim(), out int tgLamBai))
                {
                    if (tgLamBai <= 45 || tgLamBai >= 180)
                        throw new Exception("Thời gian làm bài phải lớn hơn 45 và nhỏ hơn 180.");
                }
                else
                {
                    throw new Exception("Thời gian làm bài không hợp lệ.");
                }
                int selectRow = GetSelectedRow(txtMaKyThi.Text.Trim());
                if (selectRow == -1)
                {
                    MessageBox.Show("Không tìm thấy kỳ thi để sửa", "THÔNG BÁO");
                    return;
                }
                if (dtpTGKetThuc.Value < DateTime.Now)
                {
                    MessageBox.Show("Thời gian kết thúc phải lớn hơn hoặc bằng thời gian hiện tại.", "Thông báo");
                    return;
                }
                insertUpdata(selectRow);
                var kyThi = db.Ky_Thi.FirstOrDefault(s => s.Ma_Ky_Thi == txtMaKyThi.Text.Trim());
                if (kyThi != null)
                {
                    kyThi.Ten_Ky_Thi = txtTenKyThi.Text.Trim();
                    kyThi.Thoi_Gian_Bat_Dau = dtpTGBatDau.Value;
                    kyThi.Thoi_Gian_Ket_Thuc = dtpTGKetThuc.Value;
                    kyThi.Thoi_Gian_Lam_Bai = int.Parse(txtTGLamBai.Text.Trim());
                    kyThi.So_Luong_Cau_Hoi = int.Parse(txtSLCauHoi.Text.Trim());
                    kyThi.Trang_Thai_Thi = cbxTrangThai.Text.Trim();
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin chương thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}