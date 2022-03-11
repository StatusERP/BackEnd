using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixParenttesco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Accion",
                schema: "ERPADMIN",
                table: "Parentesco",
                newName: "AccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Parentesco_AccionId",
                schema: "ERPADMIN",
                table: "Parentesco",
                column: "AccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parentesco_Accion_AccionId",
                schema: "ERPADMIN",
                table: "Parentesco",
                column: "AccionId",
                principalSchema: "ERPADMIN",
                principalTable: "Accion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parentesco_Accion_AccionId",
                schema: "ERPADMIN",
                table: "Parentesco");

            migrationBuilder.DropIndex(
                name: "IX_Parentesco_AccionId",
                schema: "ERPADMIN",
                table: "Parentesco");

            migrationBuilder.RenameColumn(
                name: "AccionId",
                schema: "ERPADMIN",
                table: "Parentesco",
                newName: "Accion");
        }
    }
}
