using Microsoft.EntityFrameworkCore;
using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.EntityFrameWork
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }


    }
}