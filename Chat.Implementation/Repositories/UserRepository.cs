using Chat.Application.Interfaces.Repositories;
using Chat.Data.Context;
using Chat.Domain.Models;

namespace Chat.Implementation.Repositories;

public class UserRepository : IUserRepository
{
    private readonly SignalDBContext _dbContext;
    
    public UserRepository(SignalDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<User> AddAsync(User entity)
    {
        _dbContext.Users.Add(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<User> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }
}