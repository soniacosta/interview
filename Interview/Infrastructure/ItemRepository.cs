using Interview.Contracts;
using Interview.Models;

namespace Interview.Infrastructure;

public sealed class ItemRepository : IItemRepository
{
    private readonly IEnumerable<Item> _items;
    private readonly Dictionary<int, int> _stock;

    public ItemRepository(IEnumerable<Item> items, Dictionary<int, int> stock)
    {
        ArgumentNullException.ThrowIfNull(items);
        ArgumentNullException.ThrowIfNull(stock);

        _items = items;
        _stock = stock;
    }

    public Item? GetById(int itemId)
    {
		// TODO not implemented yet
		throw new NotImplementedException();
	}

    public Task<int> GetStockByItemIdAsync(int itemId)
    {
		// TODO not implemented yet
        throw new NotImplementedException();
    }
}
