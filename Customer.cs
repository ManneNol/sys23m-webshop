namespace sys23m_webshop;

public record Customer(string Username, List<Product> Cart) : IUser
{
    public void ShowMainMenu()
    {
        Console.WriteLine($"Welcome, {Username}!");
        Console.WriteLine("1. check cart");
        Console.WriteLine("2. browse products");
        Console.WriteLine("3. check history");
    }
}