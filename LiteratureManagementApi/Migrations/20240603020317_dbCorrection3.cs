using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class dbCorrection3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BookId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "Reviews",
                newName: "LastUpdatedUtc");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Reviews",
                newName: "CreatedDateUtc");

            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "Inventories",
                newName: "LastUpdatedUtc");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Inventories",
                newName: "CreatedDateUtc");

            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "Images",
                newName: "LastUpdatedUtc");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Images",
                newName: "CreatedDateUtc");

            migrationBuilder.RenameColumn(
                name: "PublicationDate",
                table: "Books",
                newName: "PublicationDateUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdatedUtc",
                table: "Reviews",
                newName: "LastUpdated");

            migrationBuilder.RenameColumn(
                name: "CreatedDateUtc",
                table: "Reviews",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedUtc",
                table: "Inventories",
                newName: "LastUpdated");

            migrationBuilder.RenameColumn(
                name: "CreatedDateUtc",
                table: "Inventories",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedUtc",
                table: "Images",
                newName: "LastUpdated");

            migrationBuilder.RenameColumn(
                name: "CreatedDateUtc",
                table: "Images",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "PublicationDateUtc",
                table: "Books",
                newName: "PublicationDate");

            migrationBuilder.AddColumn<long>(
                name: "BookId",
                table: "Categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BookId",
                table: "Categories",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
