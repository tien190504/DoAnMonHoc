namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ket_Qua_Thi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ket_Qua_Thi()
        {
            Danh_Gia_Cua_Sinh_Vien = new HashSet<Danh_Gia_Cua_Sinh_Vien>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Ket_Qua { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Bai_Thi { get; set; }

        public double? Diem { get; set; }

        public virtual Bai_Thi Bai_Thi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danh_Gia_Cua_Sinh_Vien> Danh_Gia_Cua_Sinh_Vien { get; set; }
    }
}
