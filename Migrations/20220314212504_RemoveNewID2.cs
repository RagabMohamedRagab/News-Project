using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_n9ws.Migrations
{
    public partial class RemoveNewID2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_NewId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "NewId",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewId",
                table: "Comments",
                column: "NewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewId",
                table: "Comments",
                column: "NewId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
