using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    internal class Arithmetic
    {

        public void Add(float a,float b)
        {
            Console.WriteLine( "Addition of numbers is: "+ (a + b));

        }

        public void Subtract(float a, float b)
        {
            Console.WriteLine("Substraction of numbers is: " + (a - b));
        }

        public void Multiply(float a, float b)
        {
            Console.WriteLine("Multiplication of numbers is: " + (a * b));
        }

        public void Divide(float a, float b)
        {
            Console.WriteLine("Division of numbers(a/b) is: " + (a / b));
        }
    }
}
