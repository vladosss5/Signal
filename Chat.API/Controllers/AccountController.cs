using Chat.API.DTOs.Registration;
using Chat.Application.Interfaces.Services;
using Chat.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers;

/// <summary>
/// Контроллер работы с аккаунтом
/// </summary>
[Route("[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountingService _accountingService;
    
    public AccountController(IAccountingService accountingService)
    {
        _accountingService = accountingService;
    }
    
    /// <summary>
    /// Регистрация пользователя
    /// </summary>
    /// <param name="requestDto">DTO запроса на регистрацию</param>
    /// <returns>Результат действия</returns>
    [HttpPost]
    public async Task<IActionResult> RegistrationUser(RegistrationRequestDto requestDto)
    {
        var registrationUser = new User()
        {
            Name = requestDto.Name,
            Login = requestDto.Login,
            Password = requestDto.Password
        };

        await _accountingService.RegistrationUserAsync(registrationUser);
        
        return Ok();
    }
}