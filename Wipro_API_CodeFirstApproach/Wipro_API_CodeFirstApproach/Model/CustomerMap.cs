using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_API_CodeFirstApproach.Model
{
  
        public class CustomerMap
        {
            public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilderCustomer)
            {
                entityTypeBuilderCustomer.HasKey(cus => cus.CustomerId); //Primary Key
                entityTypeBuilderCustomer.Property(cus => cus.CustomerId).IsRequired();
                entityTypeBuilderCustomer.Property(cus => cus.CustomerName).IsRequired();
                entityTypeBuilderCustomer.Property(cus => cus.CustomerAddress).HasMaxLength(50);
                entityTypeBuilderCustomer.Property(cus => cus.CustomerMobileNo).IsRequired();
                entityTypeBuilderCustomer.Property(cus => cus.CustomerCity).HasMaxLength(4);
                entityTypeBuilderCustomer.Property(cus => cus.CustomerState).IsRequired();
                entityTypeBuilderCustomer.Property(cus => cus.CustomerEmail).IsRequired();
            }
        }
}
