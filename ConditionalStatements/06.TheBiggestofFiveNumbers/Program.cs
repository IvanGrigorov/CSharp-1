using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheBiggestofFiveNumbers
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
            Console.WriteLine("Please, enter the fourth number. ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the fifth number. ");
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);

            }
        }
    }
}
