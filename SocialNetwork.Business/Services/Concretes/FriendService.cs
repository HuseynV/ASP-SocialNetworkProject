using Microsoft.Identity.Client;
using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class FriendService : IFriendService
{
    private readonly IFriendRepository? _repository;

    public FriendService(IFriendRepository? repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Friend friend)
    {
        await _repository.AddAsync(friend);
    }

    public async Task DeleteAsync(Friend friend)
    {
        await _repository.DeleteAsync(friend);
    }

    public async Task<List<Friend>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Friend> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Friend friend)
    {
        await _repository.UpdateAsync(friend);
    }
}
