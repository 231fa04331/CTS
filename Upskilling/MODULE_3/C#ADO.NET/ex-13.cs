public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
}

Employee e1 = new()
{
    Id = 1,
    Name = "John"
};

Employee e2 = e1 with { Name = "David" };

Console.WriteLine(e1);
Console.WriteLine(e2);
