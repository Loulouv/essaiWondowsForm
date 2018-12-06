namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KITECHEN_EQUIPMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KITECHEN_EQUIPMENT()
        {
            KITCHEN_EQUIPMENT_USE = new HashSet<KITCHEN_EQUIPMENT_USE>();
        }

        [Key]
        public int kitchen_equipment_id { get; set; }

        [Required]
        [StringLength(25)]
        public string kitchen_equipment_name { get; set; }

        public int kitchen_equipment_quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KITCHEN_EQUIPMENT_USE> KITCHEN_EQUIPMENT_USE { get; set; }
    }
}
