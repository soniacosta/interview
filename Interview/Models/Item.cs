namespace Interview.Models;

public sealed class Item
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public bool IsDeprecated { get; set; }
}
