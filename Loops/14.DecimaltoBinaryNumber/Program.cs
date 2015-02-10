using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimaltoBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your decimal number. ");
            int number = int.Parse(Console.ReadLine());
            String binary = String.Empty;
            if (number == 0) Console.WriteLine("0");
            else
            {
                while (number > 0)
                {
                    binary += (number % 2).ToString();
                    number = number / 2;
                }
                char[] tmp = binary.ToCharArray();
                Array.Reverse(tmp);
                String result = new String(tmp);
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
