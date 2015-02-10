using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the first number. ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert the second number. ");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber < secondNumber)
            {
                double tmp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tmp;
            }
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}
