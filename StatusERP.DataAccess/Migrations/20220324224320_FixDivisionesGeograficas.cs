using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixDivisionesGeograficas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodDivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.AlterColumn<int>(
                name: "Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AddColumn<int>(
                name: "DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Pais",
                schema: "H2C",
                table: "DivGeograficas1",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.CreateIndex(
                name: "IX_DivGeograficas2_DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "DivGeografica1");

            migrationBuilder.CreateIndex(
                name: "IX_DivGeograficas2_Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "Pais");

            migrationBuilder.CreateIndex(
                name: "IX_DivGeograficas1_Pais",
                schema: "H2C",
                table: "DivGeograficas1",
                column: "Pais");

            migrationBuilder.AddForeignKey(
                name: "FK_DivGeograficas1_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas1",
                column: "Pais",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DivGeograficas2_DivGeograficas1_DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "DivGeografica1",
                principalSchema: "H2C",
                principalTable: "DivGeograficas1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DivGeograficas2_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "Pais",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DivGeograficas1_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas1");

            migrationBuilder.DropForeignKey(
                name: "FK_DivGeograficas2_DivGeograficas1_DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.DropForeignKey(
                name: "FK_DivGeograficas2_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.DropIndex(
                name: "IX_DivGeograficas2_DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.DropIndex(
                name: "IX_DivGeograficas2_Pais",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.DropIndex(
                name: "IX_DivGeograficas1_Pais",
                schema: "H2C",
                table: "DivGeograficas1");

            migrationBuilder.DropColumn(
                name: "DivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CodDivGeografica1",
                schema: "H2C",
                table: "DivGeograficas2",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                schema: "H2C",
                table: "DivGeograficas1",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
