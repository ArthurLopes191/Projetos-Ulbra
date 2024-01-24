using Microsoft.AspNetCore.Mvc;

namespace webApiFirst.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public string hello()
    {
        return "hello";
    }
}
