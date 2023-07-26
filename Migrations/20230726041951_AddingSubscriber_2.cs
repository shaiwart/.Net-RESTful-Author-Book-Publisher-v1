using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRESTful_Demo_5.Migrations
{
    /// <inheritdoc />
    public partial class AddingSubscriber_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksTable_AuthorTable_AuthorId",
                table: "BooksTable");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "BooksTable",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksTable_AuthorTable_AuthorId",
                table: "BooksTable",
                column: "AuthorId",
                principalTable: "AuthorTable",
                principalColumn: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksTable_AuthorTable_AuthorId",
                table: "BooksTable");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "BooksTable",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksTable_AuthorTable_AuthorId",
                table: "BooksTable",
                column: "AuthorId",
                principalTable: "AuthorTable",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
