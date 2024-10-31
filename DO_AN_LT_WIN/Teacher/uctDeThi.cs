using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Teacher
{
    public partial class uctDeThi : UserControl
    {
        //private bool themmoi = false;
        static DBContext tn = new DBContext();
        public uctDeThi()
        {
            InitializeComponent();
        }
        private void FillData(List<Cau_Hoi> cauHoiList, List<Chuong> chuongList, List<Phuong_An_Chon> phuongAnList)
        {
            dgvDSKT.Rows.Clear();

            // Bước 1: Điền thông tin từ danh sách Cau_Hoi
            foreach (Cau_Hoi ch in cauHoiList)
            {
                int rowNew = dgvDSKT.Rows.Add();

                // Gán giá trị cho các cột của câu hỏi
                dgvDSKT.Rows[rowNew].Cells[0].Value = ch.Ma_Cau_Hoi; // Mã câu hỏi
                dgvDSKT.Rows[rowNew].Cells[1].Value = ch.Noi_Dung_Cau_Hoi; // Nội dung câu hỏi
                dgvDSKT.Rows[rowNew].Cells[6].Value = ch.Phuong_An_Dung; // Phương án đúng
                dgvDSKT.Rows[rowNew].Cells[8].Value = ch.Ma_Chuong; // Mã chương để tìm môn học phù hợp

                // Tìm môn học từ danh sách Chuong dựa trên Ma_Chuong
                var chuong = chuongList.FirstOrDefault(Chuong => Chuong.Ma_Chuong == ch.Ma_Chuong);
                if (chuong != null)
                {
                    dgvDSKT.Rows[rowNew].Cells[7].Value = chuong.Ma_Mon_Hoc; // Mã môn học lấy từ đối tượng Chuong
                }

                // Điền đáp án vào các cột (a, b, c, d) nếu có
                var phuongAnChoCauHoi = phuongAnList.Where(pa => pa.Ma_Cau_Hoi == ch.Ma_Cau_Hoi);
                foreach (var answer in phuongAnChoCauHoi)
                {
                    // Điền nội dung phương án vào cột tương ứng (a, b, c, d)
                    switch (answer.Phuong_An_Chon1.ToLower())
                    {
                        case "a":
                            dgvDSKT.Rows[rowNew].Cells[2].Value = answer.Noi_Dung_Phuong_An;
                            break;
                        case "b":
                            dgvDSKT.Rows[rowNew].Cells[3].Value = answer.Noi_Dung_Phuong_An;
                            break;
                        case "c":
                            dgvDSKT.Rows[rowNew].Cells[4].Value = answer.Noi_Dung_Phuong_An;
                            break;
                        case "d":
                            dgvDSKT.Rows[rowNew].Cells[5].Value = answer.Noi_Dung_Phuong_An;
                            break;
                    }
                }
            }
        }
        private void uctDeThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            List<Cau_Hoi> ch = tn.Cau_Hoi.ToList();
            List<Chuong> c = tn.Chuongs.ToList();
            List<Phuong_An_Chon> p = tn.Phuong_An_Chon.ToList();
            FillData(ch, c, p);
            HienThiMon();
            HienThiChuong();
        }
        void SetNull()
        {
            txtMaCauHoi.Text = "";
            txtNoiDung.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cbbMon.SelectedIndex = -1;
            cbbChuong.SelectedIndex = -1;
            cbbDapAn.SelectedIndex = -1;
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnHuy.Enabled = !val;
        }
        private bool checkNull()
        {
            if (txtMaCauHoi.Text.Trim() == "" || txtNoiDung.Text.Trim() == "" ||
                cbbMon.Text.Trim() == "" || cbbChuong.Text.Trim() == "" || cbbDapAn.Text == "")
                return true;
            return false;
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
                cbbChuong.Items.Add(new { Text = subject.Ten_Chuong, Value = subject.Ma_Chuong });
            }

            // Thiết lập hiển thị cho combobox
            cbbChuong.DisplayMember = "Text";
            cbbChuong.ValueMember = "Value";

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

        }
        private void dgvDSKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvDSKT.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaCauHoi.Text = dgvDSKT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNoiDung.Text = dgvDSKT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtA.Text = dgvDSKT.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtB.Text = dgvDSKT.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtC.Text = dgvDSKT.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtD.Text = dgvDSKT.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbbDapAn.Text = dgvDSKT.Rows[e.RowIndex].Cells[6].Value.ToString();

                    // Lấy mã chương từ ô thứ 7
                    string maMon = dgvDSKT.Rows[e.RowIndex].Cells[7].Value?.ToString();

                    // Tìm tên chương dựa trên mã môn
                    if (!string.IsNullOrEmpty(maMon))
                    {
                        var mon = tn.Mon_Hoc.FirstOrDefault(ch => ch.Ma_Mon_Hoc == maMon);
                        if (mon != null)
                        {
                            cbbMon.Text = mon.Ten_Mon_Hoc; // Gán tên chương vào ComboBox
                        }
                        else
                        {
                            cbbMon.SelectedIndex = -1; // Không tìm thấy chương, thiết lập giá trị không chọn
                        }
                    }
                    // Lấy mã chương từ ô thứ 8
                    string maChuong = dgvDSKT.Rows[e.RowIndex].Cells[8].Value?.ToString();

                    // Tìm tên chương dựa trên mã chương
                    if (!string.IsNullOrEmpty(maChuong))
                    {
                        var chuong = tn.Chuongs.FirstOrDefault(ch => ch.Ma_Chuong == maChuong);
                        if (chuong != null)
                        {
                            cbbChuong.Text = chuong.Ten_Chuong; // Gán tên chương vào ComboBox
                        }
                        else
                        {
                            cbbChuong.SelectedIndex = -1; // Không tìm thấy chương, thiết lập giá trị không chọn
                        }
                    }
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường nhập liệu có rỗng không
            if (checkNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã câu hỏi
            string maCauHoi = txtMaCauHoi.Text.Trim();
            if (tn.Cau_Hoi.Any(ch => ch.Ma_Cau_Hoi == maCauHoi))
            {
                MessageBox.Show("Mã câu hỏi đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm trùng đáp án
            if (CheckDuplicateAnswers())
            {
                MessageBox.Show("Các đáp án không được trùng nhau.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm câu hỏi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Nếu người dùng chọn "Không", thoát khỏi hàm
            }

            // Tạo đối tượng câu hỏi mới
            string noidung = txtNoiDung.Text.Trim();
            string da = cbbDapAn.Text.Trim();
            Cau_Hoi newCauHoi = new Cau_Hoi
            {
                Ma_Cau_Hoi = maCauHoi,
                Noi_Dung_Cau_Hoi = noidung,
                Phuong_An_Dung = da,
                Ma_Chuong = ((dynamic)cbbChuong.SelectedItem).Value.ToString(),
            };
            tn.Cau_Hoi.Add(newCauHoi);
            tn.SaveChanges();

            string maMon = ((dynamic)cbbMon.SelectedItem).Value.ToString();

            // Tạo danh sách các phương án chọn
            List<Phuong_An_Chon> phuongAns = new List<Phuong_An_Chon>
            {
                new Phuong_An_Chon { Ma_Cau_Hoi = newCauHoi.Ma_Cau_Hoi, Phuong_An_Chon1 = "a", Noi_Dung_Phuong_An = txtA.Text.Trim() },
                new Phuong_An_Chon { Ma_Cau_Hoi = newCauHoi.Ma_Cau_Hoi, Phuong_An_Chon1 = "b", Noi_Dung_Phuong_An = txtB.Text.Trim() },
                new Phuong_An_Chon { Ma_Cau_Hoi = newCauHoi.Ma_Cau_Hoi, Phuong_An_Chon1 = "c", Noi_Dung_Phuong_An = txtC.Text.Trim() },
                new Phuong_An_Chon { Ma_Cau_Hoi = newCauHoi.Ma_Cau_Hoi, Phuong_An_Chon1 = "d", Noi_Dung_Phuong_An = txtD.Text.Trim() }
            };
            tn.Phuong_An_Chon.AddRange(phuongAns);

            // Thêm câu hỏi và các phương án vào cơ sở dữ liệu
            tn.SaveChanges();

            MessageBox.Show("Câu hỏi đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật DataGridView
            int rowNew = dgvDSKT.Rows.Add();
            dgvDSKT.Rows[rowNew].Cells[0].Value = newCauHoi.Ma_Cau_Hoi; // Mã câu hỏi
            dgvDSKT.Rows[rowNew].Cells[1].Value = newCauHoi.Noi_Dung_Cau_Hoi; // Nội dung câu hỏi
            dgvDSKT.Rows[rowNew].Cells[6].Value = newCauHoi.Phuong_An_Dung; // Phương án đúng
            dgvDSKT.Rows[rowNew].Cells[7].Value = maMon; // Phương án đúng
            dgvDSKT.Rows[rowNew].Cells[8].Value = newCauHoi.Ma_Chuong; // Mã chương

            // Thêm đáp án vào DataGridView
            foreach (var answer in phuongAns)
            {
                switch (answer.Phuong_An_Chon1.ToLower())
                {
                    case "a":
                        dgvDSKT.Rows[rowNew].Cells[2].Value = answer.Noi_Dung_Phuong_An;
                        break;
                    case "b":
                        dgvDSKT.Rows[rowNew].Cells[3].Value = answer.Noi_Dung_Phuong_An;
                        break;
                    case "c":
                        dgvDSKT.Rows[rowNew].Cells[4].Value = answer.Noi_Dung_Phuong_An;
                        break;
                    case "d":
                        dgvDSKT.Rows[rowNew].Cells[5].Value = answer.Noi_Dung_Phuong_An;
                        break;
                }
            }
            SetNull();
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
                MessageBox.Show("Không tìm thấy câu hỏi cần xóa.", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maCauHoi = txtMaCauHoi.Text.Trim();

                // Delete Phuong_An_Chon records first
                var phuongAnToRemove = tn.Phuong_An_Chon.Where(pa => pa.Ma_Cau_Hoi == maCauHoi).ToList();
                if (phuongAnToRemove.Any())
                {
                    tn.Phuong_An_Chon.RemoveRange(phuongAnToRemove);
                    tn.SaveChanges();
                }

                // Then delete the Cau_Hoi record
                var cauHoiToRemove = tn.Cau_Hoi.FirstOrDefault(ch => ch.Ma_Cau_Hoi == maCauHoi);
                if (cauHoiToRemove != null)
                {
                    tn.Cau_Hoi.Remove(cauHoiToRemove);
                    tn.SaveChanges();

                    
                }
                dgvDSKT.Rows.RemoveAt(row);
                MessageBox.Show("Câu hỏi đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SetNull();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
            if (dgvDSKT.CurrentRow != null)
            {
                // Kiểm tra xem các trường nhập liệu có rỗng không
                if (checkNull())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Kiểm trùng đáp án
                if (CheckDuplicateAnswers())
                {
                    MessageBox.Show("Các đáp án không được trùng nhau.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị thông báo xác nhận trước khi sửa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa câu hỏi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Nếu người dùng chọn "Không", thoát khỏi hàm
                }

                // Lấy mã câu hỏi từ hàng được chọn
                string maCauHoi = dgvDSKT.CurrentRow.Cells[0].Value.ToString();
                var cauHoiToUpdate = tn.Cau_Hoi.FirstOrDefault(ch => ch.Ma_Cau_Hoi == maCauHoi);

                if (cauHoiToUpdate != null)
                {
                    // Cập nhật thông tin câu hỏi
                    cauHoiToUpdate.Noi_Dung_Cau_Hoi = txtNoiDung.Text.Trim();
                    cauHoiToUpdate.Phuong_An_Dung = cbbDapAn.Text.Trim();
                    cauHoiToUpdate.Ma_Chuong = ((dynamic)cbbChuong.SelectedItem).Value.ToString();

                    // Cập nhật các phương án chọn
                    var phuongAnsToUpdate = tn.Phuong_An_Chon.Where(pa => pa.Ma_Cau_Hoi == maCauHoi).ToList();
                    foreach (var phuongAn in phuongAnsToUpdate)
                    {
                        switch (phuongAn.Phuong_An_Chon1.ToLower())
                        {
                            case "a":
                                phuongAn.Noi_Dung_Phuong_An = txtA.Text.Trim();
                                break;
                            case "b":
                                phuongAn.Noi_Dung_Phuong_An = txtB.Text.Trim();
                                break;
                            case "c":
                                phuongAn.Noi_Dung_Phuong_An = txtC.Text.Trim();
                                break;
                            case "d":
                                phuongAn.Noi_Dung_Phuong_An = txtD.Text.Trim();
                                break;
                        }
                    }

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    tn.SaveChanges();

                    // Cập nhật lại DataGridView
                    dgvDSKT.CurrentRow.Cells[1].Value = cauHoiToUpdate.Noi_Dung_Cau_Hoi;
                    dgvDSKT.CurrentRow.Cells[6].Value = cauHoiToUpdate.Phuong_An_Dung;
                    dgvDSKT.CurrentRow.Cells[8].Value = cauHoiToUpdate.Ma_Chuong;

                    // Cập nhật lại các phương án trong DataGridView
                    foreach (var phuongAn in phuongAnsToUpdate)
                    {
                        switch (phuongAn.Phuong_An_Chon1.ToLower())
                        {
                            case "a":
                                dgvDSKT.CurrentRow.Cells[2].Value = phuongAn.Noi_Dung_Phuong_An;
                                break;
                            case "b":
                                dgvDSKT.CurrentRow.Cells[3].Value = phuongAn.Noi_Dung_Phuong_An;
                                break;
                            case "c":
                                dgvDSKT.CurrentRow.Cells[4].Value = phuongAn.Noi_Dung_Phuong_An;
                                break;
                            case "d":
                                dgvDSKT.CurrentRow.Cells[5].Value = phuongAn.Noi_Dung_Phuong_An;
                                break;
                        }
                    }

                    MessageBox.Show("Câu hỏi đã được sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SetNull();
        }
        private bool CheckDuplicateAnswers()
        {
            HashSet<string> answers = new HashSet<string>();

            if (!string.IsNullOrWhiteSpace(txtA.Text))
                answers.Add(txtA.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtB.Text))
                answers.Add(txtB.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtC.Text))
                answers.Add(txtC.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtD.Text))
                answers.Add(txtD.Text.Trim());

            // Kiểm tra số lượng đáp án khác nhau
            return answers.Count != 4; // Nếu có ít hơn 4 đáp án khác nhau thì có đáp án trùng
        }

        private bool CheckTrungMaKT(string maKT)
        {
            var existingKT = tn.Cau_Hoi.FirstOrDefault(k => k.Ma_Cau_Hoi == maKT);
            return existingKT != null;
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Đặt lại trạng thái các nút
            setButton(true);
        }


    }
}
