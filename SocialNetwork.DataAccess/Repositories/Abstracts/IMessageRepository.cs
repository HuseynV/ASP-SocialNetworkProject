using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface IMessageRepository
{
    Task<List<Message>> GetAllAsync();
    Task<Message> GetByIdAsync(int id);
    Task AddAsync(Message Message);
    Task DeleteAsync(Message Message);
    Task UpdateAsync(Message Message);
}
