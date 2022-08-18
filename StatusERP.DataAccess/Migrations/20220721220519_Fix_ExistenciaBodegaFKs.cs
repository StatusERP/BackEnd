using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_ExistenciaBodegaFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ExistenciaBodega_ArticuloId_BodegaId",
            //    schema: "H2C",
            //    table: "ExistenciaBodega");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ExistenciaBodega_ArticuloId",
            //    schema: "H2C",
            //    table: "ExistenciaBodega",
            //    column: "ArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaBodega_Articulo_ArticuloId",
                schema: "H2C",
                table: "ExistenciaBodega",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);


            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaBodega_Bodega_BodegaId",
                schema: "H2C",
                table: "ExistenciaBodega",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExistenciaBodega_ArticuloId",
                schema: "H2C",
                table: "ExistenciaBodega");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaBodega_ArticuloId_BodegaId",
                schema: "H2C",
                table: "ExistenciaBodega",
                columns: new[] { "ArticuloId", "BodegaId" },
                unique: true);
        }
    }
}
