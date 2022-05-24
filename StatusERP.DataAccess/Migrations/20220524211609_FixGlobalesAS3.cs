using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobalesAS3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Paises_PaisId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_PaisId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "PaisId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AlterColumn<int>(
                name: "PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisLocalId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Paises_PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisLocalId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Paises_PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AlterColumn<int>(
                name: "PaisLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Paises_PaisId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "PaisId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
