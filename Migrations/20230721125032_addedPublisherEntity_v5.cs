using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRESTful_Demo_5.Migrations
{
    /// <inheritdoc />
    public partial class addedPublisherEntity_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BooksTable_PublisherId",
                table: "BooksTable",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable",
                column: "PublisherId",
                principalTable: "PublisherTable",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable");

            migrationBuilder.DropIndex(
                name: "IX_BooksTable_PublisherId",
                table: "BooksTable");
        }
    }
}
