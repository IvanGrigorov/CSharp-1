using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k= ");
            int k = int.Parse(Console.ReadLine());
            int faktoriel1 = 1;
            int faktoriel2 = 1;
            for (int i = n; i > k; i--)
            {
                faktoriel1 *= i;
            }
            for (int i = 1; i <= n-k; i++)
            {
                faktoriel2 *= i;
            }           
            Console.WriteLine("Result: {0} ", faktoriel1/faktoriel2);
        }
    }
}
