using System;
using System.Collections.Generic;

namespace Wipro_AutoMapper_29_08_2024.Models;

public partial class State
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }
}
