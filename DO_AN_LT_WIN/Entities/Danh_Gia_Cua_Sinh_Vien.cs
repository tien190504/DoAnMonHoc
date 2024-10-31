namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Danh_Gia_Cua_Sinh_Vien
    {
        [Key]
        [StringLength(10)]
        public string Ma_Danh_Gia { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Ket_Qua { get; set; }

        [StringLength(255)]
        public string Noi_Dung_Danh_Gia { get; set; }

        public virtual Ket_Qua_Thi Ket_Qua_Thi { get; set; }
    }
}
