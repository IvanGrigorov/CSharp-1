using System;
using System.Numerics;

class CalculateNthCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger numerator = 1, denominator = 1;
        for (int i = 2; i <= (2 * n); i++)
        {
            numerator *= i;
            if ((n + 1) >= i)
            {
                denominator *= i;
            }
            if (n >= i)
            {
                denominator *= i;
            }
        }
        Console.WriteLine("{0}. Catalan number = {1}", n, (numerator / denominator));
    }
}