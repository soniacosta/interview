using Interview.Infrastructure;
using Interview.Models;
using Interview.Services;

var items = new List<Item>
{
	new() { Id = 1, Name = "GUCCI Boots" },
	new() { Id = 2, Name = "Balenciaga tshirt" },
	new() { Id = 3, Name = "Rolex Watch" },
    new() { Id = 4, Name = "Prada Handbag" },
    new() { Id = 5, Name = "Louis Vuitton Wallet" }
};

var stock = new Dictionary<int, int>
{
	[1] = 12,
	[2] = 8,
	[3] = 0,
    [4] = 5,
    [5] = 2
};

var itemRepository = new ItemRepository(items, stock);
var stockManager = new StockManager(itemRepository);
var order = new Order(
	Guid.NewGuid(),
	new List<OrderItem>
	{
		//new(1, 1),
		//new(2, 3)
		//new(4, 1),
		//new(5, 2)
	});

var hasStock = stockManager.CheckStock(order);
Console.WriteLine($"Order {order.Id} has stock: {hasStock}");
