using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
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
            if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
