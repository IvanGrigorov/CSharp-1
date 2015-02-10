using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumberswithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = double.Parse(Console.ReadLine());

            if (a >= b)
                if (b >= c)
                    Console.WriteLine(a + " " + b + " " + c);
                else
                    Console.WriteLine(c + " " + a + " " + b);
            else if (b >= a)
                if (a >= c)
                    Console.WriteLine(b + " " + a + " " + c);
                else
                    Console.WriteLine(c + " " + b + " " + a);
            else if (a >= c && c >= b)
                Console.WriteLine(a + " " + c + " " + b);
            else
                Console.WriteLine(b + " " + c + " " + a);
        }
    }
}
