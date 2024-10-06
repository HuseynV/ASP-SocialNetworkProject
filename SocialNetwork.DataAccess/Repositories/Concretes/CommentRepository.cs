using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes;

public class CommentRepository : ICommentRepository
{
    private readonly SocialNetworkDbContext _context;
    public CommentRepository(SocialNetworkDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Comment comment)
    {
        await _context.Comments.AddAsync(comment);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Comment comment)
    {
        _context.Comments.Remove(comment);
        await _context.SaveChangesAsync();
    }


    public async Task<List<Comment>> GetAllCommentsAsync()
    {
        var comments = await _context.Comments.Include(nameof(Comment.Sender)).Include(nameof(Comment.Post)).ToListAsync();
        return comments;
    }

    public async Task<Comment> GetByIdAsync(int id)
    {
        var comment = await _context.Comments.Include(nameof(Comment.Sender)).Include(nameof(Comment.Post)).FirstOrDefaultAsync(x => x.Id == id);
        return comment;
    }

    public Task<Comment> GetCommentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Comment comment)
    {
        _context.Comments.Update(comment);
        await _context.SaveChangesAsync();
    }
}
