using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Abstracts;

public interface ICommentService
{
    Task<List<Comment>> GetAllAsync();
    Task<Comment> GetByIdAsync(int id);
    Task AddAsync(Comment comment);
    Task UpdateAsync(Comment comment);
    Task DeleteAsync(Comment comment);
}
