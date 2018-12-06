namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KITCHEN_EQUIPMENT_USE
    {
        public int kitchen_equipment_use_quantity { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int recipe_id_RECIPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kitchen_equipment_id_KITECHEN_EQUIPMENT { get; set; }

        public virtual KITECHEN_EQUIPMENT KITECHEN_EQUIPMENT { get; set; }

        public virtual RECIPE RECIPE { get; set; }
    }
}
