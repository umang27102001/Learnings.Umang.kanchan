using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CatchWhenClass
    {
        public void Run()
        {
            byte a = 10;
            try
            {
                int b = a / 0;
            }
            catch (DivideByZeroException) when (a % 2 == 1)
            {
                Console.WriteLine("DivideByZero Exception");
            }
            catch (ArithmeticException exp)
            {
                Console.WriteLine($"Arithematic exception {exp}");
                throw exp;
            }
        }
    }
}
