using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface ICustomIdentityUserRepository
{
    Task<List<CustomIdentityUser>> GetAllAsync();
    Task<CustomIdentityUser> GetByIdAsync(int id);
    Task AddAsync(CustomIdentityUser user);
    Task DeleteAsync(CustomIdentityUser user);
    Task UpdateAsync(CustomIdentityUser user);
}
