using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface IFriendRequestService
{
    Task<List<FriendRequest>> GetAllAsync();
    Task<FriendRequest> GetByIdAsync(int id);
    Task AddAsync(FriendRequest friendRequest);
    Task UpdateAsync(FriendRequest friendRequest);
    Task DeleteAsync(FriendRequest friendRequest);
}
