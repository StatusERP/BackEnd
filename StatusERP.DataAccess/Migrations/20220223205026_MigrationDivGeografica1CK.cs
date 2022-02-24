using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigrationDivGeografica1CK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                table: "Bodegas");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropIndex(
                name: "IX_Bodegas_SucursalId",
                table: "Bodegas");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "Bodegas",
                newName: "CodSucursal");

            migrationBuilder.CreateTable(
                name: "DivGeografica1",
                columns: table => new
                {
                    Pais = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CodDivGeografica1 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConjuntoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivGeografica1", x => new { x.Pais, x.CodDivGeografica1 });
                    table.ForeignKey(
                        name: "FK_DivGeografica1_Conjuntos_ConjuntoId",
                        column: x => x.ConjuntoId,
                        principalTable: "Conjuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DivGeografica1_ConjuntoId",
                table: "DivGeografica1",
                column: "ConjuntoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DivGeografica1");

            migrationBuilder.RenameColumn(
                name: "CodSucursal",
                table: "Bodegas",
                newName: "SucursalId");

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConjuntoId = table.Column<int>(type: "int", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    CodSucursal = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                    table.UniqueConstraint("AKCodSucursal", x => x.CodSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursales_Conjuntos_ConjuntoId",
                        column: x => x.ConjuntoId,
                        principalTable: "Conjuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_SucursalId",
                table: "Bodegas",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_ConjuntoId",
                table: "Sucursales",
                column: "ConjuntoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                table: "Bodegas",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");
        }
    }
}
