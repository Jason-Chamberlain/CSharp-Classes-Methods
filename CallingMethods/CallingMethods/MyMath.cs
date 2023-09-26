namespace CallingMethods
{
    class MyMath
    {
        // Declare a public method named Add, which takes an integer parameter num1
        // Calculate the sum of num1 and 2 and return it as the stored sum variable
        public int Add(int num1)
        {
            int sum = num1 + 2;
            return sum;
        }

        // Declare a public method named Subtract, which takes an integer parameter num1
        // Calculate the difference between num1 and 2 and return it as the stored difference variable
        public int Subtract(int num1)
        {            
            int difference = num1 - 2;
            return difference;
        }

        // Declare a public method named Multiply, which takes an integer parameter num1
        // Calculate the product of num1 and 2 and return it as the stored product variable
        public int Multiply(int num1)
        {            
            int product = num1 * 2;
            return product;
        }
    }
}
