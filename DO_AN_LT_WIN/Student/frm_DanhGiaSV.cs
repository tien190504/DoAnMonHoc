using DO_AN_LT_WIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Student
{
    public partial class frm_DanhGiaSV : Form
    {
        DBContext DBContext = new DBContext();
        public string makq;
        public frm_DanhGiaSV()
        {
            InitializeComponent();
        }

        private void btn_luudanhgia_Click(object sender, EventArgs e)
        {
            string madg;
            var allMaDG = DBContext.Danh_Gia_Cua_Sinh_Vien.Select(b => b.Ma_Danh_Gia).ToList();
            int lastdg = allMaDG
                .Select(k => int.TryParse(k.Substring(2), out int id) ? id : 0) // Chỉ phân tích những mã hợp lệ
                .DefaultIfEmpty(0)
                .Max();
            madg = "DG" + (lastdg + 1).ToString(); ;
            var danhgia = new Danh_Gia_Cua_Sinh_Vien()
            {
                Ma_Danh_Gia = madg,
                Ma_Ket_Qua = makq,
                Noi_Dung_Danh_Gia = txt_danhgia.Text.Trim(),
            };
            DBContext.Danh_Gia_Cua_Sinh_Vien.Add(danhgia);
            DBContext.SaveChanges();
            MessageBox.Show("Lưu đánh giá thành công");
            Application.Exit();
        }
    }
}
