using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DynamicFacilitation.Models;

[Table("user")]
[PrimaryKey(nameof(Emailaddress))]
public class User
{
    [Column("emailaddress")]
    public string Emailaddress { get; set; }

    [Column("firstname")]
    public string? Firstname { get; set; }

    [Column("lastname")]
    public string? Lastname { get; set; }

    public ICollection<Meeting> Meetings { get; set; }

    public ICollection<UserMeeting> UserMeetings { get; set; }

}