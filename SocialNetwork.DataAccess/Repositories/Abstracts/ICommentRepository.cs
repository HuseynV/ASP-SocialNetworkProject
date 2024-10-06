using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Abstracts;

public interface ICommentRepository
{
    Task<List<Comment>> GetAllCommentsAsync();
    Task<Comment> GetCommentAsync(int id);
    Task AddAsync(Comment comment);
    Task DeleteAsync(Comment comment);
    Task UpdateAsync(Comment comment);
}
