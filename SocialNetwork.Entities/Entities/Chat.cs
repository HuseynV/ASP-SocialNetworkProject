namespace SocialNetwork.Entities.Entities;

public class Chat
{
    public int Id { get; set; }
    public string? RecieverId { get; set; }
    public CustomIdentityUser? Reciever { get; set; }
    public string? SenderId { get; set; }
    public virtual List<Message> Messages { get; set; } = new();
}
