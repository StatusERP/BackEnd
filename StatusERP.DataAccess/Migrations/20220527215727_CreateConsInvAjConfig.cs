using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CreateConsInvAjConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsInvAjConfig",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsecutivoInvId = table.Column<int>(type: "int", nullable: false),
                    AjusteConfigId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsInvAjConfig", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsInvAjConfig_AjustesConfig_AjusteConfigId",
                        column: x => x.AjusteConfigId,
                        principalSchema: "H2C",
                        principalTable: "AjustesConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsInvAjConfig_ConsecutivosInv_ConsecutivoInvId",
                        column: x => x.ConsecutivoInvId,
                        principalSchema: "H2C",
                        principalTable: "ConsecutivosInv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsInvAjConfig_AjusteConfigId",
                schema: "H2C",
                table: "ConsInvAjConfig",
                column: "AjusteConfigId");

            migrationBuilder.CreateIndex(
                name: "IxConsecutivoAjuste",
                schema: "H2C",
                table: "ConsInvAjConfig",
                columns: new[] { "ConsecutivoInvId", "AjusteConfigId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsInvAjConfig",
                schema: "H2C");
        }
    }
}
