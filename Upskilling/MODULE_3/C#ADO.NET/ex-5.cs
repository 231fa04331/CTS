using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
            Console.WriteLine("Grade A");
        else if (score >= 80)
            Console.WriteLine("Grade B");
        else if (score >= 70)
            Console.WriteLine("Grade C");
        else
            Console.WriteLine("Grade F");

        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            _ => "F"
        };

        Console.WriteLine($"Switch Grade: {grade}");
    }
}