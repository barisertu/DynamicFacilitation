using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_UserEmailaddress",
                table: "meeting");

            migrationBuilder.DropIndex(
                name: "IX_meeting_UserEmailaddress",
                table: "meeting");

            migrationBuilder.DropColumn(
                name: "UserEmailaddress",
                table: "meeting");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "meeting",
                newName: "OwnerEmailaddress");

            migrationBuilder.CreateIndex(
                name: "IX_meeting_OwnerEmailaddress",
                table: "meeting",
                column: "OwnerEmailaddress");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting",
                column: "OwnerEmailaddress",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.DropIndex(
                name: "IX_meeting_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.RenameColumn(
                name: "OwnerEmailaddress",
                table: "meeting",
                newName: "Owner");

            migrationBuilder.AddColumn<string>(
                name: "UserEmailaddress",
                table: "meeting",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_meeting_UserEmailaddress",
                table: "meeting",
                column: "UserEmailaddress");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_UserEmailaddress",
                table: "meeting",
                column: "UserEmailaddress",
                principalTable: "user",
                principalColumn: "Emailaddress");
        }
    }
}
