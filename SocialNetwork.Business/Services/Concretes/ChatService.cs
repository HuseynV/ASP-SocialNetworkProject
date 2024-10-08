using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class ChatService : IChatService
{
    private readonly IChatRepository? _chatRepository;

    public ChatService(IChatRepository? chatRepository)
    {
        _chatRepository = chatRepository;
    }

    public async Task AddAsync(Chat chat)
    {
        await _chatRepository.AddAsync(chat);
    }

    public async Task DeleteAsync(Chat chat)
    {
       await _chatRepository.DeleteAsync(chat);
    }

    public async Task<List<Chat>> GetAllAsync()
    {
        return await _chatRepository.GetAllAsync();
    }

    public async Task<Chat> GetByIdAsync(int id)
    {
        return await _chatRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Chat chat)
    {
         await _chatRepository.UpdateAsync(chat);
    }
}
