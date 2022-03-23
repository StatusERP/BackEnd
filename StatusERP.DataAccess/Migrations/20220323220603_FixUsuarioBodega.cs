using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixUsuarioBodega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bodega",
                schema: "H2C",
                table: "UsuarioBodega");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "UsuarioBodega",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "UsuarioBodega",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioBodega_BodegaId",
                schema: "H2C",
                table: "UsuarioBodega",
                column: "BodegaId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioBodega_Bodegas_BodegaId",
                schema: "H2C",
                table: "UsuarioBodega",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioBodega_Bodegas_BodegaId",
                schema: "H2C",
                table: "UsuarioBodega");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioBodega_BodegaId",
                schema: "H2C",
                table: "UsuarioBodega");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "UsuarioBodega");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "UsuarioBodega",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddColumn<string>(
                name: "Bodega",
                schema: "H2C",
                table: "UsuarioBodega",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
