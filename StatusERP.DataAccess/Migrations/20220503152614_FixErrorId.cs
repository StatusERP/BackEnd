using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixErrorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_TiposPartida_GlobalesCI_Id",
            //    schema: "H2C",
            //    table: "TiposPartida");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    schema: "H2C",
            //    table: "TiposPartida",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    schema: "H2C",
            //    table: "TiposPartida",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_TiposPartida_GlobalesCI_Id",
            //    schema: "H2C",
            //    table: "TiposPartida",
            //    column: "Id",
            //    principalSchema: "H2C",
            //    principalTable: "GlobalesCI",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
