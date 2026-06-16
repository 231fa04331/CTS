class Program
{
    static int CalculateTotal(int a,int b)
    {
        return a+b;
    }

    static double CalculateTotal(double a,double b,double c)
    {
        return a+b+c;
    }

    static void Main()
    {
        Console.WriteLine(CalculateTotal(10,20));
        Console.WriteLine(CalculateTotal(10.5,20.5,30.5));
    }
}