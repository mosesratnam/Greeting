using System.Reflection.Metadata.Ecma335;

namespace Greeting;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        Console.WriteLine("Greeting!");

        Person user = new Person();        
        Console.Write("Please type your first name?");
        user.firstName = Console.ReadLine();
                
        Console.Write("Please type your last name?");
        user.lastName = Console.ReadLine();
 
        Console.Write("Please enter your birthdate?");
        user.birthDate = DateTime.Parse(Console.ReadLine());
        if (user.IsUnderTen()){
            Console.WriteLine("You must like donosaurs!");
        } else {
            Console.WriteLine("You're a big boy!");
        }
        
        
        if(user.firstName != "" & user.lastName != ""){
            if(user.IsNameUpper()){
                Console.WriteLine("Hello {0} {1}! no need to shout!", user.firstName.ToLower(), user.lastName.ToLower()); 
            } else {
                Console.WriteLine(user.Greeting());
            }
            
            if(user.IsLongName()){
                Console.WriteLine("Gosh, you have a long name!");
            }    

        } else if(user.firstName == "" & user.lastName == ""){
            Console.WriteLine("I see you're not cooperating!");            
        } else if(user.firstName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a first name!", user.lastName);
        } else if(user.lastName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a last name!", user.firstName);
        }
    }

    private static bool CheckIsUpper(bool upper, string name){
        for (int i = 0; i < name.Length; i++)
        {
            if(!char.IsUpper(name[i])){
                upper = false;  
                break;
            }
        }
        return upper;
    }  
}

class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDate { get; set; } 
    public string Greeting(){
        return String.Format("Hello, {0} {1}!", firstName, lastName);
    }
    public bool IsUnderTen(){
        return (DateTime.Today.Year - birthDate.Year) < 9;        
    }

    public bool IsLongName(){
        return (firstName.Length + lastName.Length) > 12;
    } 

    public bool IsNameUpper(){
        bool upper = true;

        for (int i = 0; i < firstName.Length; i++)
        {
            if(!char.IsUpper(firstName[i])){
                upper = false;
                break;
            }
        }

        if(upper){
            for (int i = 0; i < lastName.Length; i++)
            {
                if(!char.IsUpper(lastName[i])){
                    upper = false;
                    break;
                }
            }
        } else {
            return upper;
        }

        return upper;  
    } 
}
