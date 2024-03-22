namespace ConsoleApp1;

public class Book : IBook
{
    public Book( string name, string author)
    {
        CreatedAt = DateOnly.FromDateTime(DateTime.Now);
        Name = name;
        Author = author;
    }

    public string Name { get; set; }
    public string Author { get; set; }
    public DateOnly CreatedAt { get; set; }
    
    public string GetInfo()
    {
        return $"""
                Name: {Name}
                Author: {Author}
                Released: {CreatedAt}
                """;
    }
}