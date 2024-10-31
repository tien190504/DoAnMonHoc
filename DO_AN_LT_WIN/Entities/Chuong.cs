namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chuong")]
    public partial class Chuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chuong()
        {
            Cau_Hoi = new HashSet<Cau_Hoi>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Chuong { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten_Chuong { get; set; }

        [StringLength(255)]
        public string Mo_Ta { get; set; }

        public DateTime? Thoi_Gian_Tao { get; set; }

        public DateTime? Thoi_Gian_Cap_Nhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cau_Hoi> Cau_Hoi { get; set; }

        public virtual Mon_Hoc Mon_Hoc { get; set; }
    }
}
