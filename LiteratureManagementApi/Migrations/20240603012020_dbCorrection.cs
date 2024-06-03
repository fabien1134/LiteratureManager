using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class dbCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
