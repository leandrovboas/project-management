using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Application.UseCases.Interface;

namespace ProjectManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class UserControllercs : ControllerBase
{
    private readonly IGetUserUseCase _userUseCase;
    public UserControllercs( IGetUserUseCase userUseCase) 
        => _userUseCase = userUseCase;


    /// <summary>
    /// Esse método retorna um lista com todos os usuários
    /// </summary>
    /// <returns>Uma lista dos usuários</returns>
    /// <response code="200">Retorna os usuários</response>
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUserAsync()
    {
        var result = await _userUseCase.ExecuteAsync();
        return Ok(result);
    }

}
