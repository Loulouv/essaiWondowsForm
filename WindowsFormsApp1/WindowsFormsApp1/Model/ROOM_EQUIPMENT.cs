namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROOM_EQUIPMENT
    {
        [Key]
        public int room_equipment_id { get; set; }

        [Required]
        [StringLength(25)]
        public string room_equipment_name { get; set; }

        public int room_equipment_quantity { get; set; }

        public int room_equipment_category_id_ROOM_EQUIPMENT_CATEGORY { get; set; }

        public virtual ROOM_EQUIPMENT_CATEGORY ROOM_EQUIPMENT_CATEGORY { get; set; }
    }
}
