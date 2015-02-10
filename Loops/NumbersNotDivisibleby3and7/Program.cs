using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDivisibleby3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the amount of numbers you want to display. ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < (n + 1); i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0)) { 
                Console.Write("{0} ", i);
                }
            }
        }
    }
}
