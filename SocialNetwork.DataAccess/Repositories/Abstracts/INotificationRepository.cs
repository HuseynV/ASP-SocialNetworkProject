using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface INotificationRepository
{
    Task<List<Notification>> GetAllAsync();
    Task<Notification> GetByIdAsync(int id);
    Task AddAsync(Notification Notification);
    Task DeleteAsync(Notification Notification);
    Task UpdateAsync(Notification Notification);
}
