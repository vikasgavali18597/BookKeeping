using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookKeeping.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class Migration_DrCr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credits_GeneralJournal_GeneralJournalId",
                table: "Credits");

            migrationBuilder.DropForeignKey(
                name: "FK_Debit_GeneralJournal_GeneralJournalId",
                table: "Debit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralJournal",
                table: "GeneralJournal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Debit",
                table: "Debit");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Credits");

            migrationBuilder.DropColumn(
                name: "GlNo",
                table: "Credits");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Debit");

            migrationBuilder.DropColumn(
                name: "GlNo",
                table: "Debit");

            migrationBuilder.RenameTable(
                name: "GeneralJournal",
                newName: "GeneralJournals");

            migrationBuilder.RenameTable(
                name: "Debit",
                newName: "Debits");

            migrationBuilder.RenameIndex(
                name: "IX_Debit_GeneralJournalId",
                table: "Debits",
                newName: "IX_Debits_GeneralJournalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralJournals",
                table: "GeneralJournals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debits",
                table: "Debits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Credits_GeneralJournals_GeneralJournalId",
                table: "Credits",
                column: "GeneralJournalId",
                principalTable: "GeneralJournals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Debits_GeneralJournals_GeneralJournalId",
                table: "Debits",
                column: "GeneralJournalId",
                principalTable: "GeneralJournals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credits_GeneralJournals_GeneralJournalId",
                table: "Credits");

            migrationBuilder.DropForeignKey(
                name: "FK_Debits_GeneralJournals_GeneralJournalId",
                table: "Debits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralJournals",
                table: "GeneralJournals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Debits",
                table: "Debits");

            migrationBuilder.RenameTable(
                name: "GeneralJournals",
                newName: "GeneralJournal");

            migrationBuilder.RenameTable(
                name: "Debits",
                newName: "Debit");

            migrationBuilder.RenameIndex(
                name: "IX_Debits_GeneralJournalId",
                table: "Debit",
                newName: "IX_Debit_GeneralJournalId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Credits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GlNo",
                table: "Credits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Debit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GlNo",
                table: "Debit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralJournal",
                table: "GeneralJournal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debit",
                table: "Debit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Credits_GeneralJournal_GeneralJournalId",
                table: "Credits",
                column: "GeneralJournalId",
                principalTable: "GeneralJournal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Debit_GeneralJournal_GeneralJournalId",
                table: "Debit",
                column: "GeneralJournalId",
                principalTable: "GeneralJournal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
