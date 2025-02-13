using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moment3new.Migrations
{
    /// <inheritdoc />
    public partial class AuthorGenderAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Authors",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Authors");
        }
    }
}
