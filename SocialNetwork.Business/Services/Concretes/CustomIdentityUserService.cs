using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.DataAccess.Repositories.Abstracts;
using SocialNetwork.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Business.Services.Concretes;

public class CustomIdentityUserService : ICustomIdentityUserService
{
    private readonly ICustomIdentityUserRepository? _repository;

    public CustomIdentityUserService(ICustomIdentityUserRepository? repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(CustomIdentityUser user)
    {
        await _repository.AddAsync(user);
    }

    public async Task DeleteAsync(CustomIdentityUser user)
    {
        await _repository.DeleteAsync(user);
    }

    public async Task<List<CustomIdentityUser>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<CustomIdentityUser> GetByIdAsync(string id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(CustomIdentityUser user)
    {
        await _repository.UpdateAsync(user);
    }
}
