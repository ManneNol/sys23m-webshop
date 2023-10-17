namespace sys23m_webshop;

public class Product
{
    public readonly string Name;
    public readonly int Price;
    public Product(string data)
    {
        string[] info = data.Split(",");
        Name = info[0];
        if (int.TryParse(info[1], out int value))
        {
            Price = value;
        }
        else
        {
            throw new Exception();
        }
    }

    
    public override string ToString()
    {
        return $"{Name}: {Price}";
    }
    
}