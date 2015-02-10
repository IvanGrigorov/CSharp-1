using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinarytoDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the binary number. ");
            String binary = Console.ReadLine();
            int result = 0 ;
            for (int i = 0, pow = binary.Length - 1; i < binary.Length; i++, pow--)
            {
                result += (int)Char.GetNumericValue(binary[i]) * (int)(Math.Pow(2, pow));            
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}
