using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicFacilitation.Models;

public class MeetingRequestDto
{
    public string Description { get; set; }

    public DateTime StartTime { get; set; }
}
