using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixEscalaDcto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.RenameColumn(
                name: "Version",
                schema: "H2C",
                table: "EscalasDcto",
                newName: "VersionNivelId");

            migrationBuilder.RenameColumn(
                name: "CodEscalaDcto",
                schema: "H2C",
                table: "EscalasDcto",
                newName: "NumEscalaDcto");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "EscalasDcto",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "EscalasDcto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EscalasDcto_ArticuloId",
                schema: "H2C",
                table: "EscalasDcto",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IxVersNiv_Art_NumEscala_VerDcto",
                schema: "H2C",
                table: "EscalasDcto",
                columns: new[] { "VersionNivelId", "ArticuloId", "NumEscalaDcto", "VersionDcto" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EscalasDcto_Articulos_ArticuloId",
                schema: "H2C",
                table: "EscalasDcto",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EscalasDcto_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "EscalasDcto",
                column: "VersionNivelId",
                principalSchema: "H2C",
                principalTable: "VersionesNivelPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EscalasDcto_Articulos_ArticuloId",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalasDcto_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropIndex(
                name: "IX_EscalasDcto_ArticuloId",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropIndex(
                name: "IxVersNiv_Art_NumEscala_VerDcto",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "EscalasDcto");

            migrationBuilder.RenameColumn(
                name: "VersionNivelId",
                schema: "H2C",
                table: "EscalasDcto",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "NumEscalaDcto",
                schema: "H2C",
                table: "EscalasDcto",
                newName: "CodEscalaDcto");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "EscalasDcto",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "EscalasDcto",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "EscalasDcto",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "EscalasDcto",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
