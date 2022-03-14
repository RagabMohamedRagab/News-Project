using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_n9ws.Migrations
{
    public partial class RemoveNewID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "NewID",
                table: "Comments",
                newName: "NewId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_NewID",
                table: "Comments",
                newName: "IX_Comments_NewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewId",
                table: "Comments",
                column: "NewId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "NewId",
                table: "Comments",
                newName: "NewID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_NewId",
                table: "Comments",
                newName: "IX_Comments_NewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewID",
                table: "Comments",
                column: "NewID",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
