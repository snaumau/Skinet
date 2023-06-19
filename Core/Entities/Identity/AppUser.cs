using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity;

public class AppUser : IdentityUser
{
    public string DisplayName { get; set; } = string.Empty;
    
    public required Address Address { get; set; }
}