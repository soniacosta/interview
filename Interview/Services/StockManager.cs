using Interview.Contracts;
using Interview.Models;

namespace Interview.Services;

public sealed class StockManager(IItemRepository itemRepository)
{
	public bool CheckStock(Order order)
    {
		//TODO: Implement the logic to check if all items in the order are available and in stock
		throw new NotImplementedException("Candidate should implement Check Stock logic.");
	}

	public Task DeprecateItem(int itemId)
    {
		//TODO: Implement the logic to deprecate an item
		throw new NotImplementedException("Candidate should implement Deprecate Item logic.");
	}
}
