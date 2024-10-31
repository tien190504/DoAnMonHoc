namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Mon_Hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_Mon_Hoc()
        {
            Bai_Thi = new HashSet<Bai_Thi>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Ma_Ky_Thi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        public DateTime? Ngay_Thi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bai_Thi> Bai_Thi { get; set; }

        public virtual Ky_Thi Ky_Thi { get; set; }

        public virtual Mon_Hoc Mon_Hoc { get; set; }
    }
}
