namespace ConsoleApp1;

public interface IBook
{
    public string  Name { get; set; }
    public string  Author { get; set; }  
    public DateOnly  CreatedAt { get; set; }

    public string GetInfo();
}