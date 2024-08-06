using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlpha_Project_BookLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedreturnedValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Book",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Book");
        }
    }
}
