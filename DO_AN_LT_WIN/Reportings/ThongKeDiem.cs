using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_LT_WIN.Reportings
{
    public class ThongKeDiem
    {
        public string Ma_Bai_Thi { get; set; }
        public string Ma_Sinh_Vien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime Thoi_Gian_Bat_Dau { get; set; }
        public DateTime Thoi_Gian_Ket_Thuc { get; set; }
        public int So_Cau_Dung { get; set; }
        public int So_Luong_Cau_Hoi { get; set; }
        public float Diem { get; set; }
    }
}
