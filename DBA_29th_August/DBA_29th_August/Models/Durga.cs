using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBA_29th_August.Models;

public partial class Durga
{
    [Key]
     public int? Age { get; set; }

    public string? Dname { get; set; }

    public string? City { get; set; }
}
