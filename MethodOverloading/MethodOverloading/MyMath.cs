using System;

namespace MethodOverloading 
{
    class MyMath 
    {
        // Define a public method named Square that takes an integer parameter num
        // Calculate the square of input integer and return the results
        public int Square(int num)
        {
            int square = num * num;
            return square;
        }

        // Define a public method named Square that takes a decimal parameter num
        // Calculate the square of the input decimal, convert to integer and return the results
        public int Square(decimal num)
        {            
            decimal square = num * num;
            return Convert.ToInt32(square);
        }

        // Define a public method named Square that takes a string parameter num
        // Convert the input string to an integer, calculate the square and return the results
        public int Square(string num)
        {            
            int number = Convert.ToInt32(num);
            int square = number * number;
            return square;
        }
    }
}