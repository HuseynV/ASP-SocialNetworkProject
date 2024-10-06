using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface IMessageService
{
    Task<List<Message>> GetAllAsync();
    Task<Message> GetByIdAsync(int id);
    Task AddAsync(Message message);
    Task UpdateAsync(Message message);
    Task DeleteAsync(Message message);
}
