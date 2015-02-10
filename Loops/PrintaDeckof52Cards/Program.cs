using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintaDeckof52Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
            }
            char jack = 'J';
            char qween = 'D';
            char knight = 'K';
            char ace = 'A';
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", jack);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", qween);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", knight);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", ace);
        }
    }
}
