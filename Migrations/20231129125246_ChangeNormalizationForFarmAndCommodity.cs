using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agro.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNormalizationForFarmAndCommodity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmCommodities");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.AddColumn<string>(
                name: "CommodityName",
                table: "Farms",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isHVCDP",
                table: "Farms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommodityName",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "isHVCDP",
                table: "Farms");

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    PK_Commodity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.PK_Commodity);
                });

            migrationBuilder.CreateTable(
                name: "FarmCommodities",
                columns: table => new
                {
                    FK_Farm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Commodity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmCommodities", x => new { x.FK_Farm, x.FK_Commodity });
                    table.ForeignKey(
                        name: "FK_FarmCommodities_Commodities_FK_Commodity",
                        column: x => x.FK_Commodity,
                        principalTable: "Commodities",
                        principalColumn: "PK_Commodity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FarmCommodities_Farms_FK_Farm",
                        column: x => x.FK_Farm,
                        principalTable: "Farms",
                        principalColumn: "PK_Farm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FarmCommodities_FK_Commodity",
                table: "FarmCommodities",
                column: "FK_Commodity");
        }
    }
}
