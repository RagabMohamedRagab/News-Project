using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_n9ws.Migrations
{
    public partial class RelationShipsbetweenCommentAndNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewID",
                table: "Comments",
                column: "NewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_News_NewID",
                table: "Comments",
                column: "NewID",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_News_NewID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_NewID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "NewID",
                table: "Comments");
        }
    }
}
