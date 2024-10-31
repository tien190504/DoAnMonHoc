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

namespace DO_AN_LT_WIN.Teacher
{
    public partial class frm_CauHoi : Form
    {
        DBContext DBContext = new DBContext();
        public string machuong;

        public frm_CauHoi()
        {
            InitializeComponent();
        }

        private void frmCauHoi_Load(object sender, EventArgs e)
        {
            List<Cau_Hoi> listCauHoi = DBContext.Cau_Hoi
                .Where(ch => ch.Ma_Chuong == machuong)
                .ToList();
            BindGrid(listCauHoi);
            setGridViewStyle(dgv_cauhoi);
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
        private void BindGrid(List<Cau_Hoi> listCauHoi)
        {
            dgv_cauhoi.Rows.Clear();
            foreach (var item in listCauHoi)
            {
                int index = dgv_cauhoi.Rows.Add();
                dgv_cauhoi.Rows[index].Cells[0].Value = item.Ma_Cau_Hoi.Trim();
                dgv_cauhoi.Rows[index].Cells[1].Value = item.Noi_Dung_Cau_Hoi.Trim();
                dgv_cauhoi.Rows[index].Cells[2].Value = item.Phuong_An_Dung.Trim();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_macauhoi.Text.Contains(" "))
            {
                MessageBox.Show("Không sử dụng (space)","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (string.IsNullOrWhiteSpace(txt_macauhoi.Text)||string.IsNullOrWhiteSpace(txt_noidungcauhoi.Text) || string.IsNullOrWhiteSpace(txt_phuongandung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin câu hỏi và phương án đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cau_Hoi newCauHoi = new Cau_Hoi
            {
                Ma_Cau_Hoi = txt_macauhoi.Text.Trim(),
                Ma_Chuong = machuong.Trim(), 
                Noi_Dung_Cau_Hoi = txt_noidungcauhoi.Text.Trim(),
                Phuong_An_Dung = txt_phuongandung.Text.Trim()
            };

            DBContext.Cau_Hoi.Add(newCauHoi);
            DBContext.SaveChanges();

            List<Cau_Hoi> updatedListCauHoi = DBContext.Cau_Hoi
                .Where(ch => ch.Ma_Chuong == machuong)
                .ToList();
            BindGrid(updatedListCauHoi);
            MessageBox.Show("Thêm câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
            txt_macauhoi.Clear();
            txt_noidungcauhoi.Clear();
            txt_phuongandung.Clear();
        }
        private void dgv_cauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_cauhoi.Rows[e.RowIndex];
                txt_macauhoi.Text = row.Cells[0].Value.ToString();
                txt_noidungcauhoi.Text = row.Cells[1].Value.ToString();
                txt_phuongandung.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_macauhoi.Text) || string.IsNullOrWhiteSpace(txt_noidungcauhoi.Text) || string.IsNullOrWhiteSpace(txt_phuongandung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin câu hỏi và phương án đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_macauhoi.Text))
            {
                MessageBox.Show("Mã câu hỏi không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cauHoiToUpdate = DBContext.Cau_Hoi.Find(txt_macauhoi.Text);
            if (cauHoiToUpdate != null)
            {
                cauHoiToUpdate.Noi_Dung_Cau_Hoi = txt_noidungcauhoi.Text;
                cauHoiToUpdate.Phuong_An_Dung = txt_phuongandung.Text;

                DBContext.SaveChanges();

                List<Cau_Hoi> updatedListCauHoi = DBContext.Cau_Hoi
                    .Where(ch => ch.Ma_Chuong == machuong)
                    .ToList();
                BindGrid(updatedListCauHoi);
                MessageBox.Show("Sửa câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
                //MessageBox.Show("Vui lòng thêm các phương án cho câu hỏi.", "Lưu ý:Câu đúng phải trùng với đáp án đúng", MessageBoxButtons.OK);
                //btn_xemPA_Click(sender, e);

                // Optionally clear the input fields
                txt_noidungcauhoi.Clear();
                txt_phuongandung.Clear();
            }
            else
            {
                MessageBox.Show("Câu hỏi không tìm thấy trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xemPA_Click(object sender, EventArgs e)
        {
            frm_PhuongAnChon form1 = new frm_PhuongAnChon();
            form1.macauhoi = txt_macauhoi.Text;
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.ShowDialog();
        }
    }
}
