class Student
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

Student s = new()
{
    Name = "Rahul",
    Age = 20
};