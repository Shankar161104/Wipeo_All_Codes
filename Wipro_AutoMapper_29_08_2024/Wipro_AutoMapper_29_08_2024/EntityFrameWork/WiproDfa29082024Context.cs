using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Wipro_AutoMapper_29_08_2024.Models;

namespace Wipro_AutoMapper_29_08_2024.EntityFrameWork;

public partial class WiproDfa29082024Context : DbContext
{
   

    public WiproDfa29082024Context(DbContextOptions<WiproDfa29082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<State> States { get; set; }

  
}
