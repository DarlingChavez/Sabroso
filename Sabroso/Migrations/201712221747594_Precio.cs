namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Precio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CabeceraCompra", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AddColumn("dbo.DetalleCompra", "PrecioUnitario", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AddColumn("dbo.DetalleCompra", "Subtotal", c => c.Decimal(nullable: false, precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetalleCompra", "Subtotal");
            DropColumn("dbo.DetalleCompra", "PrecioUnitario");
            DropColumn("dbo.CabeceraCompra", "Total");
        }
    }
}
