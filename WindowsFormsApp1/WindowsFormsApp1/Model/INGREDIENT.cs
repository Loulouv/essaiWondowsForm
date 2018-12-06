namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INGREDIENT")]
    public partial class INGREDIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INGREDIENT()
        {
            INGREDIENT_USE = new HashSet<INGREDIENT_USE>();
            STOCKs = new HashSet<STOCK>();
        }

        [Key]
        public int ingredient_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ingredient_name { get; set; }

        public int ingredient_conservation_time { get; set; }

        public int ingredient_category_id_INGREDIENT_CATEGORY { get; set; }

        public int conservation_category_id_CONSERVATION_CATEGORY { get; set; }

        public virtual CONSERVATION_CATEGORY CONSERVATION_CATEGORY { get; set; }

        public virtual INGREDIENT_CATEGORY INGREDIENT_CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENT_USE> INGREDIENT_USE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCK> STOCKs { get; set; }
    }
}
