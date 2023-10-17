using sys23m_webshop;

IUser? user = null;

do
{
    switch (Console.ReadLine())
    {
        case "1":
            LoginMenu.Register();
            break;
        case "2":
            user = LoginMenu.Login();
            break;
    }
} while (user is null);


if (user is Customer)
{
    Console.WriteLine("1. check cart");
    Console.WriteLine("2. browse products");
    Console.WriteLine("3. check history");
}
else if (user is Admin)
{
    Console.WriteLine("1. check products");
    Console.WriteLine("2. add product");
    Console.WriteLine("3. remove product");
}