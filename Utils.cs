namespace sys23m_webshop;

public static class Utils
{
    public static string AskForInput(string prompt)
    {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
    }
}