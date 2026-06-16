class Car
{
    public string Make;
    public string Model;
    public int Year;

    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    public Car(string make,string model,int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}