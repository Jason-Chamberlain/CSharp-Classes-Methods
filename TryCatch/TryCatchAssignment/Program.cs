using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Ask user for their age
                    Console.WriteLine("What is your age?");
                    int age = int.Parse(Console.ReadLine());

                    // Check if input is valid number (positive)
                    if (age <= 0)
                    {
                        Console.WriteLine("Please enter a positive number for age");
                    }
                    else
                    {
                        // Calculate the birth year
                        int currentYear = DateTime.Now.Year;
                        int birthYear = currentYear - age;

                        // Display year of birth
                        Console.WriteLine("You were born in {0}", birthYear);
                        Console.ReadLine();
                        // Exit loop when valid input is received
                        break;
                    }
                }
                catch (FormatException)
                {
                    // Handle exception if non integer is input
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    Console.WriteLine("An error occured: {0}", ex.Message);
                }
            }            
        }
    }
}
