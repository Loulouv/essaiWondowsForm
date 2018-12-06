namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RECIPE")]
    public partial class RECIPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECIPE()
        {
            INGREDIENT_USE = new HashSet<INGREDIENT_USE>();
            KITCHEN_EQUIPMENT_USE = new HashSet<KITCHEN_EQUIPMENT_USE>();
        }

        [Key]
        public int recipe_id { get; set; }

        [Required]
        [StringLength(25)]
        public string recipe_name { get; set; }

        [Required]
        [StringLength(50)]
        public string recipe_number_people { get; set; }

        public int recipe_preparation_time { get; set; }

        public int recipe_cooking_time { get; set; }

        [Required]
        [StringLength(126)]
        public string recipe_description { get; set; }

        public int recipe_rest { get; set; }

        [Required]
        [StringLength(25)]
        public string recipe_accompaniment { get; set; }

        public int recipe_category_id_RECIPE_CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENT_USE> INGREDIENT_USE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KITCHEN_EQUIPMENT_USE> KITCHEN_EQUIPMENT_USE { get; set; }

        public virtual RECIPE_CATEGORY RECIPE_CATEGORY { get; set; }
    }
}
