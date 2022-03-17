using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaArticulo",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 4);

            migrationBuilder.CreateTable(
                name: "AjustesConfig",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodAjusteConfig = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AjusteBase = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    Ingreso = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjustesConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AjustesSubSubTipo",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AjusteConfig = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    SubsubtipoId = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjustesSubSubTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AjustesSubTipo",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AjusteConfig = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    SubTipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjustesSubTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosInvDet",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaqueteInventario = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DocumentoInv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LineaDocInv = table.Column<int>(type: "int", nullable: false),
                    AjusteConfig = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Localización = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Subtipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Subsubtipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PrecioTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    BodegaDestino = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    LocalizacionDest = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Secuencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SerieCadena = table.Column<int>(type: "int", nullable: true),
                    UnidadDistribucio = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoOperacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosInvDet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AjustesConfig",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "AjustesSubSubTipo",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "AjustesSubTipo",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DocumentosInvDet",
                schema: "H2C");

            migrationBuilder.AlterColumn<decimal>(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos",
                type: "decimal(18,2)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "CategoriaArticulo",
                schema: "H2C",
                table: "Articulos",
                type: "decimal(18,2)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);
        }
    }
}
