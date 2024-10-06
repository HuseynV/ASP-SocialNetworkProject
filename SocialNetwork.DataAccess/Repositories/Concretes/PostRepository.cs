using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccess.Data;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.DataAccess.Repositories.Concretes;

public class PostRepository : IPostRepository
{
    private readonly SocialNetworkDbContext _context;
    public PostRepository(SocialNetworkDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Post post)
    {
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Post post)
    {
        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Post>> GetAllAsync()
    {
        var posts = await _context.Posts.Include(nameof(Post.Comments)).Include(nameof(Post.Sender)).ToListAsync();
        return posts;
    }

    public async Task<Post> GetByIdAsync(int id)
    {
        var post = await _context.Posts.Include(nameof(Post.Comments)).Include(nameof(Post.Sender)).FirstOrDefaultAsync(x => x.Id == id);
        return post;
    }

    public async Task UpdateAsync(Post post)
    {
        _context.Posts.Update(post);
        await _context.SaveChangesAsync();
    }
}
