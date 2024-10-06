using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace SocialNetwork.Entities.Entities;

public class Post
{
    public int Id { get; set; }
    public string? SenderId { get; set; }
    public CustomIdentityUser? Sender { get; set; }
    public string? Text { get; set; }
    public string? Image { get; set; }
    public int LikeCount { get; set; }
    public int CommentCount { get; set; }
    public List<Comment>? Comments { get; set; }
}
