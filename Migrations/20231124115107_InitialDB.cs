using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agro.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    PK_Address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Barangay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.PK_Address);
                });

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
                name: "Users",
                columns: table => new
                {
                    PK_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.PK_User);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    PK_Personal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    civil_status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    FK_UserPK_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.PK_Personal);
                    table.ForeignKey(
                        name: "FK_Personals_Users_FK_UserPK_User",
                        column: x => x.FK_UserPK_User,
                        principalTable: "Users",
                        principalColumn: "PK_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    PK_Farm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaSQM = table.Column<int>(type: "int", nullable: false),
                    NorthAdjacentOwner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EastAdjacentOwner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WastAdjacentOwner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SouthAdjacentOwner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FK_UserPK_User = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<int>(type: "int", nullable: true),
                    Personal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.PK_Farm);
                    table.ForeignKey(
                        name: "FK_Farms_Addresses_Address",
                        column: x => x.Address,
                        principalTable: "Addresses",
                        principalColumn: "PK_Address");
                    table.ForeignKey(
                        name: "FK_Farms_Personals_Personal",
                        column: x => x.Personal,
                        principalTable: "Personals",
                        principalColumn: "PK_Personal");
                    table.ForeignKey(
                        name: "FK_Farms_Users_FK_UserPK_User",
                        column: x => x.FK_UserPK_User,
                        principalTable: "Users",
                        principalColumn: "PK_User");
                });

            migrationBuilder.CreateTable(
                name: "PersonalAddresses",
                columns: table => new
                {
                    FK_Personal = table.Column<int>(type: "int", nullable: false),
                    FK_Address = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAddresses", x => new { x.FK_Personal, x.FK_Address });
                    table.ForeignKey(
                        name: "FK_PersonalAddresses_Addresses_FK_Address",
                        column: x => x.FK_Address,
                        principalTable: "Addresses",
                        principalColumn: "PK_Address",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalAddresses_Personals_FK_Personal",
                        column: x => x.FK_Personal,
                        principalTable: "Personals",
                        principalColumn: "PK_Personal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FarmCommodities",
                columns: table => new
                {
                    FK_Commodity = table.Column<int>(type: "int", nullable: false),
                    FK_Farm = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    PK_Insurance = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DateApplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_FarmPK_Farm = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_UserPK_User = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonalPK_Personal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.PK_Insurance);
                    table.ForeignKey(
                        name: "FK_Insurances_Farms_FK_FarmPK_Farm",
                        column: x => x.FK_FarmPK_Farm,
                        principalTable: "Farms",
                        principalColumn: "PK_Farm");
                    table.ForeignKey(
                        name: "FK_Insurances_Personals_PersonalPK_Personal",
                        column: x => x.PersonalPK_Personal,
                        principalTable: "Personals",
                        principalColumn: "PK_Personal");
                    table.ForeignKey(
                        name: "FK_Insurances_Users_FK_UserPK_User",
                        column: x => x.FK_UserPK_User,
                        principalTable: "Users",
                        principalColumn: "PK_User");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FarmCommodities_FK_Commodity",
                table: "FarmCommodities",
                column: "FK_Commodity");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_Address",
                table: "Farms",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_FK_UserPK_User",
                table: "Farms",
                column: "FK_UserPK_User");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_Personal",
                table: "Farms",
                column: "Personal");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_FK_FarmPK_Farm",
                table: "Insurances",
                column: "FK_FarmPK_Farm");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_FK_UserPK_User",
                table: "Insurances",
                column: "FK_UserPK_User");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_PersonalPK_Personal",
                table: "Insurances",
                column: "PersonalPK_Personal");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAddresses_FK_Address",
                table: "PersonalAddresses",
                column: "FK_Address");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_FK_UserPK_User",
                table: "Personals",
                column: "FK_UserPK_User");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmCommodities");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "PersonalAddresses");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
