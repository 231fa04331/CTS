using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

User user = new()
{
    Name="John",
    Age=25,
    Email="john@gmail.com"
};

string json = JsonSerializer.Serialize(user);

File.WriteAllText("user.json",json);

string content = File.ReadAllText("user.json");

User? newUser =
JsonSerializer.Deserialize<User>(content);

Console.WriteLine(newUser?.Name);