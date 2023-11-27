using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agro.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRemarksandAddSuffix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApprove",
                table: "Personals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Suffix",
                table: "Personals",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Remarks",
                table: "Insurances",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AddColumn<string>(
                name: "LandCategorySoilType",
                table: "Farms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenurialStatus",
                table: "Farms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApprove",
                table: "Personals");

            migrationBuilder.DropColumn(
                name: "Suffix",
                table: "Personals");

            migrationBuilder.DropColumn(
                name: "LandCategorySoilType",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "TenurialStatus",
                table: "Farms");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Insurances",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
