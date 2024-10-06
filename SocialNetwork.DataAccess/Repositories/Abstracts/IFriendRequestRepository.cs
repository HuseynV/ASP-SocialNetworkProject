using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface IFriendRequestRepository
{
    Task<List<FriendRequest>> GetAllAsync();
    Task<FriendRequest> GetByIdAsync(int id);
    Task AddAsync(FriendRequest FriendRequest);
    Task DeleteAsync(FriendRequest FriendRequest);
    Task UpdateAsync(FriendRequest FriendRequest);
}
