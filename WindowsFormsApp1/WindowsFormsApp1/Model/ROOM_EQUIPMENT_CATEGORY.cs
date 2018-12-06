namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROOM_EQUIPMENT_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM_EQUIPMENT_CATEGORY()
        {
            ROOM_EQUIPMENT = new HashSet<ROOM_EQUIPMENT>();
        }

        [Key]
        public int room_equipment_category_id { get; set; }

        [Required]
        [StringLength(25)]
        public string room_equipment_category_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM_EQUIPMENT> ROOM_EQUIPMENT { get; set; }
    }
}
