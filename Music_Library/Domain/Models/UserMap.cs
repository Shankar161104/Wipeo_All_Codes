using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Models
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Setting the primary key
            builder.HasKey(u => u.UserID);

            // Configuring properties
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(50); // You can specify a max length

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100); // You can specify a max length

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255); // You can specify a max length

            // If needed, you can add indexes, relationships, etc.
        }
    }
}
