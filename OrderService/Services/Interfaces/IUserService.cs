using OrderService.Services.DTOs;
using OrderService.Services.Models;

namespace OrderService.Services.Interfaces
{
    public interface IUserService
    {
        Task<int> RegisterUser(UserDTO user);
        Task<string> LogIn(LoginDTO login);
    }
}
