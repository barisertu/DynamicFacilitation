using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DynamicFacilitation.Models
{
    [Table("user_meeting")]
    [PrimaryKey(nameof(UserId), nameof(MeetingId))]
    public class UserMeeting
	{
        public string UserId { get; set; }
        public User User { get; set; }

        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}

