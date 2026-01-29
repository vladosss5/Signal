using Chat.API.DTOs.Registration;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegistrationUser(RegistrationRequestDto requestDto)
    {
        return Ok();
    }
}