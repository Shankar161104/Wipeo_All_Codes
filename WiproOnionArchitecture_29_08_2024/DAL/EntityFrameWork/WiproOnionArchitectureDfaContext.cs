using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.EntityFrameWork;

public partial class WiproOnionArchitectureDfaContext : DbContext
{
   

    public WiproOnionArchitectureDfaContext(DbContextOptions<WiproOnionArchitectureDfaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

 

   
}
