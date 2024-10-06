using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface ICustomIdentityUserService
{
    Task<List<CustomIdentityUser>> GetAllAsync();
    Task<CustomIdentityUser> GetByIdAsync(string id);
    Task AddAsync(CustomIdentityUser user);
    Task UpdateAsync(CustomIdentityUser user);
    Task DeleteAsync(CustomIdentityUser user);
}
