using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class GTDPOCController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] dynamic data)
    {
        // Process the data here
        Console.WriteLine(data.ToString());

        // Return an appropriate response
        return Ok("Data received successfully");
    }
}

