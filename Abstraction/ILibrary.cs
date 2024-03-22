namespace ConsoleApp1;

public interface ILibrary
{
    public List<IBook> List { get; init; }

    public void AddBook(IBook book);
    
    public void DeleteBook(string name);

    public List<IBook> GetBooksByName(string name);
    
    public List<IBook> GetBooksByAuthor(string author);
    
    public List<IBook> GetBooksByDate(DateOnly date);
}