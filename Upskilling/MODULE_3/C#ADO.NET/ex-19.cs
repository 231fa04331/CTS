List<string> names = new()
{
    "John",
    "David",
    "Sam"
};

Dictionary<int,string> students = new()
{
    {1,"John"},
    {2,"David"}
};

foreach(var n in names)
    Console.WriteLine(n);

foreach(var s in students)
    Console.WriteLine($"{s.Key} {s.Value}");