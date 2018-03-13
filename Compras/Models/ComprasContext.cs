namespace Compras.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComprasContext : DbContext
    {
        public ComprasContext()
            : base("name=ComprasContext")
        {
        }

        public virtual DbSet<Accounting_entries> Accounting_entries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Measurement_units> Measurement_units { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounting_entries>()
                .Property(e => e.AsientoContableDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Accounting_entries>()
                .Property(e => e.AsientoContableMonto)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Departments>()
                .Property(e => e.dept_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Items>()
                .Property(e => e.item_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Items>()
                .Property(e => e.unit_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Items>()
                .Property(e => e.item_amount)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Items>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Measurement_units>()
                .Property(e => e.unit_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Orders>()
                .Property(e => e.order_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Orders>()
                .Property(e => e.item_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Orders>()
                .Property(e => e.order_amount)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Orders>()
                .Property(e => e.supplier_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Orders>()
                .Property(e => e.dept_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.supplier_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.cedula)
                .HasPrecision(11, 0);
        }
    }
}
