static (int,string) GetData()
{
    return (101,"John");
}

var (id,name) = GetData();

Console.WriteLine(id);
Console.WriteLine(name);