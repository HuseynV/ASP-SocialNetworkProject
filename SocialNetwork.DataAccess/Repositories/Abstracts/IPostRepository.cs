using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface IPostRepository
{
    Task<List<Post>> GetAllAsync();
    Task<Post> GetByIdAsync(int id);
    Task AddAsync(Post Post);
    Task DeleteAsync(Post Post);
    Task UpdateAsync(Post Post);
}
