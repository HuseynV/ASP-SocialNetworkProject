using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class NotificatonService : INotificationService
{
    private readonly INotificationRepository? _repository;
public NotificatonService(INotificationRepository? repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Notification notification)
    {
        await _repository.AddAsync(notification);
    }

    public async Task DeleteAsync(Notification notification)
    {
        await _repository.DeleteAsync(notification);
    }

    public async Task<List<Notification>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Notification> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Notification notification)
    {
        await _repository.UpdateAsync(notification);
    }
}
