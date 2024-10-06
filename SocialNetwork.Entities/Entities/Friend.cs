namespace SocialNetwork.Entities.Entities;

public class Friend 
{
    public int Id { get; set; }
    public string? OwnId { get; set; }
    public string? YourFriendId { get; set; }
    public virtual CustomIdentityUser? YourFriend { get; set; }
    
}
