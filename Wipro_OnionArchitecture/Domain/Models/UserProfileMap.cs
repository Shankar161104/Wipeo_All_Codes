using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Domain.Models
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t =>t.Id);
            entityTypeBuilder.Property(t=>t.FirstName);
            entityTypeBuilder.Property(t=>t.LastName);
            entityTypeBuilder.Property(t=>t.ContactNo);
            entityTypeBuilder.Property(t=>t.Address);

        }
    }
}
