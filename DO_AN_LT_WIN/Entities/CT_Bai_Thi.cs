namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Bai_Thi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Ma_Bai_Thi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ma_Cau_Hoi { get; set; }

        [StringLength(1)]
        public string SV_Chon { get; set; }

        public virtual Bai_Thi Bai_Thi { get; set; }

        public virtual Cau_Hoi Cau_Hoi { get; set; }
    }
}
