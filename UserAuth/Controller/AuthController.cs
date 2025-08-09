using Microsoft.AspNetCore.Mvc;
using UserAuth.Models.Domains;
using UserAuth.Models.Dto;
using UserAuth.Repositories;

namespace UserAuth.Controller;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _userRepo;
    
    public AuthController(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterDto dto)
    {
        try
        {
            var token = await _userRepo.Register(dto);
            return Ok(new { token });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginDto dto)
    {
        try
        {
            var token = await _userRepo.Login(dto);
            return Ok(new { token });
        }
        catch (Exception ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }
}