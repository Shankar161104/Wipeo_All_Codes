using Microsoft.EntityFrameworkCore;
using Wipro_API_CodeFirstApproach.Model;


namespace Wipro_API_CodeFirstApproach.Entity_Framework
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }



        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new VehicleMap(modelBuilder.Entity<Vehicle>());
            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
}
