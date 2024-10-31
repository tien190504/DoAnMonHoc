using DO_AN_LT_WIN.Entities;
using DO_AN_LT_WIN.Reportings;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReport : Form
    {
        private string maMon = "";
        public frmReport(string maMon)
        {
            InitializeComponent();
            this.maMon = maMon;
            txtMaMonHoc.Text = maMon;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            HienThi(maMon);
        }

        private void HienThi(string maMon)
        {
            //using (var _dbConntext = new DBContext())
            //{
            //    string TruyVan = "SELECT b.Ma_Bai_Thi, b.Ma_Sinh_Vien, u.Ho, u.Ten, " +
            //        "b.Thoi_Gian_Bat_Dau, b.Thoi_Gian_Ket_Thuc, kt.So_Luong_Cau_Hoi, " +
            //        "b.So_Cau_Dung, k.Diem\r\nFROM Bai_Thi b JOIN [User] u " +
            //        "ON b.Ma_Sinh_Vien = u.Ma_Sinh_Vien\r\n\t\t\t   LEFT JOIN Ket_Qua_Thi " +
            //        "k ON b.Ma_Bai_Thi = k.Ma_Bai_Thi\r\n\t\t\t   JOIN Ky_Thi kt ON b.Ma_Ky_Thi = " +
            //        "kt.Ma_Ky_Thi\r\nWHERE b.Ma_Mon_Hoc = '" + maMon.Trim() + "'";

            //    List<ThongKeDiem> ds = _dbConntext.Database.SqlQuery<ThongKeDiem>(TruyVan).ToList();


            //    rpvDiem.LocalReport.ReportPath = "ReportDiem.rdlc";
            //    var reportDataSource = new ReportDataSource("DiemDataSet", ds);
            //    this.rpvDiem.LocalReport.DataSources.Clear();
            //    this.rpvDiem.LocalReport.DataSources.Add(reportDataSource);
            //    this.rpvDiem.RefreshReport();
            //}
            DBContext context = new DBContext();
            var listThongKe = (from b in context.Bai_Thi
                               join u in context.Users on b.Ma_Sinh_Vien equals u.Ma_Sinh_Vien
                               join k in context.Ket_Qua_Thi on b.Ma_Bai_Thi equals k.Ma_Bai_Thi into g
                               from k in g.DefaultIfEmpty() // Left Join
                               join kt in context.Ky_Thi on b.Ma_Ky_Thi equals kt.Ma_Ky_Thi
                               where b.Ma_Mon_Hoc == maMon.Trim()
                               select new ThongKeDiem
                               {
                                   Ma_Bai_Thi = b.Ma_Bai_Thi,
                                   Ma_Sinh_Vien = u.Ma_Sinh_Vien,
                                   Ho = u.Ho,
                                   Ten = u.Ten,
                                   Thoi_Gian_Bat_Dau = (DateTime)b.Thoi_Gian_Bat_Dau,
                                   Thoi_Gian_Ket_Thuc = (DateTime)b.Thoi_Gian_Ket_Thuc,
                                   So_Luong_Cau_Hoi = (int)kt.So_Luong_Cau_Hoi,
                                   So_Cau_Dung = (int)b.So_Cau_Dung,
                                   Diem = (float)(k.Diem ?? 0) // Chuyển đổi giá trị điểm, nếu null thì mặc định là 0
                               }).ToList();

            // Đặt report data source
            ReportDataSource reportDataSource = new ReportDataSource("DiemDataSet", listThongKe);
            this.rpvDiem.LocalReport.DataSources.Clear();
            this.rpvDiem.LocalReport.DataSources.Add(reportDataSource);

            // Set path cho .rdlc file
            this.rpvDiem.LocalReport.ReportPath = "ReportDiem.rdlc";

            // Refresh ReportViewer
            this.rpvDiem.RefreshReport();
        }
    }
}