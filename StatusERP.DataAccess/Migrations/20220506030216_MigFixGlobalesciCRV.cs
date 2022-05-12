using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigFixGlobalesciCRV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.CreateIndex(
                name: "IX_GlobalesCI_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "PaqueteContableId");


            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "PaqueteContableId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id");

          

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesCI_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesCI_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaquetesInv",
                schema: "H2C",
                table: "PaquetesInv");

            migrationBuilder.RenameTable(
                name: "PaquetesInv",
                schema: "H2C",
                newName: "PaqueteInv",
                newSchema: "H2C");

            migrationBuilder.RenameColumn(
                name: "FechaUltAcceso",
                schema: "H2C",
                table: "PaqueteInv",
                newName: "FechaUltAceso");

            migrationBuilder.RenameColumn(
                name: "CodPaqueteInv",
                schema: "H2C",
                table: "PaqueteInv",
                newName: "PaqueteInventario");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "H2C",
                table: "PaquetesContables",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "LoteProveedor",
                schema: "H2C",
                table: "Lotes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreador",
                schema: "H2C",
                table: "PaqueteInv",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "UltimoUsuario",
                schema: "H2C",
                table: "PaqueteInv",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaqueteInv",
                schema: "H2C",
                table: "PaqueteInv",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaquetesContables_GlobalesCI_Id",
                schema: "H2C",
                table: "PaquetesContables",
                column: "Id",
                principalSchema: "H2C",
                principalTable: "GlobalesCI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
