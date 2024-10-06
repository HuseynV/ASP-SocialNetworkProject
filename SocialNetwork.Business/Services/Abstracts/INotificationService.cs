using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface INotificationService
{
    Task<List<Notification>> GetAllAsync();
    Task<Notification> GetByIdAsync(int id);
    Task AddAsync(Notification notification);
    Task UpdateAsync(Notification notification);
    Task DeleteAsync(Notification notification);
}
