using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookKeeping.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class Migration_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralJournals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GLNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralJournals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountCategories_AccountCategoryId",
                        column: x => x.AccountCategoryId,
                        principalTable: "AccountCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GeneralJournalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrAccId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrAccCatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credits_GeneralJournals_GeneralJournalId",
                        column: x => x.GeneralJournalId,
                        principalTable: "GeneralJournals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GeneralJournalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrAccId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrAccCatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debits_GeneralJournals_GeneralJournalId",
                        column: x => x.GeneralJournalId,
                        principalTable: "GeneralJournals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountCategoryId",
                table: "Accounts",
                column: "AccountCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Credits_GeneralJournalId",
                table: "Credits",
                column: "GeneralJournalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Debits_GeneralJournalId",
                table: "Debits",
                column: "GeneralJournalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "Debits");

            migrationBuilder.DropTable(
                name: "AccountCategories");

            migrationBuilder.DropTable(
                name: "GeneralJournals");
        }
    }
}
