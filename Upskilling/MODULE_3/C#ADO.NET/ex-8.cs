using System;

class Program
{
    static void Increment(ref int x)
    {
        x++;
    }

    static void GetValue(out int x)
    {
        x = 100;
    }

    static void Display(in int x)
    {
        Console.WriteLine(x);
    }

    static void Main()
    {
        int a = 10;

        Increment(ref a);
        Console.WriteLine(a);

        int b;
        GetValue(out b);
        Console.WriteLine(b);

        Display(in a);
    }
}