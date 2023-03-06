using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_Meetings_MeetingId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Users_OwnerEmailaddress",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeeting_Meetings_MeetingId",
                table: "UserMeeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings");

            migrationBuilder.RenameTable(
                name: "Meetings",
                newName: "meeting");

            migrationBuilder.RenameIndex(
                name: "IX_Meetings_OwnerEmailaddress",
                table: "meeting",
                newName: "IX_meeting_OwnerEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_meeting",
                table: "meeting",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_meeting_MeetingId",
                table: "BlogPost",
                column: "MeetingId",
                principalTable: "meeting",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_Users_OwnerEmailaddress",
                table: "meeting",
                column: "OwnerEmailaddress",
                principalTable: "Users",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeeting_meeting_MeetingId",
                table: "UserMeeting",
                column: "MeetingId",
                principalTable: "meeting",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_meeting_MeetingId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_meeting_Users_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeeting_meeting_MeetingId",
                table: "UserMeeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_meeting",
                table: "meeting");

            migrationBuilder.RenameTable(
                name: "meeting",
                newName: "Meetings");

            migrationBuilder.RenameIndex(
                name: "IX_meeting_OwnerEmailaddress",
                table: "Meetings",
                newName: "IX_Meetings_OwnerEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_Meetings_MeetingId",
                table: "BlogPost",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Users_OwnerEmailaddress",
                table: "Meetings",
                column: "OwnerEmailaddress",
                principalTable: "Users",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeeting_Meetings_MeetingId",
                table: "UserMeeting",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
