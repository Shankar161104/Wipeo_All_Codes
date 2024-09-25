using System;
using System.Collections.Generic;

namespace Wipro_API_DFA_27_08_2024.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? OrderHistory { get; set; }

    public string? Reviews { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
