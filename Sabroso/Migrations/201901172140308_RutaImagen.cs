namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RutaImagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "RutaImagen", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Producto", "RutaImagen");
        }
    }
}
