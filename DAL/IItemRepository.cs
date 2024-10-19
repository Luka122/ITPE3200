using MyShop.Models;

namespace MyShop.DAL;

public interface IItemRepository
{
    Task<IEnumerable<Item>> GetAll();
    Task<Item?> GetItemById(int id);
    Task Create(Item Item);
    Task Update(Item Item);
    Task<bool> Delete(int id);
}