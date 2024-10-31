namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Giang_Day
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Ma_Giang_Vien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        public int? So_buoi_day { get; set; }

        public virtual Giang_Vien Giang_Vien { get; set; }

        public virtual Mon_Hoc Mon_Hoc { get; set; }
    }
}
