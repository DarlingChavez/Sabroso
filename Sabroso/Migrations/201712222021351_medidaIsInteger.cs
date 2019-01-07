namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class medidaIsInteger : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producto", "Medida", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Medida", c => c.String(nullable: false, unicode: false));
        }
    }
}
