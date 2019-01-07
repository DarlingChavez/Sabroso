namespace Sabroso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CabeceraCompra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdProveedor = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedor", t => t.IdProveedor, cascadeDelete: true)
                .Index(t => t.IdProveedor);
            
            CreateTable(
                "dbo.DetalleCompra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        IdCabeceraCompra = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CabeceraCompra", t => t.IdCabeceraCompra, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.IdProducto, cascadeDelete: true)
                .Index(t => t.IdProducto)
                .Index(t => t.IdCabeceraCompra);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 15, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 40, unicode: false),
                        Categoria = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Medida = c.String(nullable: false, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Codigo, unique: true, name: "Producto_Codigo_Index");
            
            CreateTable(
                "dbo.DetalleFactura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        IdCabeceraFactura = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CabeceraFactura", t => t.IdCabeceraFactura, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.IdProducto, cascadeDelete: true)
                .Index(t => t.IdProducto)
                .Index(t => t.IdCabeceraFactura);
            
            CreateTable(
                "dbo.CabeceraFactura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula = c.String(nullable: false, maxLength: 13, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cedula, unique: true, name: "CabeceraFactura_Cedula_Index");
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ruc = c.String(maxLength: 13, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 40, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Ruc, unique: true, name: "Proveedor_Ruc_Index");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CabeceraCompra", "IdProveedor", "dbo.Proveedor");
            DropForeignKey("dbo.DetalleCompra", "IdProducto", "dbo.Producto");
            DropForeignKey("dbo.DetalleFactura", "IdProducto", "dbo.Producto");
            DropForeignKey("dbo.DetalleFactura", "IdCabeceraFactura", "dbo.CabeceraFactura");
            DropForeignKey("dbo.CabeceraFactura", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.DetalleCompra", "IdCabeceraCompra", "dbo.CabeceraCompra");
            DropIndex("dbo.Proveedor", "Proveedor_Ruc_Index");
            DropIndex("dbo.Cliente", "CabeceraFactura_Cedula_Index");
            DropIndex("dbo.CabeceraFactura", new[] { "IdCliente" });
            DropIndex("dbo.DetalleFactura", new[] { "IdCabeceraFactura" });
            DropIndex("dbo.DetalleFactura", new[] { "IdProducto" });
            DropIndex("dbo.Producto", "Producto_Codigo_Index");
            DropIndex("dbo.DetalleCompra", new[] { "IdCabeceraCompra" });
            DropIndex("dbo.DetalleCompra", new[] { "IdProducto" });
            DropIndex("dbo.CabeceraCompra", new[] { "IdProveedor" });
            DropTable("dbo.Proveedor");
            DropTable("dbo.Cliente");
            DropTable("dbo.CabeceraFactura");
            DropTable("dbo.DetalleFactura");
            DropTable("dbo.Producto");
            DropTable("dbo.DetalleCompra");
            DropTable("dbo.CabeceraCompra");
        }
    }
}
