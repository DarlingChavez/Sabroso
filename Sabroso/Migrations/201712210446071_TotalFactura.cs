namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalFactura : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CabeceraFactura", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.CabeceraFactura", "Total");
        }
    }
}
