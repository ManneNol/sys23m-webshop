namespace sys23m_webshop;

public class LoginMenu
{
    public static void Register()
    {
        string username = string.Empty;
        while (username.Length < 3)
        {
            username = Utils.AskForInput("Enter a username: ");
            if (username.Contains(' '))
            {
                username = string.Empty;
                Console.WriteLine("Please don't enter whitespaces in the username");
            }
        }

        string password = string.Empty;
        while (password.Length is < 8 or > 64)
        {
            password = Utils.AskForInput("Please enter your password: ");
            string passwordCheck = Utils.AskForInput("Please re-enter your password: ");
            if (!password.Equals(passwordCheck))
            {
                password = string.Empty;
                Console.WriteLine("Passwords did not match");
            }
        }

        File.Create($"carts/{username}.csv").Close();
        File.AppendAllText("users.csv", $"{username},{password},{Role.Customer}\n");
    }

    public static IUser Login()
    {
        string[] users = File.ReadAllLines("users.csv");
        while (true)
        {
            string input = Utils.AskForInput("Username: ");
            foreach (string line in users)
            {
                string[] info = line.Split(',');
                string name = info[0];

                if (name.Equals(input))
                {
                    input = Utils.AskForInput("Password: ");

                    string pass = info[1];

                    if (pass.Equals(input))
                    {
                        if (Enum.TryParse(info[2], out Role role))
                        {
                            switch (role)
                            {
                                case Role.Customer:
                                    return new Customer(name, LoadCart(name));
                                case Role.Admin:
                                    return new Admin(name);
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }

            Console.WriteLine("No such user exists");
        }
    }

    private static List<Product> LoadCart(string user)
    {
        List<Product> cart = new List<Product>();
        string[] savedCart = File.ReadAllLines($"carts/{user}.csv");
        foreach (string item in savedCart)
        {
            cart.Add(new Product(item));
        }

        return cart;
    }
}