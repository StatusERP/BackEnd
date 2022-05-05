using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobCI4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesCI_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    schema: "H2C",
            //    table: "PaquetesContables",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            ////migrationBuilder.AddForeignKey(
            ////    name: "FK_PaquetesContables_GlobalesCI_Id",
            ////    schema: "H2C",
            ////    table: "PaquetesContables",
            ////    column: "Id",
            ////    principalSchema: "H2C",
            ////    principalTable: "GlobalesCI",
            ////    principalColumn: "Id",
            ////    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaquetesContables_GlobalesCI_Id",
                schema: "H2C",
                table: "PaquetesContables");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "H2C",
                table: "PaquetesContables",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
