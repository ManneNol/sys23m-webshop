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

user.ShowMainMenu();
