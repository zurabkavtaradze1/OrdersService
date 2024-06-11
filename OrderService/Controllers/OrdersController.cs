using Microsoft.AspNetCore.Mvc;
using OrderService.DAL.Entities;
using OrderService.Services.DTOs;
using OrderService.Services.Interfaces;
using OrderService.Services.Models;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("v1")] // fake versioning
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IUserService userService;
        private readonly IItemService itemService;

        public OrdersController(ILogger<OrdersController> logger, IUserService userService, IItemService itemService)
        {
            _logger = logger;
            this.userService = userService;
            this.itemService = itemService;
        }

        /// <summary>
        /// ???????????? ???????????
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("users/register")]
        public async Task<int> Register(UserDTO user)
        {
            return await userService.RegisterUser(user).ConfigureAwait(false);
        }

        [HttpPost("users/login")]
        public async Task<string> LogIn(LoginDTO login)
        {
            return await userService.LogIn(login).ConfigureAwait(false);
        }

        [HttpGet("items")]
        public IEnumerable<Item> GetItems()
        {
            return itemService.GetItems();
        }

        [HttpPost("{userId:int}/orders")]
        public Task<int> PlaceOrder()
        {
            return Task.FromResult(0);
        }
    }
}
