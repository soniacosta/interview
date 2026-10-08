namespace Interview.Models;

public sealed record Order(Guid Id, IReadOnlyCollection<OrderItem> Items);
