using OrderService.DAL;
using OrderService.DAL.Entities;
using OrderService.Services.Interfaces;

namespace OrderService.Services.Implementation
{
    public class ItemService : IItemService
    {
        private readonly OrdersDbContext ordersDbContext;

        public ItemService(OrdersDbContext ordersDbContext)
        {
            this.ordersDbContext = ordersDbContext;
        }

        public IEnumerable<Item> GetItems()
        {
            return ordersDbContext.Items.AsEnumerable();
        }
    }
}
