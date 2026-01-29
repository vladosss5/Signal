using Chat.Domain.Models;

namespace Chat.Application.Interfaces.Services;

public interface IAccountingService
{
    public Task<User> RegistrationUserAsync(User creatingUser);
}