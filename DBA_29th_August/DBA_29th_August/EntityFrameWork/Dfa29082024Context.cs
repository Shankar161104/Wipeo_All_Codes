using System;
using System.Collections.Generic;
using DBA_29th_August.Models;
using Microsoft.EntityFrameworkCore;

namespace DBA_29th_August.EntityFrameWork;

public partial class Dfa29082024Context : DbContext
{


    public Dfa29082024Context(DbContextOptions<Dfa29082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Durga> Durgas { get; set; }


}
