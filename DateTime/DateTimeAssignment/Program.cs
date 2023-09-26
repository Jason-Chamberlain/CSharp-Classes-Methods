using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentTime);

            // Ask the user for a number
            Console.Write("Enter a number: ");
            int hoursToAdd = Convert.ToInt32(Console.ReadLine());

            // Calculate the new time by adding user input hours to the current time
            DateTime newTime = currentTime.AddHours(hoursToAdd);
            Console.WriteLine("In {0} hours, the time will be: {1}", hoursToAdd, newTime);
            
            Console.ReadLine();
        }
    }
}
