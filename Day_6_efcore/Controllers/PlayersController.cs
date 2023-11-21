using AutoMapper;
using Day_6_efcore.Context;
using Day_6_efcore.Dtos.Reuqests;
using Day_6_efcore.Models;
using Day_6_efcore.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Day_6_efcore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayersController : ControllerBase
{
    private readonly PlayerService _playerService;

    public PlayersController(PlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreatePlayerRequestDto requestDto)
    {
    var response = _playerService.Add(requestDto);
        if (response.StatusCode==System.Net.HttpStatusCode.Created)
        {
            return Created("/",response);
        }
        return BadRequest(response);
    }
    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery]int id)
    {
        var response = _playerService.GetById(id);
        if(response.StatusCode==System.Net.HttpStatusCode.NotFound)
        {
            return Ok(response);

        }
        if(response.StatusCode==System.Net.HttpStatusCode.NotFound)
        {
            return NotFound(response);
        }

        return BadRequest(response);
    }
   
}
