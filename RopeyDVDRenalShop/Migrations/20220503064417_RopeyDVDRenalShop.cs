using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RopeyDVDRenalShop.Migrations
{
    public partial class RopeyDVDRenalShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorNumber);
                });

            migrationBuilder.CreateTable(
                name: "dvdCategories",
                columns: table => new
                {
                    CategoryNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRestricted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dvdCategories", x => x.CategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    LoanTypeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanDuration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.LoanTypeNumber);
                });

            migrationBuilder.CreateTable(
                name: "membershipCategories",
                columns: table => new
                {
                    MembershipCategoryNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipCategoryTotalLoans = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershipCategories", x => x.MembershipCategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerNumber);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudioName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioNumber);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserNumber);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    MemberNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFirstName = table.Column<int>(type: "int", nullable: false),
                    MemberAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberBirthOfDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipCategoryNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.MemberNumber);
                    table.ForeignKey(
                        name: "FK_members_membershipCategories_MembershipCategoryNumber",
                        column: x => x.MembershipCategoryNumber,
                        principalTable: "membershipCategories",
                        principalColumn: "MembershipCategoryNumber");
                });

            migrationBuilder.CreateTable(
                name: "dvdTittles",
                columns: table => new
                {
                    DvdNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DvdTitles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateReleased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StandardCharge = table.Column<float>(type: "real", nullable: false),
                    PenaltyCharge = table.Column<float>(type: "real", nullable: false),
                    CategoryNumber = table.Column<int>(type: "int", nullable: false),
                    StudioNumber = table.Column<int>(type: "int", nullable: false),
                    ProducerNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dvdTittles", x => x.DvdNumber);
                    table.ForeignKey(
                        name: "FK_dvdTittles_dvdCategories_CategoryNumber",
                        column: x => x.CategoryNumber,
                        principalTable: "dvdCategories",
                        principalColumn: "CategoryNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dvdTittles_Producers_ProducerNumber",
                        column: x => x.ProducerNumber,
                        principalTable: "Producers",
                        principalColumn: "ProducerNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dvdTittles_Studios_StudioNumber",
                        column: x => x.StudioNumber,
                        principalTable: "Studios",
                        principalColumn: "StudioNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "castmembers",
                columns: table => new
                {
                    CastMemberNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DvdNumber = table.Column<int>(type: "int", nullable: false),
                    ActorNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_castmembers", x => x.CastMemberNumber);
                    table.ForeignKey(
                        name: "FK_castmembers_Actors_ActorNumber",
                        column: x => x.ActorNumber,
                        principalTable: "Actors",
                        principalColumn: "ActorNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_castmembers_dvdTittles_DvdNumber",
                        column: x => x.DvdNumber,
                        principalTable: "dvdTittles",
                        principalColumn: "DvdNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DvdCopy",
                columns: table => new
                {
                    CopyNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePurchased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DvdNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DvdCopy", x => x.CopyNumber);
                    table.ForeignKey(
                        name: "FK_DvdCopy_dvdTittles_DvdNumber",
                        column: x => x.DvdNumber,
                        principalTable: "dvdTittles",
                        principalColumn: "DvdNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "loans",
                columns: table => new
                {
                    LoanNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanTypeNumber = table.Column<int>(type: "int", nullable: false),
                    CopyNumber = table.Column<int>(type: "int", nullable: false),
                    MemberNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loans", x => x.LoanNumber);
                    table.ForeignKey(
                        name: "FK_loans_DvdCopy_CopyNumber",
                        column: x => x.CopyNumber,
                        principalTable: "DvdCopy",
                        principalColumn: "CopyNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_loans_LoanTypes_LoanTypeNumber",
                        column: x => x.LoanTypeNumber,
                        principalTable: "LoanTypes",
                        principalColumn: "LoanTypeNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_loans_members_MemberNumber",
                        column: x => x.MemberNumber,
                        principalTable: "members",
                        principalColumn: "MemberNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_castmembers_ActorNumber",
                table: "castmembers",
                column: "ActorNumber");

            migrationBuilder.CreateIndex(
                name: "IX_castmembers_DvdNumber",
                table: "castmembers",
                column: "DvdNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DvdCopy_DvdNumber",
                table: "DvdCopy",
                column: "DvdNumber");

            migrationBuilder.CreateIndex(
                name: "IX_dvdTittles_CategoryNumber",
                table: "dvdTittles",
                column: "CategoryNumber");

            migrationBuilder.CreateIndex(
                name: "IX_dvdTittles_ProducerNumber",
                table: "dvdTittles",
                column: "ProducerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_dvdTittles_StudioNumber",
                table: "dvdTittles",
                column: "StudioNumber");

            migrationBuilder.CreateIndex(
                name: "IX_loans_CopyNumber",
                table: "loans",
                column: "CopyNumber");

            migrationBuilder.CreateIndex(
                name: "IX_loans_LoanTypeNumber",
                table: "loans",
                column: "LoanTypeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_loans_MemberNumber",
                table: "loans",
                column: "MemberNumber");

            migrationBuilder.CreateIndex(
                name: "IX_members_MembershipCategoryNumber",
                table: "members",
                column: "MembershipCategoryNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "castmembers");

            migrationBuilder.DropTable(
                name: "loans");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "DvdCopy");

            migrationBuilder.DropTable(
                name: "LoanTypes");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "dvdTittles");

            migrationBuilder.DropTable(
                name: "membershipCategories");

            migrationBuilder.DropTable(
                name: "dvdCategories");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
