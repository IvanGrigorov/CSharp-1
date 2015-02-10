using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimaltoHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your decimal number. ");
            int number = int.Parse(Console.ReadLine());
            String binary = String.Empty;
            String hex = String.Empty;
            String tmp = String.Empty;
            if (number == 0) Console.WriteLine("0");
            else 
            { 
                while (number > 0)
                {
                    switch (number%16)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            tmp = (number%16).ToString();
                            break;
                        case 10:
                            tmp = "A";
                            break;
                        case 11:
                            tmp = "B";
                            break;
                        case 12:
                            tmp = "C";
                            break;
                        case 13:
                            tmp = "D";
                            break;
                        case 14:
                            tmp = "E";
                            break;
                        case 15:
                            tmp = "F";
                            break;
                        default:
                            tmp = "0";
                            break;
                    }
                    hex += tmp;
                    number = number / 16;
                }
                char[] tmp2 = hex.ToCharArray();
                Array.Reverse(tmp2);
                String result = new String(tmp2);
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
