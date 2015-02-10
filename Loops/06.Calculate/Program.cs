using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k= ");
            int k = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = n; i >k; i--)
            {
                result *= i;
            }
            Console.WriteLine("Result: {0} ", result);
        }
    }
}
