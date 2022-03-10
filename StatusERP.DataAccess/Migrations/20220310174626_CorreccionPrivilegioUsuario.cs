using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CorreccionPrivilegioUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conjunto",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.RenameColumn(
                name: "Accion",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                newName: "ConjuntoId");

            migrationBuilder.AlterColumn<int>(
                name: "Usuario",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClasificacionesInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodClasificacion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Agrupacion = table.Column<short>(type: "smallint", nullable: false),
                    UsaNumerosSerie = table.Column<bool>(type: "bit", nullable: false),
                    PlantillaSerie = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AporteCodigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TipoCodigoBarras = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionesInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsecutivo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Mascara = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiguienteConsec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Editable = table.Column<bool>(type: "bit", nullable: false),
                    MultiplesTrans = table.Column<bool>(type: "bit", nullable: false),
                    FormatoImp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UltFechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TodasTrans = table.Column<bool>(type: "bit", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    UsaTraslado = table.Column<bool>(type: "bit", nullable: false),
                    EmailCFDI = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsecutivosInvUsuarios",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsecutivosInvUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExistenciaLotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodega = table.Column<int>(type: "int", nullable: false),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    Localización = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    CantDisponible = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantReservada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantNoAprobada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantVencida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantRemitida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistenciaLotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngresosLotes",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Articulo = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<int>(type: "int", nullable: false),
                    SecuenciaLote = table.Column<int>(type: "int", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CantidadIngresada = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosLotes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasificacionesInv",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosInv",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConsecutivosInvUsuarios",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ExistenciaLotes",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "IngresosLotes",
                schema: "H2C");

            migrationBuilder.DropColumn(
                name: "AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.RenameColumn(
                name: "ConjuntoId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                newName: "Accion");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Conjunto",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
