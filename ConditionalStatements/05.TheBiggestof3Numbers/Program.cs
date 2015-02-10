using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestof3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the first number. ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number. ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the third number. ");
            double c = double.Parse(Console.ReadLine());           
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c )
            {
                Console.WriteLine(b);
            }
            else 
            {
                Console.WriteLine(c);
            }           
        }
    }
}
