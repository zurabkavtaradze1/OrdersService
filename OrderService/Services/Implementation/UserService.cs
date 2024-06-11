using Microsoft.EntityFrameworkCore;
using OrderService.DAL;
using OrderService.DAL.Entities;
using OrderService.Services.DTOs;
using OrderService.Services.Interfaces;
using OrderService.Services.Models;
using OrderService.Tools;

namespace OrderService.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly OrdersDbContext ordersDbContext;

        public UserService(OrdersDbContext ordersDbContext)
        {
            this.ordersDbContext = ordersDbContext;
        }

        public async Task<string> LogIn(LoginDTO login)
        {
            var user = await ordersDbContext.Users.FirstOrDefaultAsync(a => a.UserName == login.UserName).ConfigureAwait(false);
            if (user == null || CryptographyHelper.Encode(login.Password) != user.Password)
            {
                throw new UnauthorizedAccessException();
            }

            // hardcoded for simplicity
            return "bXlQYXNzd29yZF8xNjIzMjE4MTA4MDAwXzIwMjQtMDYtMTcgMTY6MTA6ODAuMDAwMDAwMA==";
        }

        public async Task<int> RegisterUser(UserDTO user)
        {
            var userEntity = new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                UserName = user.UserName,
                Password = CryptographyHelper.Encode(user.Password)
            };

            await ordersDbContext.Users.AddAsync(userEntity).ConfigureAwait(false);
            await ordersDbContext.SaveChangesAsync().ConfigureAwait(false);

            return userEntity.Id;
        }
    }
}
