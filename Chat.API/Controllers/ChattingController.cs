using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ChattingController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateChat(string[] userIds)
    {
        return Ok();
    }
}