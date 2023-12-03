using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agro.Migrations
{
    /// <inheritdoc />
    public partial class aDDsTATUSS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Insurances",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Insurances");
        }
    }
}
