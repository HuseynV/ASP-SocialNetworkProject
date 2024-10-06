using System.Runtime;

namespace SocialNetwork.Entities.Entities;

public class Notification
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? Status { get; set; }
    public string? UserId { get; set; }
    public virtual CustomIdentityUser? User { get; set; }
    public DateTime? DateTime { get; set; }

}
