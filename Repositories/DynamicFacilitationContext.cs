using System;
using DynamicFacilitation.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicFacilitation.Repositories
{
	public class DynamicFacilitationContext : DbContext
	{
        public DynamicFacilitationContext(DbContextOptions<DynamicFacilitationContext> options)
		: base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }

		public DbSet<User> Users { get; set; }

        public DbSet<UserMeeting> UserMeetings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

			//modelBuilder.Entity<User>()
              //  .HasKey(u => u.Emailaddress);

			//modelBuilder.Entity<User>()
              //  .HasMany(u => u.Meetings)
                //.WithOne(m => m.Owner);

            
            //not needed because of the name convention in models 
            //modelBuilder.Entity<Meeting>()
              //  .HasMany(m => m.BlogPosts)
                //.WithOne(m => m.Meeting);

           // modelBuilder.Entity<UserMeeting>()
             //   .HasKey(bc => new { bc.MeetingId, bc.UserId });

//            modelBuilder.Entity<UserMeeting>()
  //              .HasOne(bc => bc.Meeting)
    //            .WithMany(b => b.UserMeetings)
      //          .HasForeignKey(bc => bc.MeetingId);

        //    modelBuilder.Entity<UserMeeting>()
          //      .HasOne(bc => bc.User)
            //    .WithMany(c => c.UserMeetings)
              //s  .HasForeignKey(bc => bc.UserId);
        }
	}
}

