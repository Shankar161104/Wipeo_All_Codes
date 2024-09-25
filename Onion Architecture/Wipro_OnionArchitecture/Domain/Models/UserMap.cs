using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Domain.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.Id);
            entityTypeBuilder.Property(t=>t.UserName);
            entityTypeBuilder.Property(t => t.Password);
            entityTypeBuilder.Property(t => t.Email);

            entityTypeBuilder.HasOne(t => t.Profile).WithOne(u => u.User)
                .HasForeignKey<UserProfile>(x => x.Id);

           


        }
    }
}
