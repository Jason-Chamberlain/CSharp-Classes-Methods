using System;

namespace MethodOptionalParamatersAssignment
{
    class MyMath
    {
        public int Addition(int num1, int num2 = 0)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
