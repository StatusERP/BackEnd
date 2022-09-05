using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixConsecutivoFA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsaEsquemaCajas",
                schema: "H2C",
                table: "ConsecutivosFA");

            migrationBuilder.RenameColumn(
                name: "CodigoConsecutivo",
                schema: "H2C",
                table: "ConsecutivosFA",
                newName: "CodConsecutivo");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUlt",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "DeConsRPT",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeCCRPT",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IxCodConsecutivo1",
                schema: "H2C",
                table: "ConsecutivosFA",
                column: "CodConsecutivo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodConsecutivo1",
                schema: "H2C",
                table: "ConsecutivosFA");

            migrationBuilder.RenameColumn(
                name: "CodConsecutivo",
                schema: "H2C",
                table: "ConsecutivosFA",
                newName: "CodigoConsecutivo");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUlt",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "DeConsRPT",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeCCRPT",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UsaEsquemaCajas",
                schema: "H2C",
                table: "ConsecutivosFA",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
