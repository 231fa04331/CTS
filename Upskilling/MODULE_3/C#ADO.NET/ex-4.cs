using System;

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var number = 10;

        var text = "Hello";

        Student student = new()
        {
            Name = "Ravi"
        };

        Console.WriteLine(number.GetType());
        Console.WriteLine(text.GetType());
        Console.WriteLine(student.GetType());
    }
}