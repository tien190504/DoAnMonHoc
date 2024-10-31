using DO_AN_LT_WIN.Admin.Chung;
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
    public partial class frm_PhuongAnChon : Form
    {
        public string macauhoi;
        DBContext DBContext = new DBContext();
        public frm_PhuongAnChon()
        {
            InitializeComponent();
        }

        private void frm_PhuongAnChon_Load(object sender, EventArgs e)
        {
            List<Phuong_An_Chon> listPA = DBContext.Phuong_An_Chon
                .Where(ch => ch.Ma_Cau_Hoi == macauhoi)
                .ToList();
            BindGrid(listPA);
            if(dgv_PhuongAn.Rows.Count == 4)
            {
                btn_Them.Enabled = false;
            }
            setGridViewStyle(dgv_PhuongAn);
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
        private void BindGrid(List<Phuong_An_Chon> listPA)
        {
            dgv_PhuongAn.Rows.Clear();
            foreach (var item in listPA)
            {
                int index = dgv_PhuongAn.Rows.Add();
                dgv_PhuongAn.Rows[index].Cells[0].Value = item.Ma_Phuong_An.ToString();
                dgv_PhuongAn.Rows[index].Cells[1].Value = item.Ma_Cau_Hoi.Trim();
                dgv_PhuongAn.Rows[index].Cells[2].Value = item.Noi_Dung_Phuong_An.Trim();
                dgv_PhuongAn.Rows[index].Cells[3].Value = item.Phuong_An_Chon1.Trim();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_noidungpa.Text == "" || txt_pa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin phương án!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(txt_pa.Text.Length > 1 || txt_pa.Text.Contains("a")|| txt_pa.Text.Contains("b")|| txt_pa.Text.Contains("C")|| txt_pa.Text.Contains("d"))
            {
                MessageBox.Show("Vui lòng nhập phương án gồm (a,b,c,d)", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Phuong_An_Chon newpa = new Phuong_An_Chon
            {
                Ma_Cau_Hoi = macauhoi.Trim(),
                Noi_Dung_Phuong_An = txt_noidungpa.Text.Trim(),
                Phuong_An_Chon1 = txt_pa.Text.Trim()
            };

            DBContext.Phuong_An_Chon.Add(newpa);
            DBContext.SaveChanges();
            MessageBox.Show("Thêm câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
            List<Phuong_An_Chon> listPA = DBContext.Phuong_An_Chon
                .Where(ch => ch.Ma_Cau_Hoi == macauhoi)
                .ToList();
            BindGrid(listPA);
            txt_stt.Clear();
            txt_macauhoi.Clear();
            txt_noidungpa.Clear();
            txt_pa.Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_noidungpa.Text == "" || txt_pa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin phương án!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txt_pa.Text.Length > 1 || txt_pa.Text.Contains("a") || txt_pa.Text.Contains("b") || txt_pa.Text.Contains("C") || txt_pa.Text.Contains("d"))
            {
                MessageBox.Show("Vui lòng nhập phương án gồm (a,b,c,d)", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int maPhuongAn;
            if (!int.TryParse(txt_stt.Text, out maPhuongAn))
            {
                MessageBox.Show("Mã phương án không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cauHoiToUpdate = DBContext.Phuong_An_Chon.Find(maPhuongAn);
            if (cauHoiToUpdate != null)
            {
                cauHoiToUpdate.Noi_Dung_Phuong_An = txt_noidungpa.Text;
                cauHoiToUpdate.Phuong_An_Chon1 = txt_pa.Text;
                DBContext.SaveChanges();
                List<Phuong_An_Chon> listPA = DBContext.Phuong_An_Chon
                .Where(ch => ch.Ma_Cau_Hoi == macauhoi)
                .ToList();
                BindGrid(listPA);
                MessageBox.Show("Sửa câu hỏi thành công", "Thông báo", MessageBoxButtons.OK);
                txt_stt.Clear();
                txt_macauhoi.Clear();
                txt_noidungpa.Clear();
                txt_pa.Clear();
            }
            else
            {
                MessageBox.Show("Câu hỏi không tìm thấy trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_PhuongAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_PhuongAn.Rows[e.RowIndex];
                txt_stt.Text = row.Cells[0].Value.ToString();
                txt_macauhoi.Text = row.Cells[1].Value.ToString();
                txt_noidungpa.Text = row.Cells[2].Value.ToString();
                txt_pa.Text = row.Cells[3].Value.ToString();
            }
        }

    }
}
