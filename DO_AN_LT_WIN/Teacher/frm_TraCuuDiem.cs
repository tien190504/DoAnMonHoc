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
    public partial class frm_TraCuuDiem : Form
    {
        DBContext DBContext = new DBContext();
        public string magiangvien;
        public frm_TraCuuDiem()
        {
            InitializeComponent();
        }

        private void frm_TraCuuDiem_Load(object sender, EventArgs e)
        {
            List<Mon_Hoc> listmonhoc = DBContext.Mon_Hoc.ToList();
            List<Ky_Thi> listkythi = DBContext.Ky_Thi.ToList();
            List<CT_Giang_Day> listGiangDay = DBContext.CT_Giang_Day.ToList();
            FillctGiangDayCombobox(listGiangDay, listmonhoc);
            FillKyThiCombobox(listkythi);
            cb_Mon.SelectedIndex = -1;
            setGridViewStyle(dgv_tracuu);
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
        private void FillctGiangDayCombobox(List<CT_Giang_Day> listGiangDay, List<Mon_Hoc> listMonHoc)
        {
            var filteredGiangDay = listGiangDay
                .Where(k => k.Ma_Giang_Vien == magiangvien)
                .Join(listMonHoc,
                      giangDay => giangDay.Ma_Mon_Hoc,
                      monHoc => monHoc.Ma_Mon_Hoc,
                      (giangDay, monHoc) => new { Ma_Mon_Hoc = monHoc.Ma_Mon_Hoc, Ten_Mon_Hoc = monHoc.Ten_Mon_Hoc })
                .ToList();

            this.cb_Mon.DataSource = filteredGiangDay;
            this.cb_Mon.DisplayMember = "Ten_Mon_Hoc";
            this.cb_Mon.ValueMember = "Ma_Mon_Hoc";
        } 
        private void FillKyThiCombobox(List<Ky_Thi> listkythi)
        {
            cb_KyThi.DataSource = listkythi;
            cb_KyThi.DisplayMember = "Ten_Ky_Thi";
            cb_KyThi.ValueMember = "Ma_Ky_Thi";
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            string selectedMaMonHoc = cb_Mon.SelectedValue?.ToString();
            string selectedKyThi = cb_KyThi.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedMaMonHoc) || string.IsNullOrEmpty(selectedKyThi))
            {
                MessageBox.Show("Vui lòng chọn môn học cần xem");
                return;
            }
            using (var context = new DBContext())
            {
                var filteredData = context.Bai_Thi
                    .Where(record => record.Ma_Mon_Hoc == selectedMaMonHoc)
                    .Select(record => new
                    {
                        MaBaiThi = record.Ma_Bai_Thi,
                        MaSinhVien = record.Ma_Sinh_Vien,
                        batdau = record.Thoi_Gian_Bat_Dau,
                        ketthuc = record.Thoi_Gian_Ket_Thuc,
                        SoCauDung = record.So_Cau_Dung,
                        Diem = record.Ket_Qua_Thi.FirstOrDefault().Diem,
                    }).ToList();
                dgv_tracuu.Rows.Clear();
                foreach (var item in filteredData)
                {
                    dgv_tracuu.Rows.Add(item.MaBaiThi, item.MaSinhVien,item.batdau,item.ketthuc, item.SoCauDung, item.Diem);
                }
            }
        }

        private void txtReport_Click(object sender, EventArgs e)
        {
            if(cb_Mon.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn thi để REPORT", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maMonHoc = cb_Mon.SelectedValue.ToString();
            frmReport f = new frmReport(maMonHoc);
            f.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgv_tracuu.Rows.Clear();
            cb_Mon.SelectedIndex = -1;
            txtHoTenSV.Text = "";
            txtMaSV.Text = "";
        }

        private void dgv_tracuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgv_tracuu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiem.Text = dgv_tracuu.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSV.Text;
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                using (var context = new DBContext())
                {
                    var sinhVien = context.Users
                        .Where(u => u.Ma_Sinh_Vien == maSinhVien)
                        .Select(u => new { HoTen = u.Ho + " " + u.Ten })
                        .FirstOrDefault();

                    if (sinhVien != null)
                    {
                        txtHoTenSV.Text = sinhVien.HoTen;
                    }
                    else
                    {
                        txtHoTenSV.Text = "Không tìm thấy sinh viên";
                    }
                }
            }
            else
            {
                txtHoTenSV.Text = string.Empty;
            }
        }
    }
}
