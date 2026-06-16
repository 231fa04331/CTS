class Parent
{
    public int PublicVar = 10;
    private int PrivateVar = 20;
    protected int ProtectedVar = 30;

    public void Show()
    {
        Console.WriteLine(PrivateVar);
    }
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine(PublicVar);
        Console.WriteLine(ProtectedVar);
    }
}