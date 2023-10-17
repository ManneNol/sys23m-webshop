namespace sys23m_webshop;

public record Customer(string Username, List<Product> Cart) : IUser;