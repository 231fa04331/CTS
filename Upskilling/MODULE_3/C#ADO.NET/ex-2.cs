using System;

class Student
{
    public string Name;
}

class Program
{
    static void ChangeInt(int x)
    {
        x = 100;
    }

    static void ChangeStudent(Student s)
    {
        s.Name = "John";
    }

    static void Main()
    {
        int num = 10;

        Student st = new Student();
        st.Name = "David";

        Console.WriteLine("Before:");
        Console.WriteLine(num);
        Console.WriteLine(st.Name);

        ChangeInt(num);
        ChangeStudent(st);

        Console.WriteLine("After:");
        Console.WriteLine(num);
        Console.WriteLine(st.Name);
    }
}