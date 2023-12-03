using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agro.Migrations
{
    /// <inheritdoc />
    public partial class AddedMembershipApplications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipApplications",
                columns: table => new
                {
                    PK_MembershipApplication = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateApplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FK_UserApproverPK_User = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_PersonalPK_Personal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipApplications", x => x.PK_MembershipApplication);
                    table.ForeignKey(
                        name: "FK_MembershipApplications_Personals_FK_PersonalPK_Personal",
                        column: x => x.FK_PersonalPK_Personal,
                        principalTable: "Personals",
                        principalColumn: "PK_Personal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembershipApplications_Users_FK_UserApproverPK_User",
                        column: x => x.FK_UserApproverPK_User,
                        principalTable: "Users",
                        principalColumn: "PK_User");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MembershipApplications_FK_PersonalPK_Personal",
                table: "MembershipApplications",
                column: "FK_PersonalPK_Personal");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipApplications_FK_UserApproverPK_User",
                table: "MembershipApplications",
                column: "FK_UserApproverPK_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembershipApplications");
        }
    }
}
