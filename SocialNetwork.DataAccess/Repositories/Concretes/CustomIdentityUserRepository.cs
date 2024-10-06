using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes;

public class CustomIdentityUserRepository : ICustomIdentityUserRepository
{
    private readonly SocialNetworkDbContext _context;
    public CustomIdentityUserRepository(SocialNetworkDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(CustomIdentityUser user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(CustomIdentityUser user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task<List<CustomIdentityUser>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<CustomIdentityUser> GetByIdAsync(string id)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
    }


    public async Task UpdateAsync(CustomIdentityUser user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
}
