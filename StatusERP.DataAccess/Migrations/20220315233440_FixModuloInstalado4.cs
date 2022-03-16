using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixModuloInstalado4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<int>(
                name: "ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ModuloInstalado_ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                column: "ConjuntoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloInstalado_Conjuntos_ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                column: "ConjuntoId",
                principalSchema: "ERPADMIN",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuloInstalado_Conjuntos_ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.DropIndex(
                name: "IX_ModuloInstalado_ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.DropColumn(
                name: "ConjuntoId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");
        }
    }
}
