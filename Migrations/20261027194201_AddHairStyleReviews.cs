using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarberRegister.Migrations
{
    /// <inheritdoc />
    public partial class AddHairStyleReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HairStyleReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReviewedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HairStyleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairStyleReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairStyleReviews_HairStyles_HairStyleId",
                        column: x => x.HairStyleId,
                        principalTable: "HairStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HairStyleReviews",
                columns: new[] { "Id", "Comments", "HairStyleId", "Rating", "ReviewedOn", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "Clean fade and a sharp finish. Exactly what I wanted.", 1, 5, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex" },
                    { 2, "Easy to maintain and a great everyday style.", 1, 4, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan" },
                    { 3, "Neat braids and a comfortable protective style.", 2, 5, new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HairStyleReviews_HairStyleId",
                table: "HairStyleReviews",
                column: "HairStyleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HairStyleReviews");
        }
    }
}
