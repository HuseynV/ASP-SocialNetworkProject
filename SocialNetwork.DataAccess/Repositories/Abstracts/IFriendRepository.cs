using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface IFriendRepository
{
    Task<List<Friend>> GetAllAsync();
    Task<Friend> GetByIdAsync(int id);
    Task AddAsync(Friend friend);
    Task DeleteAsync(Friend friend);
    Task UpdateAsync(Friend friend);
}
