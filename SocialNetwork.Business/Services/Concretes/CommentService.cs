using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class CommentService : ICommentService
{
    private readonly ICommentRepository? _commentRepository;

    public CommentService(ICommentRepository? commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public async Task AddAsync(Comment comment)
    {
       await _commentRepository.AddAsync(comment);
    }

    public async Task DeleteAsync(Comment comment)
    {
        await _commentRepository.DeleteAsync(comment);
    }

    public async Task<List<Comment>> GetAllAsync()
    {
        return await _commentRepository.GetAllCommentsAsync();
    }

    public async Task<Comment> GetByIdAsync(int id)
    {
       return await _commentRepository.GetCommentAsync(id);
    }

    public async Task UpdateAsync(Comment comment)
    {
       await _commentRepository.UpdateAsync(comment);
    }
}
