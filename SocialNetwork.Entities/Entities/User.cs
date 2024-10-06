using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace SocialNetwork.Entities.Entities;

public class User
{
    public int Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }   
    public string? Gender { get; set; }
    public string? Phone { get; set; }
    public bool HasOnline { get; set; }
    public string? ImageUrl { get; set; }
}
