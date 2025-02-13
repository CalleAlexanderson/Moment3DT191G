using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moment3new.Migrations
{
    /// <inheritdoc />
    public partial class IsbnString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "TEXT",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 13,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Books",
                type: "INTEGER",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 13,
                oldNullable: true);
        }
    }
}
