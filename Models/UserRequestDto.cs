using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicFacilitation.Models
{
	public class UserRequestDto
	{
        public string Emailaddress { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }
    }
}

