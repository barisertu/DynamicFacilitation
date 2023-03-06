using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting");

            migrationBuilder.DropIndex(
                name: "IX_user_meeting_UserId",
                table: "user_meeting");

            migrationBuilder.RenameColumn(
                name: "OwnerEmailaddress",
                table: "meeting",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_OwnerEmailaddress",
                table: "meeting",
                newName: "IX_meeting_Owner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting",
                columns: new[] { "UserId", "MeetingId" });

            migrationBuilder.CreateIndex(
                name: "IX_user_meeting_MeetingId",
                table: "user_meeting",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_Owner",
                table: "meeting",
                column: "Owner",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_Owner",
                table: "meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting");

            migrationBuilder.DropIndex(
                name: "IX_user_meeting_MeetingId",
                table: "user_meeting");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "meeting",
                newName: "OwnerEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_Owner",
                table: "meeting",
                newName: "IX_meeting_OwnerEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting",
                columns: new[] { "MeetingId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_user_meeting_UserId",
                table: "user_meeting",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting",
                column: "OwnerEmailaddress",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
