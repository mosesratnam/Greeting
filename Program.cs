namespace Greeting;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        Console.WriteLine("Greeting!");
        Console.Write("Please type your first name?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello {0}, nice to meet you!", userName);
    }
}
