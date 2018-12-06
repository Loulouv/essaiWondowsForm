namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<COMMON_EQUIPMENT> COMMON_EQUIPMENT { get; set; }
        public virtual DbSet<COMMON_EQUIPMENT_CATEGORY> COMMON_EQUIPMENT_CATEGORY { get; set; }
        public virtual DbSet<CONSERVATION_CATEGORY> CONSERVATION_CATEGORY { get; set; }
        public virtual DbSet<INGREDIENT> INGREDIENTs { get; set; }
        public virtual DbSet<INGREDIENT_CATEGORY> INGREDIENT_CATEGORY { get; set; }
        public virtual DbSet<INGREDIENT_USE> INGREDIENT_USE { get; set; }
        public virtual DbSet<KITCHEN_EQUIPMENT_USE> KITCHEN_EQUIPMENT_USE { get; set; }
        public virtual DbSet<KITECHEN_EQUIPMENT> KITECHEN_EQUIPMENT { get; set; }
        public virtual DbSet<RECIPE> RECIPEs { get; set; }
        public virtual DbSet<RECIPE_CATEGORY> RECIPE_CATEGORY { get; set; }
        public virtual DbSet<ROOM_EQUIPMENT> ROOM_EQUIPMENT { get; set; }
        public virtual DbSet<ROOM_EQUIPMENT_CATEGORY> ROOM_EQUIPMENT_CATEGORY { get; set; }
        public virtual DbSet<STOCK> STOCKs { get; set; }
        public virtual DbSet<STOCK_CATEGORY> STOCK_CATEGORY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COMMON_EQUIPMENT>()
                .Property(e => e.common_equipment_name)
                .IsUnicode(false);

            modelBuilder.Entity<COMMON_EQUIPMENT_CATEGORY>()
                .Property(e => e.commmon_equipment_category__name)
                .IsUnicode(false);

            modelBuilder.Entity<COMMON_EQUIPMENT_CATEGORY>()
                .HasMany(e => e.COMMON_EQUIPMENT)
                .WithRequired(e => e.COMMON_EQUIPMENT_CATEGORY)
                .HasForeignKey(e => e.commmon_equipment_category_id_COMMON_EQUIPMENT_CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONSERVATION_CATEGORY>()
                .Property(e => e.conservation_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<CONSERVATION_CATEGORY>()
                .HasMany(e => e.INGREDIENTs)
                .WithRequired(e => e.CONSERVATION_CATEGORY)
                .HasForeignKey(e => e.conservation_category_id_CONSERVATION_CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INGREDIENT>()
                .Property(e => e.ingredient_name)
                .IsUnicode(false);

            modelBuilder.Entity<INGREDIENT>()
                .HasMany(e => e.INGREDIENT_USE)
                .WithRequired(e => e.INGREDIENT)
                .HasForeignKey(e => e.ingredient_id_INGREDIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INGREDIENT>()
                .HasMany(e => e.STOCKs)
                .WithRequired(e => e.INGREDIENT)
                .HasForeignKey(e => e.ingredient_id_INGREDIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INGREDIENT_CATEGORY>()
                .Property(e => e.ingredient_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<INGREDIENT_CATEGORY>()
                .HasMany(e => e.INGREDIENTs)
                .WithRequired(e => e.INGREDIENT_CATEGORY)
                .HasForeignKey(e => e.ingredient_category_id_INGREDIENT_CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KITECHEN_EQUIPMENT>()
                .Property(e => e.kitchen_equipment_name)
                .IsUnicode(false);

            modelBuilder.Entity<KITECHEN_EQUIPMENT>()
                .HasMany(e => e.KITCHEN_EQUIPMENT_USE)
                .WithRequired(e => e.KITECHEN_EQUIPMENT)
                .HasForeignKey(e => e.kitchen_equipment_id_KITECHEN_EQUIPMENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RECIPE>()
                .Property(e => e.recipe_name)
                .IsUnicode(false);

            modelBuilder.Entity<RECIPE>()
                .Property(e => e.recipe_number_people)
                .IsUnicode(false);

            modelBuilder.Entity<RECIPE>()
                .Property(e => e.recipe_description)
                .IsUnicode(false);

            modelBuilder.Entity<RECIPE>()
                .Property(e => e.recipe_accompaniment)
                .IsUnicode(false);

            modelBuilder.Entity<RECIPE>()
                .HasMany(e => e.INGREDIENT_USE)
                .WithRequired(e => e.RECIPE)
                .HasForeignKey(e => e.recipe_id_RECIPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RECIPE>()
                .HasMany(e => e.KITCHEN_EQUIPMENT_USE)
                .WithRequired(e => e.RECIPE)
                .HasForeignKey(e => e.recipe_id_RECIPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RECIPE_CATEGORY>()
                .Property(e => e.reciep_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<RECIPE_CATEGORY>()
                .HasMany(e => e.RECIPEs)
                .WithRequired(e => e.RECIPE_CATEGORY)
                .HasForeignKey(e => e.recipe_category_id_RECIPE_CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROOM_EQUIPMENT>()
                .Property(e => e.room_equipment_name)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM_EQUIPMENT_CATEGORY>()
                .Property(e => e.room_equipment_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM_EQUIPMENT_CATEGORY>()
                .HasMany(e => e.ROOM_EQUIPMENT)
                .WithRequired(e => e.ROOM_EQUIPMENT_CATEGORY)
                .HasForeignKey(e => e.room_equipment_category_id_ROOM_EQUIPMENT_CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STOCK_CATEGORY>()
                .Property(e => e.stock_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<STOCK_CATEGORY>()
                .HasMany(e => e.STOCKs)
                .WithRequired(e => e.STOCK_CATEGORY)
                .HasForeignKey(e => e.stock_category_id_STOCK_CATEGORY)
                .WillCascadeOnDelete(false);
        }
    }
}
