using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace SocialNetwork.Entities.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public string? Image { get; set; }
        public bool IsOnline { get; set; }
        public bool IsFriend { get; set; }
        public bool HasRequestPending { get; set; }
        public DateTime DisconnectTime { get; set; } = DateTime.UtcNow;
        public string? ConnectTime { get; set; }
        public virtual ICollection<Friend>? Friends { get; set; } = new List<Friend>();
        public virtual ICollection<FriendRequest>? FriendRequests  { get; set; } = new List<FriendRequest>();
        public virtual ICollection<Notification>? Notifications  { get; set; } = new List<Notification>();
        public virtual ICollection<Chat>? Chats { get; set; } = new List<Chat>();
        public virtual ICollection<Post>? Posts  { get; set; } = new List<Post>();


    }
}
