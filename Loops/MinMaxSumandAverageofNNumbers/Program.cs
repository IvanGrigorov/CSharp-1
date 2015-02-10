using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumandAverageofNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the amount of numbers you want to display. ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            int min = 0;
            int max = 0;
            int sum = 0;
            double average = 0;
            int a = int.Parse(Console.ReadLine());
            min = a;
            sum += a;
            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }
                if (a > max)
                {
                    max = a;
                }
                sum += a;
            }
            average = sum / n;
            Console.WriteLine("min = {0}.", min);
            Console.WriteLine("max = {0}.", max);
            Console.WriteLine("sum = {0}.", sum);
            Console.WriteLine("average = {0:F2}.", average);
        }
    }
}
