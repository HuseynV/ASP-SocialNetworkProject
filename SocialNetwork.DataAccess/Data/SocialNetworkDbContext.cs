using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Data;

public class SocialNetworkDbContext:IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
{
    public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options) : base(options){}

    public DbSet<Friend> Friends { get; set; }
    public DbSet<FriendRequest> FriendRequests { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    
}
