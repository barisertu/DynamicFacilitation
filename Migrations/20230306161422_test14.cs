using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_Owner",
                table: "meeting");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "meeting",
                newName: "owner");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_Owner",
                table: "meeting",
                newName: "IX_meeting_owner");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_owner",
                table: "meeting",
                column: "owner",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_owner",
                table: "meeting");

            migrationBuilder.RenameColumn(
                name: "owner",
                table: "meeting",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_owner",
                table: "meeting",
                newName: "IX_meeting_Owner");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_Owner",
                table: "meeting",
                column: "Owner",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
