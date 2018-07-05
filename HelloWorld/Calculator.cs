using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public float Divide(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (float) x / y;
        }
    }
}
