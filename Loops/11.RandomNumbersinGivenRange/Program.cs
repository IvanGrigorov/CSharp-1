using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersinGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("min= ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("max= ");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ",random.Next(min,max+1));
            }
        }
    }
}
