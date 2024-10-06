using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface IChatRepository
{
    Task<List<Chat>> GetAllAsync();
    Task<Chat> GetByIdAsync(int id);
    Task AddAsync(Chat chat);
    Task UpdateAsync(Chat chat);
    Task DeleteAsync(Chat chat);
}
