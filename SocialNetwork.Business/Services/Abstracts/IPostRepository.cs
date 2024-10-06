using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface IPostRepository
{
    Task<List<Post>> GetAllAsync();
    Task<Post> GetByIdAsync(int id);
    Task AddAsync(Post post);
    Task UpdateAsync(Post post);
    Task DeleteAsync(Post post);
}
