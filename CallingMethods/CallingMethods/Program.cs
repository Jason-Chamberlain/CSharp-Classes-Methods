using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MyMath class
            MyMath myMath = new MyMath(); 

            try // Start a try block to handle potential exceptions
            {
                // Prompt the user for input and store user's input as an integer
                Console.WriteLine("What number would you like to perform the math operations on?");
                int number = Convert.ToInt32(Console.ReadLine());

                // Call the Add, Subtract and Multiply methods from the myMath instance and store the results
                int sum = myMath.Add(number);
                int difference = myMath.Subtract(number);
                int product = myMath.Multiply(number);

                // Display the results of each method called
                Console.WriteLine(number + " plus 2 equals " + sum);
                Console.WriteLine(number + " minus 2 equals " + difference);
                Console.WriteLine(number + " times 2 equals " + product);
            }
            catch (FormatException ex) // Catch a FormatException if user input can't be converted to an integer
            {
                // Display the error message and prompt for a valid integer
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid integer.");
            }
            catch (Exception ex) // Catch any other exceptions
            {
                // Display the error message
                Console.WriteLine(ex.Message);
            }

            // Read a line from the console to prevent the program from closing immediately
            Console.ReadLine();
        }
    }
}
