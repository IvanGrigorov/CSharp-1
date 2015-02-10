using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlaywithIntDoubleandString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose to enter an integer, a double or a string with 1, 2 or 3. ");
            int sign = int.Parse(Console.ReadLine());
            while (sign < 1 || sign > 3)
            {
                Console.WriteLine("Please, choose to enter an integer, a double or a string with 1, 2 or3. ");
                sign = int.Parse(Console.ReadLine());
            }
            if (sign == 1)
            {
                Console.WriteLine("Please, enter an integer. ");
                int chislo = int.Parse(Console.ReadLine());
                Console.WriteLine(chislo + 1);
            }
            if (sign == 2)
            {
                Console.WriteLine("Please, enter a double. ");
                double chislo2 = double.Parse(Console.ReadLine());
                Console.WriteLine(chislo2 + 1);
            }
            if (sign == 3)
            {
                Console.WriteLine("Please, enter a string. ");
                String input = Console.ReadLine();
                Console.WriteLine(input + "*");
            }
        }
    }
}
