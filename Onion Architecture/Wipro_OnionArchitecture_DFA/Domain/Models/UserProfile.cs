using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class UserProfile
{
    public int UserProfileId { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserProfileAddress { get; set; }

    public string? UserContact { get; set; }

    public virtual User? User { get; set; }
}
