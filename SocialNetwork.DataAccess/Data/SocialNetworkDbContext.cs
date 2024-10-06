using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Data;

public class SocialNetworkDbContext:IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
{
    public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options) : base(options)
    {
        
    }
}
