using Chat.Domain.Models;

namespace Chat.Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий по работе с пользователями
/// </summary>
public interface IUserRepository : IBaseRepository<User>
{
    /// <summary>
    /// Получить пользователя по ID
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Найденный пользователь</returns>
    public Task<User> GetUserByIdAsync(string id);

    /// <summary>
    /// Получиться всех пользователей
    /// </summary>
    /// <returns>Перечисление пользователей</returns>
    public Task<IEnumerable<User>> GetAllUsersAsync();
}