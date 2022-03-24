using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixDivisionesGeograficas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DivGeograficas2_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.RenameColumn(
                name: "Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                newName: "PaisId");

            migrationBuilder.RenameIndex(
                name: "IX_DivGeograficas2_Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                newName: "IX_DivGeograficas2_PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_DivGeograficas2_Paises_PaisId",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "PaisId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DivGeograficas2_Paises_PaisId",
                schema: "H2C",
                table: "DivGeograficas2");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                schema: "H2C",
                table: "DivGeograficas2",
                newName: "Pais");

            migrationBuilder.RenameIndex(
                name: "IX_DivGeograficas2_PaisId",
                schema: "H2C",
                table: "DivGeograficas2",
                newName: "IX_DivGeograficas2_Pais");

            migrationBuilder.AddForeignKey(
                name: "FK_DivGeograficas2_Paises_Pais",
                schema: "H2C",
                table: "DivGeograficas2",
                column: "Pais",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
