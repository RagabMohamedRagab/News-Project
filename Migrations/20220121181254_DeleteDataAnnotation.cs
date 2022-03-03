using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_n9ws.Migrations
{
    public partial class DeleteDataAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "Name",
               table: "Categories",
               type: "nvarchar(20)",
               maxLength: 20,
               nullable: false,
               oldClrType: typeof(string),
               oldType: "nvarchar(max)");


            migrationBuilder.AlterColumn<string>(
               name: "Name",
               table: "ContactUs",
               type: "nvarchar(20)",
               maxLength: 20,
               nullable: false,
               oldClrType: typeof(string),
               oldType: "nvarchar(max)");
            migrationBuilder.AlterColumn<string>(
               name: "Topic",
               table: "News",
               type: "nvarchar(20)",
               maxLength: 20,
               nullable: false,
               oldClrType: typeof(string),
               oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "News",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "ContactUs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "ContactUs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
            migrationBuilder.AlterColumn<string>(
               name: "Topic",
               table: "News",
               type: "nvarchar(max)",
               nullable: false,
               oldClrType: typeof(string),
               oldType: "nvarchar(20)",
               oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
            migrationBuilder.AlterColumn<string>(
              name: "Name",
              table: "ContactUs",
              type: "nvarchar(max)",
              nullable: false,
              oldClrType: typeof(string),
              oldType: "nvarchar(20)",
              oldMaxLength: 20);
            migrationBuilder.AlterColumn<string>(
               name: "Name",
               table: "Categories",
               type: "nvarchar(max)",
               nullable: false,
               oldClrType: typeof(string),
               oldType: "nvarchar(20)",
               oldMaxLength: 20);
        }
    }
}
