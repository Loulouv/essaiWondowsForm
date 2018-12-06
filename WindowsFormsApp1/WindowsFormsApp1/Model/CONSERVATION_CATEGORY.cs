namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONSERVATION_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONSERVATION_CATEGORY()
        {
            INGREDIENTs = new HashSet<INGREDIENT>();
        }

        [Key]
        public int conservation_category_id { get; set; }

        [Required]
        [StringLength(25)]
        public string conservation_category_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENT> INGREDIENTs { get; set; }
    }
}
