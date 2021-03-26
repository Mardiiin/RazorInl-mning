using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Attendee",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "emailaddress",
                table: "Attendee",
                newName: "Emailaddress");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Attendee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Attendee",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "Attendee",
                newName: "emailaddress");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Attendee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
