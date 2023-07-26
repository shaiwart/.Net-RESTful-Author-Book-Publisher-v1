using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRESTful_Demo_5.Migrations
{
    /// <inheritdoc />
    public partial class AddingSubscriber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "BooksTable",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable",
                column: "PublisherId",
                principalTable: "PublisherTable",
                principalColumn: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "BooksTable",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksTable_PublisherTable_PublisherId",
                table: "BooksTable",
                column: "PublisherId",
                principalTable: "PublisherTable",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
