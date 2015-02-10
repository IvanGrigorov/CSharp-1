using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your score.");
            int score = int.Parse(Console.ReadLine());
            if (1 <= score && score <= 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (4 <= score && score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (7 <= score && score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("Invalid score. ");
            }
        }
    }
}
