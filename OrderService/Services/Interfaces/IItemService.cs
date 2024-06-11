using OrderService.DAL.Entities;

namespace OrderService.Services.Interfaces
{
    public interface IItemService
    {
        IEnumerable<Item> GetItems();
    }
}
