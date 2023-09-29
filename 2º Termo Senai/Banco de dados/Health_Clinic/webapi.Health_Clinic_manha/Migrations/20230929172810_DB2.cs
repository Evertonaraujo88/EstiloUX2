using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Health_Clinic_manha.Migrations
{
    /// <inheritdoc />
    public partial class DB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prontuario",
                table: "ConsultaDomain",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prontuario",
                table: "ConsultaDomain",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");
        }
    }
}
