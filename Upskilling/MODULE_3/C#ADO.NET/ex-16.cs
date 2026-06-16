class Person
{
    public string? Name { get; set; }
}

Person? p = null;

Console.WriteLine(p?.Name ?? "No Name");