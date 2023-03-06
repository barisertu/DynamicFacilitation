using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicFacilitation.Models;

public class MeetingResponseDto
{
    public string MeetingId { get; set; }
    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public string Owner { get; set; }
}
