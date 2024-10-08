using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class FriendRequestService : IFriendRequestService
{
    private readonly IFriendRequestRepository? _friendRepository;

    public FriendRequestService(IFriendRequestRepository? friendRepository)
    {
        _friendRepository = friendRepository;
    }

    public async Task AddAsync(FriendRequest friendRequest)
    {
        await _friendRepository.AddAsync(friendRequest);
    }

    public async Task DeleteAsync(FriendRequest friendRequest)
    {
        await _friendRepository.DeleteAsync(friendRequest);
    }

    public async Task<List<FriendRequest>> GetAllAsync()
    {
        return await _friendRepository.GetAllAsync();
    }

    public async Task<FriendRequest> GetByIdAsync(int id)
    {
        return await _friendRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(FriendRequest friendRequest)
    {
        await _friendRepository.UpdateAsync(friendRequest);
    }
}
