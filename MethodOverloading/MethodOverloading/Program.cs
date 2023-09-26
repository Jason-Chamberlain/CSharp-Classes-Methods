using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Create an instance of the MyMath class
            MyMath myMath = new MyMath();

            // Initialize paramaters of various data types
            int number = 17; 
            decimal number1 = 17.00m;
            string number2 = "17";

            // Call the Square method with integer and display the result
            int result = myMath.Square(number);
            Console.WriteLine("{0} squared is {1}", number, result);

            // Call the Square method with decimal and display the result
            int result1 = myMath.Square(number1);
            Console.WriteLine("{0} squared is {1}", number1, result1);

            // Call the Square method with string and display the result
            int result2 = myMath.Square(number2);
            Console.WriteLine("{0} squared is {1}", number2, result2);

            // Read a line from the console to prevent the program from closing immediately
            Console.ReadLine();
        }
    }
}