namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Subtotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetalleFactura", "PrecioUnitario", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AddColumn("dbo.DetalleFactura", "Subtotal", c => c.Decimal(nullable: false, precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetalleFactura", "Subtotal");
            DropColumn("dbo.DetalleFactura", "PrecioUnitario");
        }
    }
}
