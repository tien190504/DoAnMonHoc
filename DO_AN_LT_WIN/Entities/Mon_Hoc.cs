namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mon_Hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon_Hoc()
        {
            Chuongs = new HashSet<Chuong>();
            CT_Giang_Day = new HashSet<CT_Giang_Day>();
            CT_Mon_Hoc = new HashSet<CT_Mon_Hoc>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        [Required]
        [StringLength(255)]
        public string Ten_Mon_Hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuong> Chuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Giang_Day> CT_Giang_Day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Mon_Hoc> CT_Mon_Hoc { get; set; }
    }
}
