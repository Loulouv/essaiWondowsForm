namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCK")]
    public partial class STOCK
    {
        [Key]
        public int stock_id { get; set; }

        public DateTime stock_date { get; set; }

        public int stock_quantity { get; set; }

        public double stock_price { get; set; }

        public int stock_category_id_STOCK_CATEGORY { get; set; }

        public int ingredient_id_INGREDIENT { get; set; }

        public virtual INGREDIENT INGREDIENT { get; set; }

        public virtual STOCK_CATEGORY STOCK_CATEGORY { get; set; }
    }
}
