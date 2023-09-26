using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParamatersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();

            Console.WriteLine("Input first number:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number (press enter if no second number):");
            string input2string = Console.ReadLine();

            int input2;
            if (string.IsNullOrWhiteSpace(input2string))
            {
                input2 = 0;
            }
            else
            {
                input2 = Convert.ToInt32(input2string);
            }

            int result1 = myMath.Addition(input1);
            int result2 = myMath.Addition(input1, input1);
            int result3 = myMath.Addition(input1, input2);

            Console.WriteLine("Passed input1 once: {0} + 0 = {1}", input1, result1);
            Console.WriteLine("Passed input1 twice: {0} + {0} = {1}", input1, result2);
            Console.WriteLine("Passed input1 and input2: {0} + {1} = {2}", input1, input2, result3);

            Console.ReadLine();
        }
    }
}
