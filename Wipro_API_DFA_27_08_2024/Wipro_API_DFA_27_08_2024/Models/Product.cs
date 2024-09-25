﻿using System;
using System.Collections.Generic;

namespace Wipro_API_DFA_27_08_2024.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int? Quantity { get; set; }
}
