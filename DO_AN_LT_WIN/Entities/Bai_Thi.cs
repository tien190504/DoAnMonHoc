namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bai_Thi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bai_Thi()
        {
            CT_Bai_Thi = new HashSet<CT_Bai_Thi>();
            Ket_Qua_Thi = new HashSet<Ket_Qua_Thi>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Bai_Thi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Sinh_Vien { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Ky_Thi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        public int? So_Cau_Dung { get; set; }

        public int? Lan_Thi { get; set; }

        public DateTime? Thoi_Gian_Bat_Dau { get; set; }

        public DateTime? Thoi_Gian_Ket_Thuc { get; set; }

        public virtual CT_Mon_Hoc CT_Mon_Hoc { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Bai_Thi> CT_Bai_Thi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ket_Qua_Thi> Ket_Qua_Thi { get; set; }
    }
}
