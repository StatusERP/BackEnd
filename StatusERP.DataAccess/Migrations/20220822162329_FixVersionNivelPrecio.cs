using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixVersionNivelPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "VersionesNivelPrecio");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "VersionesNivelPrecio");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAprobacion",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IxNivelPrecioId_Version",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                columns: new[] { "NivelPrecioId", "Version" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VersionesNivelPrecio_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                column: "NivelPrecioId",
                principalSchema: "H2C",
                principalTable: "NivelesPrecios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VersionesNivelPrecio_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "VersionesNivelPrecio");

            migrationBuilder.DropIndex(
                name: "IxNivelPrecioId_Version",
                schema: "H2C",
                table: "VersionesNivelPrecio");

            migrationBuilder.DropColumn(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "VersionesNivelPrecio");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAprobacion",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "VersionesNivelPrecio",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
