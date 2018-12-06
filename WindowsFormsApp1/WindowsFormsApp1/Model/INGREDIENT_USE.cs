namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INGREDIENT_USE
    {
        public int ingredient_use_quantity { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ingredient_id_INGREDIENT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int recipe_id_RECIPE { get; set; }

        public virtual INGREDIENT INGREDIENT { get; set; }

        public virtual RECIPE RECIPE { get; set; }
    }
}
