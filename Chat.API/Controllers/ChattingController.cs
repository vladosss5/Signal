using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers;

/// <summary>
/// Контроллер для работы с чатами
/// </summary>
[Route("[controller]")]
[ApiController]
public class ChattingController : ControllerBase
{
    /// <summary>
    /// Создание чата
    /// </summary>
    /// <param name="userIds">Список Id пользователей в чате</param>
    /// <returns>Результат действия</returns>
    [HttpPost]
    public async Task<IActionResult> CreateChat(string[] userIds)
    {
        return Ok();
    }
}