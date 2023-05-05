namespace Lateos.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LateosDBP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 40),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCategoria)
                .ForeignKey("dbo.Estadoes", t => t.IdEstado, cascadeDelete: true)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        Estados = c.String(nullable: false, maxLength: 80),
                        Usuario_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdEstado)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IdUsuario)
                .Index(t => t.Usuario_IdUsuario);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        FechaRegistro = c.DateTime(nullable: false),
                        IdRegistros = c.Int(nullable: false),
                        Estado_IdEstado = c.Int(),
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.Estadoes", t => t.Estado_IdEstado)
                .Index(t => t.Estado_IdEstado);
            
            CreateTable(
                "dbo.Registroes",
                c => new
                    {
                        IdRegistro = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        IdCompraProducto = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdFactura = c.Int(nullable: false),
                        Empleado_IdEmpleado = c.Int(),
                        Rol_IdRol = c.Int(),
                        Cliente_IdCliente = c.Int(),
                        Empresa_IdEmprresa = c.Int(),
                        Log_logId = c.Int(),
                    })
                .PrimaryKey(t => t.IdRegistro)
                .ForeignKey("dbo.Empleadoes", t => t.Empleado_IdEmpleado)
                .ForeignKey("dbo.Rols", t => t.Rol_IdRol)
                .ForeignKey("dbo.Clientes", t => t.Cliente_IdCliente)
                .ForeignKey("dbo.Empresas", t => t.Empresa_IdEmprresa)
                .ForeignKey("dbo.Logs", t => t.Log_logId)
                .Index(t => t.Empleado_IdEmpleado)
                .Index(t => t.Rol_IdRol)
                .Index(t => t.Cliente_IdCliente)
                .Index(t => t.Empresa_IdEmprresa)
                .Index(t => t.Log_logId);
            
            CreateTable(
                "dbo.CompraProductoes",
                c => new
                    {
                        IdCompraProducto = c.Int(nullable: false, identity: true),
                        MarcaProducto = c.String(nullable: false, maxLength: 80),
                        Cantidad = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        Registro_IdRegistro = c.Int(),
                    })
                .PrimaryKey(t => t.IdCompraProducto)
                .ForeignKey("dbo.Registroes", t => t.Registro_IdRegistro)
                .Index(t => t.Registro_IdRegistro);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        IdFactura = c.Int(nullable: false, identity: true),
                        MontoPago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacion = c.String(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Registro_IdRegistro = c.Int(),
                    })
                .PrimaryKey(t => t.IdFactura)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario, cascadeDelete: true)
                .ForeignKey("dbo.Registroes", t => t.Registro_IdRegistro)
                .Index(t => t.IdCliente)
                .Index(t => t.IdUsuario)
                .Index(t => t.Registro_IdRegistro);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Correo = c.String(nullable: false),
                        Clave = c.String(nullable: false),
                        cantidades = c.Int(nullable: false),
                        idEstado = c.Int(nullable: false),
                        IdRol = c.Int(nullable: false),
                        IdRegistro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        IdEmpleado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Apellido = c.String(maxLength: 80),
                        Direccion = c.String(maxLength: 80),
                        FechaRegistro = c.DateTime(nullable: false),
                        IdRegistro = c.Int(nullable: false),
                        Usuario_IdUsuario = c.Int(),
                        Estado_IdEstado = c.Int(),
                    })
                .PrimaryKey(t => t.IdEmpleado)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IdUsuario)
                .ForeignKey("dbo.Estadoes", t => t.Estado_IdEstado)
                .Index(t => t.Usuario_IdUsuario)
                .Index(t => t.Estado_IdEstado);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        IdRol = c.Int(nullable: false, identity: true),
                        Roles = c.String(nullable: false),
                        IdRegistro = c.Int(nullable: false),
                        Usuario_IdUsuario = c.Int(),
                        Estado_IdEstado = c.Int(),
                    })
                .PrimaryKey(t => t.IdRol)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IdUsuario)
                .ForeignKey("dbo.Estadoes", t => t.Estado_IdEstado)
                .Index(t => t.Usuario_IdUsuario)
                .Index(t => t.Estado_IdEstado);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Nombre = c.String(nullable: false),
                        Decripcion = c.String(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCaducidad = c.DateTime(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        Categorys_IdCategoria = c.Int(),
                        DetalleCompras_IdDetalleCompra = c.Int(),
                        Estado_IdEstado = c.Int(),
                        DetalleFactura_IdDetalleFactura = c.Int(),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Categories", t => t.Categorys_IdCategoria)
                .ForeignKey("dbo.DetalleCompras", t => t.DetalleCompras_IdDetalleCompra)
                .ForeignKey("dbo.Estadoes", t => t.Estado_IdEstado)
                .ForeignKey("dbo.DetalleFacturas", t => t.DetalleFactura_IdDetalleFactura)
                .Index(t => t.Categorys_IdCategoria)
                .Index(t => t.DetalleCompras_IdDetalleCompra)
                .Index(t => t.Estado_IdEstado)
                .Index(t => t.DetalleFactura_IdDetalleFactura);
            
            CreateTable(
                "dbo.DetalleCompras",
                c => new
                    {
                        IdDetalleCompra = c.Int(nullable: false, identity: true),
                        CantidadProductos = c.String(nullable: false, maxLength: 80),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdCompraProducto = c.Int(nullable: false),
                        IdInventario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleCompra)
                .ForeignKey("dbo.CompraProductoes", t => t.IdCompraProducto, cascadeDelete: true)
                .Index(t => t.IdCompraProducto);
            
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        IdInventario = c.Int(nullable: false, identity: true),
                        IdProduto = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        DetalleCompra_IdDetalleCompra = c.Int(),
                        Producto_IdProducto = c.Int(),
                        DetalleFactura_IdDetalleFactura = c.Int(),
                    })
                .PrimaryKey(t => t.IdInventario)
                .ForeignKey("dbo.DetalleCompras", t => t.DetalleCompra_IdDetalleCompra)
                .ForeignKey("dbo.Productoes", t => t.Producto_IdProducto)
                .ForeignKey("dbo.DetalleFacturas", t => t.DetalleFactura_IdDetalleFactura)
                .Index(t => t.DetalleCompra_IdDetalleCompra)
                .Index(t => t.Producto_IdProducto)
                .Index(t => t.DetalleFactura_IdDetalleFactura);
            
            CreateTable(
                "dbo.DetalleFacturas",
                c => new
                    {
                        IdDetalleFactura = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        subTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdProducto = c.Int(nullable: false),
                        IdInventario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleFactura);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        IdEmprresa = c.Int(nullable: false, identity: true),
                        NombreComercial = c.String(nullable: false, maxLength: 80),
                        NombreLegal = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Rubro = c.String(nullable: false),
                        IdRegistro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmprresa);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        logId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Usuario = c.String(nullable: false, maxLength: 80),
                        Tabla = c.String(nullable: false, maxLength: 80),
                        Accion = c.String(nullable: false, maxLength: 80),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        IdRegistro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.logId);
            
            CreateTable(
                "dbo.UsuarioRegistroes",
                c => new
                    {
                        Usuario_IdUsuario = c.Int(nullable: false),
                        Registro_IdRegistro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_IdUsuario, t.Registro_IdRegistro })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IdUsuario, cascadeDelete: true)
                .ForeignKey("dbo.Registroes", t => t.Registro_IdRegistro, cascadeDelete: true)
                .Index(t => t.Usuario_IdUsuario)
                .Index(t => t.Registro_IdRegistro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registroes", "Log_logId", "dbo.Logs");
            DropForeignKey("dbo.Registroes", "Empresa_IdEmprresa", "dbo.Empresas");
            DropForeignKey("dbo.Productoes", "DetalleFactura_IdDetalleFactura", "dbo.DetalleFacturas");
            DropForeignKey("dbo.Inventarios", "DetalleFactura_IdDetalleFactura", "dbo.DetalleFacturas");
            DropForeignKey("dbo.Inventarios", "Producto_IdProducto", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "Estado_IdEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Productoes", "DetalleCompras_IdDetalleCompra", "dbo.DetalleCompras");
            DropForeignKey("dbo.Inventarios", "DetalleCompra_IdDetalleCompra", "dbo.DetalleCompras");
            DropForeignKey("dbo.DetalleCompras", "IdCompraProducto", "dbo.CompraProductoes");
            DropForeignKey("dbo.Productoes", "Categorys_IdCategoria", "dbo.Categories");
            DropForeignKey("dbo.Rols", "Estado_IdEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Empleadoes", "Estado_IdEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Clientes", "Estado_IdEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Registroes", "Cliente_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Facturas", "Registro_IdRegistro", "dbo.Registroes");
            DropForeignKey("dbo.Facturas", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Rols", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Registroes", "Rol_IdRol", "dbo.Rols");
            DropForeignKey("dbo.UsuarioRegistroes", "Registro_IdRegistro", "dbo.Registroes");
            DropForeignKey("dbo.UsuarioRegistroes", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Estadoes", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Empleadoes", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Registroes", "Empleado_IdEmpleado", "dbo.Empleadoes");
            DropForeignKey("dbo.Facturas", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.CompraProductoes", "Registro_IdRegistro", "dbo.Registroes");
            DropForeignKey("dbo.Categories", "IdEstado", "dbo.Estadoes");
            DropIndex("dbo.UsuarioRegistroes", new[] { "Registro_IdRegistro" });
            DropIndex("dbo.UsuarioRegistroes", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.Inventarios", new[] { "DetalleFactura_IdDetalleFactura" });
            DropIndex("dbo.Inventarios", new[] { "Producto_IdProducto" });
            DropIndex("dbo.Inventarios", new[] { "DetalleCompra_IdDetalleCompra" });
            DropIndex("dbo.DetalleCompras", new[] { "IdCompraProducto" });
            DropIndex("dbo.Productoes", new[] { "DetalleFactura_IdDetalleFactura" });
            DropIndex("dbo.Productoes", new[] { "Estado_IdEstado" });
            DropIndex("dbo.Productoes", new[] { "DetalleCompras_IdDetalleCompra" });
            DropIndex("dbo.Productoes", new[] { "Categorys_IdCategoria" });
            DropIndex("dbo.Rols", new[] { "Estado_IdEstado" });
            DropIndex("dbo.Rols", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.Empleadoes", new[] { "Estado_IdEstado" });
            DropIndex("dbo.Empleadoes", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.Facturas", new[] { "Registro_IdRegistro" });
            DropIndex("dbo.Facturas", new[] { "IdUsuario" });
            DropIndex("dbo.Facturas", new[] { "IdCliente" });
            DropIndex("dbo.CompraProductoes", new[] { "Registro_IdRegistro" });
            DropIndex("dbo.Registroes", new[] { "Log_logId" });
            DropIndex("dbo.Registroes", new[] { "Empresa_IdEmprresa" });
            DropIndex("dbo.Registroes", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.Registroes", new[] { "Rol_IdRol" });
            DropIndex("dbo.Registroes", new[] { "Empleado_IdEmpleado" });
            DropIndex("dbo.Clientes", new[] { "Estado_IdEstado" });
            DropIndex("dbo.Estadoes", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.Categories", new[] { "IdEstado" });
            DropTable("dbo.UsuarioRegistroes");
            DropTable("dbo.Logs");
            DropTable("dbo.Empresas");
            DropTable("dbo.DetalleFacturas");
            DropTable("dbo.Inventarios");
            DropTable("dbo.DetalleCompras");
            DropTable("dbo.Productoes");
            DropTable("dbo.Rols");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Facturas");
            DropTable("dbo.CompraProductoes");
            DropTable("dbo.Registroes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Categories");
        }
    }
}
