using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicFacilitation.Models;


[Table("blogpost")]
public class BlogPost
{
    [Column("blogpostid")]
    public int BlogPostId { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("category")]
    public string Category { get; set; }

    [Column("serialnumber")]
    public int Serialnumber { get; set; }

    public Meeting Meeting { get; set; }
}
