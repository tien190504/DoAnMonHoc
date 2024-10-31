namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cau_Hoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cau_Hoi()
        {
            CT_Bai_Thi = new HashSet<CT_Bai_Thi>();
            Phuong_An_Chon = new HashSet<Phuong_An_Chon>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Cau_Hoi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Chuong { get; set; }

        [Required]
        [StringLength(255)]
        public string Noi_Dung_Cau_Hoi { get; set; }

        [Required]
        [StringLength(1)]
        public string Phuong_An_Dung { get; set; }

        public virtual Chuong Chuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Bai_Thi> CT_Bai_Thi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phuong_An_Chon> Phuong_An_Chon { get; set; }
    }
}
