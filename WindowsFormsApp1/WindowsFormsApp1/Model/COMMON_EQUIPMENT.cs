namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMMON_EQUIPMENT
    {
        [Key]
        public int common_equipment_id { get; set; }

        [Required]
        [StringLength(25)]
        public string common_equipment_name { get; set; }

        public int common_equipment_quantity { get; set; }

        public int commmon_equipment_category_id_COMMON_EQUIPMENT_CATEGORY { get; set; }

        public virtual COMMON_EQUIPMENT_CATEGORY COMMON_EQUIPMENT_CATEGORY { get; set; }
    }
}
