namespace PokemonWebShop;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public Item(int id, string name, int stock, int price, string description, string imageUrl)
    {
        Id = id;
        Name = name;
        Stock = stock;
        Price = price;
        Description = description;
        ImageUrl = imageUrl;
    }
}
