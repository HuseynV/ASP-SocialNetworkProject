using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.Business.Services.Concretes;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task AddAsync(Post post)
    {
        await _postRepository.AddAsync(post);
    }

    public async Task DeleteAsync(Post post)
    {
        await _postRepository.DeleteAsync(post);
    }

    public async Task<List<Post>> GetAllAsync()
    {
        return await _postRepository.GetAllAsync();
    }

    public async Task<Post> GetByIdAsync(int id)
    {
        return await _postRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Post post)
    {
        await _postRepository.UpdateAsync(post);
    }
}
