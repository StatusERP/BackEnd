using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobalesFA_NivelPrecioImp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonedaImp1",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivPrecioImp1",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.AddColumn<int>(
                name: "NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioImp1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioImp1Id",
                principalSchema: "H2C",
                principalTable: "NivelesPrecios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivelPrecioImp1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.AddColumn<string>(
                name: "MonedaImp1",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NivPrecioImp1",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);
        }
    }
}
