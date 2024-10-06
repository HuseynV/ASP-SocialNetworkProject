using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes;

public class MessageRepository : IMessageRepository
{
    private readonly SocialNetworkDbContext _context;
    public MessageRepository(SocialNetworkDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Message message)
    {
        await _context.Messages.AddAsync(message);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Message message)
    {
        _context.Messages.Remove(message);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Message>> GetAllAsync()
    {
        var messages = await _context.Messages.ToListAsync();
        return messages;
    }

    public async Task<Message> GetByIdAsync(int id)
    {
        var message = await _context.Messages.FirstOrDefaultAsync(x => x.Id == id);
        return message;
    }

    public async Task UpdateAsync(Message message)
    {
        _context.Messages.Update(message);
        await _context.SaveChangesAsync();
    }
}
