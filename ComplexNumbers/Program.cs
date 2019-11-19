using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(6,8);
            Complex b = new Complex(3,4);
            Complex c = new Complex();

            Console.WriteLine($"A complex number is {a} ");
            Console.WriteLine($"B complex number is {b} ");

            Console.WriteLine($"The absolute of A is {a.Absolute()}");
            Console.WriteLine($"The argument of A is {a.Argument()}");

            Console.WriteLine($"Additon  A B {c = a.Addition(b)}");           
            Console.WriteLine($"Subtraction  A B {c = a.Subtraction(b)}");           
            Console.WriteLine($"Multiply  A B {c = a.Multiply(b)}");        
            Console.WriteLine($"Division  A B {c = a.Division(b)}");

            Console.WriteLine("Trigonometric Form of A");
            a.PrintTrigonometricForm();


            Console.ReadKey();
        }
    }
}
