using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_ExistenciaBodegaIdxs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ExistenciaBodega_ArticuloId",
            //    schema: "H2C",
            //    table: "ExistenciaBodega");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaBodega_ArticuloId_BodegaId",
                schema: "H2C",
                table: "ExistenciaBodega",
                columns: new[] { "ArticuloId", "BodegaId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExistenciaBodega_ArticuloId_BodegaId",
                schema: "H2C",
                table: "ExistenciaBodega");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaBodega_ArticuloId",
                schema: "H2C",
                table: "ExistenciaBodega",
                column: "ArticuloId");
        }
    }
}
