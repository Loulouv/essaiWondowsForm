namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMMON_EQUIPMENT_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMMON_EQUIPMENT_CATEGORY()
        {
            COMMON_EQUIPMENT = new HashSet<COMMON_EQUIPMENT>();
        }

        [Key]
        public int commmon_equipment_category_id { get; set; }

        [Required]
        [StringLength(25)]
        public string commmon_equipment_category__name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMON_EQUIPMENT> COMMON_EQUIPMENT { get; set; }
    }
}
