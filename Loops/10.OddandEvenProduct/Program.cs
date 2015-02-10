using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddandEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] delimeters = {' '};
            Console.WriteLine("Enter your numbers separated by a space. ");
            String input = Console.ReadLine();
            String[] newInput = input.Split(delimeters);
            int evenProduct=1;
            int oddProduct=1;
            for (int i = 0; i < newInput.Length; i++)
            {
                int number = int.Parse(newInput[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= number;
                }
                else
                {
                    oddProduct *= number;
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
