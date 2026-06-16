abstract class Vehicle
{
    public abstract void Drive();
}

interface IDrivable
{
    void Start();
}

class Car : Vehicle, IDrivable
{
    public override void Drive()
    {
        Console.WriteLine("Driving");
    }

    public void Start()
    {
        Console.WriteLine("Starting");
    }
}