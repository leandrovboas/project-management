using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class UserControllercs : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByIdAsync(Guid userid)
    {
        
        return Ok();
    }

}
