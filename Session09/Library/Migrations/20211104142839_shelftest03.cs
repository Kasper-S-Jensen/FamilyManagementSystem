using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class shelftest03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShelfID",
                table: "Books",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ShelfID",
                table: "Books",
                column: "ShelfID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Shelves_ShelfID",
                table: "Books",
                column: "ShelfID",
                principalTable: "Shelves",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Shelves_ShelfID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ShelfID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ShelfID",
                table: "Books");
        }
    }
}
