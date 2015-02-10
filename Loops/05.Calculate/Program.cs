using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x= ");
            int x = int.Parse(Console.ReadLine());
            int faktoriel = 1;
            double result = 1;
            for (int i = 1;i<(n+1);i++){
                faktoriel *= i;
                result += (faktoriel / Math.Pow(x, i));
            }
            Console.WriteLine("Result: {0:F5} ", result);
        }
    }
}
