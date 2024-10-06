using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface IFriendService
{
    Task<List<Friend>> GetAllAsync();
    Task<Friend> GetByIdAsync(int id);
    Task AddAsync(Friend friend);
    Task UpdateAsync(Friend friend);
    Task DeleteAsync(Friend friend);
}
