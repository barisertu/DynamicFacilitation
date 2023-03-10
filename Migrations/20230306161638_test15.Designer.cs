// <auto-generated />
using System;
using DynamicFacilitation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DynamicFacilitation.Migrations
{
    [DbContext(typeof(DynamicFacilitationContext))]
    [Migration("20230306161638_test15")]
    partial class test15
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DynamicFacilitation.Models.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("blogpostid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlogPostId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("MeetingId")
                        .HasColumnType("integer");

                    b.Property<int>("Serialnumber")
                        .HasColumnType("integer")
                        .HasColumnName("serialnumber");

                    b.HasKey("BlogPostId");

                    b.HasIndex("MeetingId");

                    b.ToTable("blogpost");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("meetingid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MeetingId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("owner");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starttime");

                    b.HasKey("MeetingId");

                    b.HasIndex("Owner");

                    b.ToTable("meeting");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.User", b =>
                {
                    b.Property<string>("Emailaddress")
                        .HasColumnType("text")
                        .HasColumnName("emailaddress");

                    b.Property<string>("Firstname")
                        .HasColumnType("text")
                        .HasColumnName("firstname");

                    b.Property<string>("Lastname")
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.HasKey("Emailaddress");

                    b.ToTable("user");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.UserMeeting", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int>("MeetingId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "MeetingId");

                    b.HasIndex("MeetingId");

                    b.ToTable("user_meeting");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.BlogPost", b =>
                {
                    b.HasOne("DynamicFacilitation.Models.Meeting", "Meeting")
                        .WithMany("BlogPosts")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.Meeting", b =>
                {
                    b.HasOne("DynamicFacilitation.Models.User", "User")
                        .WithMany("Meetings")
                        .HasForeignKey("Owner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.UserMeeting", b =>
                {
                    b.HasOne("DynamicFacilitation.Models.Meeting", "Meeting")
                        .WithMany("UserMeetings")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DynamicFacilitation.Models.User", "User")
                        .WithMany("UserMeetings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.Meeting", b =>
                {
                    b.Navigation("BlogPosts");

                    b.Navigation("UserMeetings");
                });

            modelBuilder.Entity("DynamicFacilitation.Models.User", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("UserMeetings");
                });
#pragma warning restore 612, 618
        }
    }
}
