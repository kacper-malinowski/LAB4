using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Song",
                newName: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "RatingCount",
                table: "Song",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatingCount",
                table: "Song");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Song",
                newName: "Rate");
        }
    }
}
