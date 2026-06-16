using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        return Factorial(n);
    }

    static void Main()
    {
        Console.WriteLine(CalculateFactorial(5));
    }
}