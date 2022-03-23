using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix3GlobalesAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodBodega",
                schema: "H2C",
                table: "Localizaciones");

            migrationBuilder.AddColumn<bool>(
                name: "Activa",
                schema: "H2C",
                table: "Localizaciones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "Localizaciones",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Localizaciones_BodegaId",
                schema: "H2C",
                table: "Localizaciones",
                column: "BodegaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Localizaciones_Bodegas_BodegaId",
                schema: "H2C",
                table: "Localizaciones",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Localizaciones_Bodegas_BodegaId",
                schema: "H2C",
                table: "Localizaciones");

            migrationBuilder.DropIndex(
                name: "IX_Localizaciones_BodegaId",
                schema: "H2C",
                table: "Localizaciones");

            migrationBuilder.DropColumn(
                name: "Activa",
                schema: "H2C",
                table: "Localizaciones");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "Localizaciones");

            migrationBuilder.AddColumn<string>(
                name: "CodBodega",
                schema: "H2C",
                table: "Localizaciones",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
