using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ERPADMIN");

            migrationBuilder.EnsureSchema(
                name: "H2C");

            migrationBuilder.CreateTable(
                name: "Accion",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    NombreAccion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreConstante = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    EsModulo = table.Column<bool>(type: "bit", nullable: false),
                    EsEstandar = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Subtipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Tabla = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Invocacion = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TypeDocument = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasProveedor",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaProveedor = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasProveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentroCuenta",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroCuenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentrosCosto",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AceptaDatos = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosCosto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cobradores",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCobrador = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicionesPago",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DiasNeto = table.Column<int>(type: "int", nullable: false),
                    PagosParciales = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoContado = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCondPago = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PlazoCondPago = table.Column<int>(type: "int", nullable: true),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionesPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosGlobales",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivoGlobal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Longitud = table.Column<int>(type: "int", nullable: false),
                    Entidad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FormatoImpresionDetallado = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FormatoImpresionResumido = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ValorInicial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ValorFinal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoValor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaHoraUlt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosGlobales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivoUsuario",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivoUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuadreAuxiliar",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCuadreCG = table.Column<int>(type: "int", nullable: false),
                    TablaOrigen = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DebitoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuadreAuxiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuadreConta",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCuadreCG = table.Column<int>(type: "int", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Linea = table.Column<int>(type: "int", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cuenta = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaDescrip = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Centro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CentroDescrip = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Fuente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DebitoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuadreConta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuadresCG",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCuadreCG = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Modulo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Filtros = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cuentas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Otros = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Tab = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuadresCG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaContable",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SeccionCuenta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoDetallado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    SaldoNormal = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Conversion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCambio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AceptaDatos = table.Column<bool>(type: "bit", nullable: false),
                    UsaCentroCosto = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsoRestringido = table.Column<bool>(type: "bit", nullable: false),
                    OrigenConversion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaContable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiarioDet",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fuente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DebitoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiarioDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiarioEnc",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ClaseAsiento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TotalDebitoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalDebitoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalCreditoLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalCreditoDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalControlLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TotalControlDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaUltModif = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Marcado = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiarioEnc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diferido",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodDiferido = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoOriginal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Amortizado = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PendienteAmortizar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Modalidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ValorModalidad = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtrDiferido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtaDiferido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtrContraAsiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtaContraAsiento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtrAmortizacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtaAmortizacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtrGastoIngreso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtaGastoIngreso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaAudIng = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAudIng = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHoraAnulacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAnulacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DiferidoOrigen = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    CostoLocF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CostoDolF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CostoLocC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CostoDolC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ModalidadC = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ValorModalidadC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizacionLocF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizacionDolF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizacionLocC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizacionDolC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizadoLocF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizadoDolF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizadoLocC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AmortizadoDolC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PendienteAmortLocF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PendienteAmortDolF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PendienteAmortLocC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    PendienteAmortDolC = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    AsientoCorp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Marcado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioMarcado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ConceptoME = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DesgloseIMP = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diferido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivGeograficas1",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodDivGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivGeograficas1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivGeograficas2",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodDivGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CodDivGeografica2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivGeograficas2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocTributarios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodDocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigitoVerificador = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoContribuyente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    NRC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Giro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DUI = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Pasaporte = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Carnet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Otro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InfoLegal = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTributarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesFinancieras",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodEntidadFinanciera = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CodElectronico = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesFinancieras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesAS",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAdvIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAdvFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTrabajoIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTrabajoFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMoneda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SimboloMoneda = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Impuesto1Desc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Impuesto2Desc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PaisLocal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MonedaLocal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MonedaDolar = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TipoCambioDolar = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PatronCeCo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesCG",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtaPerdDifCamDol = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaPerdDifCamLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TipAsntCierreAn = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Patron = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtrDifCambioLocal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCambioLocal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDifCambioDolar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCambioDolar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaDifCamFiscal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDifCamCorp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCierreFiscal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCierreCorp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesCierreFiscal = table.Column<short>(type: "smallint", nullable: false),
                    MesCierreCorp = table.Column<short>(type: "smallint", nullable: false),
                    UltimoAsiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NumAsientoGlobal = table.Column<bool>(type: "bit", nullable: false),
                    NombreAsiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CantDecimales = table.Column<short>(type: "smallint", nullable: false),
                    TruncarConversion = table.Column<bool>(type: "bit", nullable: false),
                    CtrCierre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCierre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AjusAnFiscPend = table.Column<bool>(type: "bit", nullable: false),
                    AjusAnCorpPend = table.Column<bool>(type: "bit", nullable: false),
                    PermiteMovRojo = table.Column<bool>(type: "bit", nullable: false),
                    AuxReverMovRojo = table.Column<bool>(type: "bit", nullable: false),
                    CtrPerdDifCamLoc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrPerdDifCamDol = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NombreContaFiscal = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NombreContaCorp = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CtrDifCamLocUtiReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCamLocUtiReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDifCamDolUtiReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCamDolUtiReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDifCamLocPerReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCamLocPerReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDifCamDolPerReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDifCamDolPerReali = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DobleControl = table.Column<bool>(type: "bit", nullable: false),
                    NombreContador = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    NombreRevisor = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    NombreRepresentante = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    FirmaContador = table.Column<byte>(type: "tinyint", nullable: true),
                    FirmaRevisor = table.Column<byte>(type: "tinyint", nullable: true),
                    FirmaRepresentante = table.Column<byte>(type: "tinyint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesCG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoUsuario",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grupo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Impuestos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Impuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Impuesto2 = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    UsaImpuesto2Cantidad = table.Column<bool>(type: "bit", nullable: false),
                    Impuesto2Cantidad = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CalculoImp2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoContabImp1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoContabImp2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ContabDevImp1 = table.Column<bool>(type: "bit", nullable: false),
                    ContabDevImp2 = table.Column<bool>(type: "bit", nullable: false),
                    CtrImp1Gen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp1Gen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp2Gen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp2Gen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp1GenVts = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp1GenVts = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp2GenVts = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp2GenVts = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp1DesComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp1DesComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp2DesComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp2DesComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp1DevComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp1DevComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp2DevComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp2DevComp = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp1DevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp1DevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImp2DevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImp2DevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TipoImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoImpuesto2 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoTarifa1 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    TipoTarifa2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localizaciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodLocalizacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Volumen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PesoMaximo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodLote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LoteProveedor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCuarentena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoIngreso = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimoIngreso = table.Column<int>(type: "int", nullable: false),
                    FechaFabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MayorAuditoria",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayorAuditoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MayorDet",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Fuente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DebitoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ClaseAsiento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayorDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MayorEnc",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MayorAuditoria = table.Column<int>(type: "int", nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ClaseAsiento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaUltModif = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exportado = table.Column<bool>(type: "bit", nullable: false),
                    TipoIngresoMayor = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayorEnc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membresia",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMembresia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Vigencia = table.Column<int>(type: "int", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membresia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMoneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CodigoISO = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelesPrecios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodNivelPrecio = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CondicionPago = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    EsquemaTrabajo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Descuentos = table.Column<bool>(type: "bit", nullable: false),
                    SugerirDescuento = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelesPrecios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodigoISO = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoVen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostoLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaGasCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaComisionCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntCorriente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRentaCP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EtiquetaDivGeo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EtiquetaDivGeo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaquetesContables",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPaquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UsuarioCreador = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FechaUltAcceso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoAsientoFiscal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UltimoAsientoCorp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Marcado = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaquetesContables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parentesco",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    Padre = table.Column<int>(type: "int", nullable: false),
                    NumeroHermano = table.Column<short>(type: "smallint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentesco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodosContables",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contabilidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FinPeriodoAnual = table.Column<bool>(type: "bit", nullable: false),
                    Abierto = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodosContables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegioUsuario",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Conjunto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegioUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodRuta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaldoCuentas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaldoFiscLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoFiscDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoCorpLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoCorpDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoFiscLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoFiscLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoCorpLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoCorpLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoFiscDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoFiscDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    DebitoCorpDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CreditoCorpDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaldoCuentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodSucursal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCambio",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoCambio = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPartida",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoPartida = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPartida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodUnidadMedida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioBodega",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioBodega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPaquete",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SoloLectura = table.Column<bool>(type: "bit", nullable: false),
                    Aplicacion = table.Column<bool>(type: "bit", nullable: false),
                    Agregar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false),
                    Total = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPaquete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendedor = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodZona = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasClientes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCategoriaCliente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CtrVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCostoId = table.Column<int>(type: "int", nullable: false),
                    CtaVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CuentaContableId = table.Column<int>(type: "int", nullable: false),
                    CtrDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescGral = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostVent = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostVent = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCostLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCostLin = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVendCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVendCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCobrCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCobrCom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContado = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaProntoPagoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntMoraCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRecibosCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDebitoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCreditoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaImpuesto2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro1CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaRubro2CC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAnticipoCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDescBonif = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDevVentas = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrIntCorr = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaIntCorr = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaVentasExen = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteRedondeo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriasClientes_CentrosCosto_CentroCostoId",
                        column: x => x.CentroCostoId,
                        principalSchema: "H2C",
                        principalTable: "CentrosCosto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriasClientes_CuentaContable_CuentaContableId",
                        column: x => x.CuentaContableId,
                        principalSchema: "H2C",
                        principalTable: "CuentaContable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conjuntos",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conjunto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DobleMoneda = table.Column<bool>(type: "bit", nullable: false),
                    DobleContabilidad = table.Column<bool>(type: "bit", nullable: false),
                    UsaLotes = table.Column<bool>(type: "bit", nullable: false),
                    UsaCentroCosto = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionBD = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    UsuarioModBd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHoraModBd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersionInstalada = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsaSucursales = table.Column<bool>(type: "bit", nullable: false),
                    MascaraSucursal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionWeb = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CorreoDocElectronico = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentePercepcion = table.Column<bool>(type: "bit", nullable: false),
                    CalPercepVentas = table.Column<bool>(type: "bit", nullable: false),
                    AgenteRetencion = table.Column<bool>(type: "bit", nullable: false),
                    MembresiaId = table.Column<int>(type: "int", nullable: false),
                    FechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjuntos_Membresia_MembresiaId",
                        column: x => x.MembresiaId,
                        principalSchema: "ERPADMIN",
                        principalTable: "Membresia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bodegas",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodSucursal = table.Column<int>(type: "int", nullable: true),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodegas_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalSchema: "H2C",
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_SucursalId",
                schema: "H2C",
                table: "Bodegas",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CentroCostoId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CentroCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasClientes_CuentaContableId",
                schema: "H2C",
                table: "CategoriasClientes",
                column: "CuentaContableId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjuntos_MembresiaId",
                schema: "ERPADMIN",
                table: "Conjuntos",
                column: "MembresiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accion",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bodegas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CategoriasClientes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CategoriasProveedor",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CentroCuenta",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Cobradores",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CondicionesPago",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Conjuntos",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "ConsecutivosGlobales",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivoUsuario",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuadreAuxiliar",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuadreConta",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuadresCG",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DiarioDet",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DiarioEnc",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Diferido",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DivGeograficas1",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DivGeograficas2",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocTributarios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "EntidadesFinancieras",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesAS",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesCG",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GrupoUsuario",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "Impuestos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Localizaciones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Lotes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MayorAuditoria",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MayorDet",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MayorEnc",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Monedas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "NivelesPrecios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Paises",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PaquetesContables",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Parentesco",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "PeriodosContables",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PrivilegioUsuario",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "Rutas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "SaldoCuentas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposCambio",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposPartida",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "UnidadesMedida",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "UsuarioBodega",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "UsuarioPaquete",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Vendedores",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Zonas",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sucursales",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CentrosCosto",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuentaContable",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Membresia",
                schema: "ERPADMIN");
        }
    }
}
