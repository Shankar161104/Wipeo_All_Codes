using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFrameWork
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Artist> Artists { get; set; }
       
        public DbSet<User> Users { get; set; }
        

       



        protected override void OnModelCreating(ModelBuilder oModelBuilder)
        {
            new UserMap(oModelBuilder.Entity<User>());
        }



    }
}
