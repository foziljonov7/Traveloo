using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Flight = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 11, 3, 9, 27, 28, 36, DateTimeKind.Utc).AddTicks(2125))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Humans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Firstname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Location = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    TicketId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Humans_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Humans_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Davrli reyslar" },
                    { 2, "Tarif reyslar" },
                    { 3, "Xalqaro reyslar" },
                    { 4, "Transiti reyslar" },
                    { 5, "Chaqqon reyslar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Humans_CategoryId",
                table: "Humans",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Humans_TicketId",
                table: "Humans",
                column: "TicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Humans");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
