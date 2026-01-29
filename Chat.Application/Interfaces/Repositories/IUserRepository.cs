using Chat.Domain.Models;

namespace Chat.Application.Interfaces.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    public Task<User> GetUserByIdAsync(string id);

    public Task<IEnumerable<User>> GetAllUsersAsync();
}