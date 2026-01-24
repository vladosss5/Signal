using Chat.Application.Interfaces.Repositories;
using Chat.Application.Interfaces.Services;
using Chat.Domain.Models;

namespace Chat.Implementation.Services;

/// <summary>
/// Сервис по работе с аккаунтом
/// </summary>
public class AccountingService : IAccountingService
{
    private readonly IUserRepository _userRepository;
    
    public AccountingService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    /// <summary>
    /// Зарегистрировать пользователя
    /// </summary>
    /// <param name="creatingUser">Регистрируемый пользователь</param>
    public async Task RegistrationUserAsync(User creatingUser)
    {
        creatingUser.Id = Guid.NewGuid().ToString();

        await _userRepository.AddAsync(creatingUser);
    }
}