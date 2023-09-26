using System; 

namespace ParsingEnums 
{
    // Define an enumeration named "DayOfWeek".
    public enum DayOfWeek 
    {
        Monday,    
        Tuesday,   
        Wednesday, 
        Thursday,  
        Friday,    
        Saturday,  
        Sunday     
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            // Start of a try-catch block for exception handling.
            try 
            {
                Console.WriteLine("Enter the day of the week:");                // Prompt the user to enter a day of the week.
                string input = Console.ReadLine();                              // Read the user's input.
                DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input); // Parse the input string into a DayOfWeek enum value.
                Console.WriteLine("Parsed Enum: {0}", today);                   // Display the parsed enum value.
            }
            // Catch block for handling ArgumentException.
            catch (ArgumentException) 
            {
                Console.WriteLine("Please enter an actual day of the week.");   // Display an error message.
            }
            Console.ReadLine();                                                 // Read a line of text from the console.
        }
    }
}