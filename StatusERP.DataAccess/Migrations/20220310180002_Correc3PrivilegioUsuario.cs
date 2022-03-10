using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Correc3PrivilegioUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegioUsuario_AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                column: "AccionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegioUsuario_ConjuntoId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                column: "ConjuntoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegioUsuario_Accion_AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                column: "AccionId",
                principalSchema: "ERPADMIN",
                principalTable: "Accion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegioUsuario_Conjuntos_ConjuntoId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                column: "ConjuntoId",
                principalSchema: "ERPADMIN",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivilegioUsuario_Accion_AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivilegioUsuario_Conjuntos_ConjuntoId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PrivilegioUsuario_AccionId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PrivilegioUsuario_ConjuntoId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario");

            migrationBuilder.AddColumn<int>(
                name: "Usuario",
                schema: "ERPADMIN",
                table: "PrivilegioUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
