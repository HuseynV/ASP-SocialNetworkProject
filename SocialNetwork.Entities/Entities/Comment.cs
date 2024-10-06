using System.Reflection.Metadata.Ecma335;
using System.Web;

namespace SocialNetwork.Entities.Entities;

public class Comment
{
    public int Id { get; set; }
    public DateTime? WritingDate { get; set; }
    public string? Content { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public string? SenderId { get; set; }
    public CustomIdentityUser? Sender { get; set; }
    public int LikeCount { get; set; }

}
