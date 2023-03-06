using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_meeting_MeetingId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_meeting_Users_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeeting_Users_UserId",
                table: "UserMeeting");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeeting_meeting_MeetingId",
                table: "UserMeeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMeeting",
                table: "UserMeeting");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "blogpost");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "UserMeeting",
                newName: "user_meeting");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPost_MeetingId",
                table: "blogpost",
                newName: "IX_blogpost_MeetingId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMeeting_UserId",
                table: "user_meeting",
                newName: "IX_user_meeting_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogpost",
                table: "blogpost",
                column: "BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Emailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting",
                columns: new[] { "MeetingId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_blogpost_meeting_MeetingId",
                table: "blogpost",
                column: "MeetingId",
                principalTable: "meeting",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting",
                column: "OwnerEmailaddress",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_meeting_meeting_MeetingId",
                table: "user_meeting",
                column: "MeetingId",
                principalTable: "meeting",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_meeting_user_UserId",
                table: "user_meeting",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogpost_meeting_MeetingId",
                table: "blogpost");

            migrationBuilder.DropForeignKey(
                name: "FK_meeting_user_OwnerEmailaddress",
                table: "meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_user_meeting_meeting_MeetingId",
                table: "user_meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_user_meeting_user_UserId",
                table: "user_meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogpost",
                table: "blogpost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_meeting",
                table: "user_meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "blogpost",
                newName: "BlogPost");

            migrationBuilder.RenameTable(
                name: "user_meeting",
                newName: "UserMeeting");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_blogpost_MeetingId",
                table: "BlogPost",
                newName: "IX_BlogPost_MeetingId");

            migrationBuilder.RenameIndex(
                name: "IX_user_meeting_UserId",
                table: "UserMeeting",
                newName: "IX_UserMeeting_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost",
                column: "BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMeeting",
                table: "UserMeeting",
                columns: new[] { "MeetingId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Emailaddress");

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
                name: "FK_UserMeeting_Users_UserId",
                table: "UserMeeting",
                column: "UserId",
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
    }
}
