using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;
using System.Net.Http.Headers;
using System.Reflection;

namespace SocialNetwork.Business.Services.Concretes;

public class MessageService : IMessageService
{
    private readonly IMessageRepository? _messageRepository;

    public MessageService(IMessageRepository? messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task AddAsync(Message message)
    {
        await _messageRepository.AddAsync(message);
    }

    public async Task DeleteAsync(Message message)
    {
        await _messageRepository.DeleteAsync(message);
    }

    public async Task<List<Message>> GetAllAsync()
    {
        return await _messageRepository.GetAllAsync();
    }

    public async Task<Message> GetByIdAsync(int id)
    {
        return await _messageRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Message message)
    {
        await _messageRepository.UpdateAsync(message);
    }
}
