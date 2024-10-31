namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phuong_An_Chon
    {
        [Key]
        public int Ma_Phuong_An { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Cau_Hoi { get; set; }

        [Required]
        [StringLength(255)]
        public string Noi_Dung_Phuong_An { get; set; }

        [Column("Phuong_An_Chon")]
        [StringLength(1)]
        public string Phuong_An_Chon1 { get; set; }

        public virtual Cau_Hoi Cau_Hoi { get; set; }
    }
}
