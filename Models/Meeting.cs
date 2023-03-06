using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicFacilitation.Models;

[Table("meeting")]
public class Meeting
{
    [Column("meetingid")]
    public int MeetingId { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("starttime")]
    public DateTime StartTime { get; set; }

    [Column("owner")]
    public string Owner { get; set; }

    [ForeignKey("Owner")]
    public User User { get; set; }

    public ICollection<BlogPost> BlogPosts { get; set; }

    public ICollection<UserMeeting> UserMeetings { get; set; }
}
