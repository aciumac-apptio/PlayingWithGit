using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Runner
    {

        public Runner()
        {

        }

        public void Run()
        {
            Console.WriteLine("Hello World! I made my first commit!");
            Console.WriteLine("Hello World! I made my second commit!");
            Console.WriteLine("Hello World! From user 2!");
            Console.WriteLine("Hello World! No let me change it!");

            var calc = new Calculator();
            var x = 5; var y = 9;
            Console.WriteLine($"Sum of {x} and {y} is {calc.Add(x, y)}");
            Console.WriteLine($"Difference of {x} and {y} is {calc.Subtract(x, y)}");
        }
    }
}
