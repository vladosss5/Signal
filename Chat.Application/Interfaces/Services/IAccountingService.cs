using Chat.Domain.Models;

namespace Chat.Application.Interfaces.Services;

/// <summary>
/// Сервис для работы с аккаунтом
/// </summary>
public interface IAccountingService
{
    /// <summary>
    /// Регистраиця пользователя
    /// </summary>
    /// <param name="creatingUser">Регистрируемый пользователь</param>
    public Task RegistrationUserAsync(User creatingUser);
}