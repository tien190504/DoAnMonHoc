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
    public partial class frm_MonVaChuong : Form
    {
        DBContext DBContext = new DBContext();
        public string magiangvien;
        public frm_MonVaChuong()
        {
            InitializeComponent();
            cb_mon.SelectedIndexChanged += Cb_mon_SelectedIndexChanged;
            cb_mon.SelectedIndex = -1;
            cb_chuong.SelectedIndex = -1;
        }

        private void MonVaChuong_Load(object sender, EventArgs e)
        {
            List<CT_Giang_Day> listGiangDay = DBContext.CT_Giang_Day.ToList();
            List<Mon_Hoc> listMonHoc = DBContext.Mon_Hoc.ToList();
            FillctGiangDayCombobox(listGiangDay, listMonHoc);
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

            this.cb_mon.DataSource = filteredGiangDay;
            this.cb_mon.DisplayMember = "Ten_Mon_Hoc";
            this.cb_mon.ValueMember = "Ma_Mon_Hoc";
        }
        private void Cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mon.SelectedValue != null)
            {
                string selectedMaMonHoc = cb_mon.SelectedValue.ToString();
                List<Chuong> listChuong = DBContext.Chuongs
                    .Where(c => c.Ma_Mon_Hoc == selectedMaMonHoc)
                    .ToList();

                FillChuongCombobox(listChuong);
            }
        }
        private void FillChuongCombobox(List<Chuong> listChuong)
        {
            cb_chuong.DataSource = listChuong;
            cb_chuong.DisplayMember = "Ten_Chuong";
            cb_chuong.ValueMember = "Ma_Chuong";
        }

        private void btn_XemCacCauHoi_Click(object sender, EventArgs e)
        {
            // Lấy mã môn học và mã chương từ ComboBox
            string selectedMaMonHoc = cb_mon.SelectedValue?.ToString();
            string selectedMaChuong = cb_chuong.SelectedValue?.ToString();

            // Kiểm tra nếu selectedMaChuong không null hoặc empty
            if (!string.IsNullOrEmpty(selectedMaChuong))
            {
                frm_CauHoi frmCauHoi = new frm_CauHoi();
                frmCauHoi.machuong = selectedMaChuong;
                frmCauHoi.StartPosition = FormStartPosition.CenterParent;
                frmCauHoi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chương.");
            }
        }
    }
}
