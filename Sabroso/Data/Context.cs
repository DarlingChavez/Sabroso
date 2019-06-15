using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Sabroso
{
    public class Context : DbContext
    {
        public Context() : base("default")
        {

        }





        public DbSet<CabeceraCompra> CabeceraCompra { get; set; }
        public DbSet<CabeceraFactura> CabeceraFactura { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleCompra> DetalleCompra { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<decimal>().Configure(c => c.HasPrecision(18, 6));
        }

    }
}
