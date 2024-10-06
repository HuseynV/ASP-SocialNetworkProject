using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes
{
    public class ChatRepository : IChatRepository
    {
        private readonly SocialNetworkDbContext _context;
        public ChatRepository(SocialNetworkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Chat chat)
        {
            await _context.Chats.AddAsync(chat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Chat chat)
        {
            _context.Chats.Remove(chat);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Chat>> GetAllAsync()
        {
            var chats = await _context.Chats.Include(nameof(Chat.Messages)).Include(nameof(Chat.Reciever)).ToListAsync();
            return chats;
        }

        public async Task<Chat> GetByIdAsync(int id)
        {
            var chat = await _context.Chats.FirstOrDefaultAsync(x => x.Id == id);
            return chat;
        }

        public async Task UpdateAsync(Chat chat)
        {
            _context.Chats.Update(chat);
            await _context.SaveChangesAsync();
        }

    }
}
