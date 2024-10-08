﻿using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Application.DTOs;
using ProjectManagement.Application.Exceptions;
using ProjectManagement.Application.UseCases.User;

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
    /// <response code="500">Problema interno na requisição</response>
    [HttpGet()]
    [ProducesResponseType(typeof(UserResponse),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson),StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllUserAsync()
    {
        try
        {
            var result = await _userUseCase.ExecuteAsync();
            return Ok(result);
        }
        catch (Exception)
        {

            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ResponseErrorJson("Ocorreu um problema ao recuperar os usuários"));
        }

    }

}
