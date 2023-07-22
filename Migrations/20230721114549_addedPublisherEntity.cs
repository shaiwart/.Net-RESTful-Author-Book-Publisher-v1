using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRESTful_Demo_5.Migrations
{
    /// <inheritdoc />
    public partial class addedPublisherEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "BooksTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "BooksTable");
        }
    }
}
