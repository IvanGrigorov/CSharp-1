using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimaltoDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hexadecimal number. ");
            String binary = Console.ReadLine();
            int result = 0;
            int tmp = 0;
            for (int i = 0, pow = binary.Length - 1; i < binary.Length; i++, pow--)
            {
                switch (binary[i])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        tmp = (int)Char.GetNumericValue(binary[i]);
                        break;
                    case 'A':
                        tmp = 10;
                        break;
                    case 'B':
                        tmp = 11;
                        break;
                    case 'C':
                        tmp = 12;
                        break;
                    case 'D':
                        tmp = 13;
                        break;
                    case 'E':
                        tmp = 14;
                        break;
                    case 'F':
                        tmp = 15;
                        break;
                    default:
                        tmp = 0;
                        break;
                }
                result += tmp * (int)(Math.Pow(16, pow));
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}
