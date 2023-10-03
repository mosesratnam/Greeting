namespace Greeting;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        Console.WriteLine("Greeting!");
        
        Console.Write("Please type your first name?");
        string firstName = Console.ReadLine();
        
        Console.Write("Please type your last name?");
        string lastName = Console.ReadLine();
        
        if(firstName != "" & lastName != ""){
            Console.WriteLine("Hello {0} {1}!", firstName, lastName);
        } else if(firstName == "" & lastName == ""){
            Console.WriteLine("I see you're not cooperating!");            
        } else if(firstName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a first name!", lastName);
        } else if(lastName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a last name!", firstName);
        }
    }
}
