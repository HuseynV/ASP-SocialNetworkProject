using SocialNetwork.Entities.Entities;
using System;

namespace SocialNetwork.Business.Services.Abstracts;

public interface IChatService
{
    Task<List<Chat>> GetAllAsync();
    Task<Chat> GetByIdAsync(int id);
    Task AddAsync(Chat chat);
    Task UpdateAsync(Chat chat);
    Task DeleteAsync(Chat chat);
}
