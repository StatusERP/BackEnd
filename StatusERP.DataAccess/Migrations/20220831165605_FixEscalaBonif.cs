using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixEscalaBonif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropColumn(
                name: "ArticuloBonif",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.RenameColumn(
                name: "Version",
                schema: "H2C",
                table: "EscalasBonif",
                newName: "VersionNivelId");

            migrationBuilder.RenameColumn(
                name: "CodEscalaBonif",
                schema: "H2C",
                table: "EscalasBonif",
                newName: "NumEscalaBonif");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "EscalasBonif",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "EscalasBonif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EscalasBonif_ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif",
                column: "ArticuloBonifId");

            migrationBuilder.CreateIndex(
                name: "IX_EscalasBonif_ArticuloId",
                schema: "H2C",
                table: "EscalasBonif",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IxVersNiv_Art_NumEscala_VerBon",
                schema: "H2C",
                table: "EscalasBonif",
                columns: new[] { "VersionNivelId", "ArticuloId", "NumEscalaBonif", "VersionBonif" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EscalasBonif_Articulos_ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif",
                column: "ArticuloBonifId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EscalasBonif_Articulos_ArticuloId",
                schema: "H2C",
                table: "EscalasBonif",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EscalasBonif_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "EscalasBonif",
                column: "VersionNivelId",
                principalSchema: "H2C",
                principalTable: "VersionesNivelPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EscalasBonif_Articulos_ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalasBonif_Articulos_ArticuloId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalasBonif_VersionesNivelPrecio_VersionNivelId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropIndex(
                name: "IX_EscalasBonif_ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropIndex(
                name: "IX_EscalasBonif_ArticuloId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropIndex(
                name: "IxVersNiv_Art_NumEscala_VerBon",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropColumn(
                name: "ArticuloBonifId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "EscalasBonif");

            migrationBuilder.RenameColumn(
                name: "VersionNivelId",
                schema: "H2C",
                table: "EscalasBonif",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "NumEscalaBonif",
                schema: "H2C",
                table: "EscalasBonif",
                newName: "CodEscalaBonif");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltModif",
                schema: "H2C",
                table: "EscalasBonif",
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
                table: "EscalasBonif",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArticuloBonif",
                schema: "H2C",
                table: "EscalasBonif",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "EscalasBonif",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "EscalasBonif",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
