using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class HumanTicketIdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Humans",
                table: "Humans");

            migrationBuilder.DropIndex(
                name: "IX_Humans_TicketId",
                table: "Humans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 4, 7, 31, 55, 154, DateTimeKind.Utc).AddTicks(4238),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 11, 3, 9, 27, 28, 36, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Humans",
                table: "Humans",
                column: "TicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Humans",
                table: "Humans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 3, 9, 27, 28, 36, DateTimeKind.Utc).AddTicks(2125),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 11, 4, 7, 31, 55, 154, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Humans",
                table: "Humans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Humans_TicketId",
                table: "Humans",
                column: "TicketId");
        }
    }
}
