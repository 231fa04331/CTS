class Contact
{
    public string? Name { get; set; }
}

Contact? contact = null;

Console.WriteLine(contact?.Name ?? "Contact Not Found");