using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes;

public class FriendRequestRepository : IFriendRequestRepository
{
    private readonly SocialNetworkDbContext _context;
    public FriendRequestRepository(SocialNetworkDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(FriendRequest friendRequest)
    {
        await _context.FriendRequests.AddAsync(friendRequest);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(FriendRequest friendRequest)
    {
        _context.FriendRequests.Remove(friendRequest);
        await _context.SaveChangesAsync();
    }

    public async Task<List<FriendRequest>> GetAllAsync()
    {
        var friendRequests = await _context.FriendRequests.ToListAsync();
        return friendRequests;
    }

    public async Task<FriendRequest> GetByIdAsync(int id)
    {
        var friendRequest = await _context.FriendRequests.FirstOrDefaultAsync(x => x.Id == id);
        return friendRequest;
    }

    public async Task UpdateAsync(FriendRequest friendRequest)
    {
        _context.FriendRequests.Update(friendRequest);
        await _context.SaveChangesAsync();
    }
}
