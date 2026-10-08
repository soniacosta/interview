using Interview.Models;

namespace Interview.Contracts;

public interface IItemRepository
{
    Item? GetById(int itemId);

    int GetStockByItemId(int itemId);
}
