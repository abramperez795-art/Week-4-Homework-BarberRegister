using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarberRegister.Migrations
{
    /// <inheritdoc />
    public partial class InitialHairStyles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HairStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    HairLength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TypicalDurationMinutes = table.Column<int>(type: "int", nullable: false),
                    StartingPrice = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    IncludesBeardService = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairStyles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HairStyles",
                columns: new[] { "Id", "Description", "HairLength", "IncludesBeardService", "Name", "StartingPrice", "TypicalDurationMinutes" },
                values: new object[,]
                {
                    { 1, "A clean tapered haircut.", "Short", false, "Low Fade", 35m, 45 },
                    { 2, "A protective braided hairstyle.", "Medium to long", false, "Box Braids", 120m, 180 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HairStyles");
        }
    }
}
