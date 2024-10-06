using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Reflection.Metadata.Ecma335;

namespace SocialNetwork.Entities.Entities;

public class FriendRequest
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? Status { get; set; }
    public string? SenderId { get; set; }
    public virtual CustomIdentityUser? Sender { get; set; }
    public string?  RecieverId { get; set; }
}
