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
 
        Console.Write("Please enter your birthdate?");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        int userAge = DateTime.Today.Year - birthdate.Year;
        if(DateTime.Today.Year - birthdate.Year < 10){
            Console.WriteLine("Do you like dinosaurs?");
        } else {
            Console.WriteLine("You're a big boy now!");
        }
        //TimeSpan userAge = DateTime.Today.Year - birthdate.Year;
        //Console.WriteLine(userAge.Ticks);

        if(firstName != "" & lastName != ""){
            if(CheckIsUpper(true, firstName) & CheckIsUpper(true, lastName)){
                Console.WriteLine("Hello {0} {1}! no need to shout!", firstName.ToLower(), lastName.ToLower());  
            } else {
                Console.WriteLine("Hello {0} {1}!", firstName, lastName);
            }    
            if(firstName.Length + lastName.Length > 12){
                Console.WriteLine("Gosh, you have a long name!");
            }       
        } else if(firstName == "" & lastName == ""){
            Console.WriteLine("I see you're not cooperating!");            
        } else if(firstName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a first name!", lastName);
        } else if(lastName == ""){
            Console.WriteLine("Hello {0}, I see you don't have a last name!", firstName);
        }
    }

    /* bool isUpper = true;
            int i = 0;
            while (isUpper & i < firstName.Length)
            {
                isUpper = char.IsUpper(firstName[i]);
                i++;                
            }
            if (isUpper){
                Console.WriteLine("no need to shout!");
            } */

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
