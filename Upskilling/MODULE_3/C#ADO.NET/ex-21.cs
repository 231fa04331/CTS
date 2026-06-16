static void Check(object obj)
{
    if(obj is int x)
        Console.WriteLine($"Integer {x}");

    string result = obj switch
    {
        int => "Integer",
        string => "String",
        _ => "Unknown"
    };

    Console.WriteLine(result);
}