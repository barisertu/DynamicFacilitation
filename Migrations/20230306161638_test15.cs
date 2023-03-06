using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "user",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "user",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "user",
                newName: "emailaddress");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "meeting",
                newName: "starttime");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "meeting",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "MeetingId",
                table: "meeting",
                newName: "meetingid");

            migrationBuilder.RenameColumn(
                name: "Serialnumber",
                table: "blogpost",
                newName: "serialnumber");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "blogpost",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "blogpost",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "BlogPostId",
                table: "blogpost",
                newName: "blogpostid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "user",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "user",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "emailaddress",
                table: "user",
                newName: "Emailaddress");

            migrationBuilder.RenameColumn(
                name: "starttime",
                table: "meeting",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "meeting",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "meetingid",
                table: "meeting",
                newName: "MeetingId");

            migrationBuilder.RenameColumn(
                name: "serialnumber",
                table: "blogpost",
                newName: "Serialnumber");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "blogpost",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "blogpost",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "blogpostid",
                table: "blogpost",
                newName: "BlogPostId");
        }
    }
}
