using UserAuth.Models.Dto;

namespace UserAuth.Repositories;

public interface IUserRepository
{
    Task<string> Register(UserRegisterDto dto);
    Task<string> Login(UserLoginDto dto);
}