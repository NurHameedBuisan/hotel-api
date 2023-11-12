using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAnytimePublicAPI.Migrations
{
    /// <inheritdoc />
    public partial class nameOfMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HotelReviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotel_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_HotelReviews_Hotels_hotel_id",
                        column: x => x.hotel_id,
                        principalTable: "Hotels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReviews_hotel_id",
                table: "HotelReviews",
                column: "hotel_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelReviews");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
