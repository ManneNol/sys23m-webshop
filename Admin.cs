namespace sys23m_webshop;

public record Admin(string Username) : IUser
{
    public void ShowMainMenu()
    {
        Console.WriteLine($"Current User: {Username}...");
        Console.WriteLine("1. check products");
        Console.WriteLine("2. add product");
        Console.WriteLine("3. remove product");
    }
}