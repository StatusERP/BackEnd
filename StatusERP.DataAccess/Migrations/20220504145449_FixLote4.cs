using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixLote4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_Bodegas_Sucursales_SucursalId",
            ////    schema: "H2C",
            ////    table: "Bodegas");

            ////migrationBuilder.DropIndex(
            ////    name: "IX_Bodegas_SucursalId",
            ////    schema: "H2C",
            ////    table: "Bodegas");

            ////migrationBuilder.DropPrimaryKey(
            ////    name: "PK_PaqueteInv",
            ////    schema: "H2C",
            ////    table: "PaqueteInv");

            ////migrationBuilder.DropColumn(
                //name: "SucursalId",
                //schema: "H2C",
                //table: "Bodegas");

            ////migrationBuilder.RenameTable(
            ////    name: "PaqueteInv",
            ////    schema: "H2C",
            ////    newName: "PaquetesInv",
            ////    newSchema: "H2C");

            ////migrationBuilder.RenameColumn(
            ////    name: "PaqueteInventario",
            ////    schema: "H2C",
            ////    table: "PaquetesInv",
            ////    newName: "CodPaqueteInv");

            migrationBuilder.AlterColumn<string>(
                name: "LoteProveedor",
                schema: "H2C",
                table: "Lotes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_PaquetesInv",
            //    schema: "H2C",
            //    table: "PaquetesInv",
            //    column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_PaquetesInv",
            //    schema: "H2C",
            //    table: "PaquetesInv");

            //migrationBuilder.RenameTable(
            //    name: "PaquetesInv",
            //    schema: "H2C",
            //    newName: "PaqueteInv",
            //    newSchema: "H2C");

            //migrationBuilder.RenameColumn(
            //    name: "CodPaqueteInv",
            //    schema: "H2C",
            //    table: "PaqueteInv",
            //    newName: "PaqueteInventario");

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

            ////migrationBuilder.AddColumn<int>(
            ////    name: "SucursalId",
            ////    schema: "H2C",
            ////    table: "Bodegas",
            ////    type: "int",
            ////    nullable: true);

            ////migrationBuilder.AddPrimaryKey(
            ////    name: "PK_PaqueteInv",
            ////    schema: "H2C",
            ////    table: "PaqueteInv",
            ////    column: "Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Bodegas_SucursalId",
            //    schema: "H2C",
            //    table: "Bodegas",
            //    column: "SucursalId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Bodegas_Sucursales_SucursalId",
            //    schema: "H2C",
            //    table: "Bodegas",
            //    column: "SucursalId",
            //    principalSchema: "H2C",
            //    principalTable: "Sucursales",
            //    principalColumn: "Id");
        }
    }
}
