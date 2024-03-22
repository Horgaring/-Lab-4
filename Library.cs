namespace ConsoleApp1;

public class Library : ILibrary
{
    public Library()
    {
        List = new List<IBook>();
    }

    public List<IBook> List { get; init; }
    
    public void AddBook(IBook book)
    {
        List.Add(book);
    }

    public void DeleteBook(string name)
    {
        List.RemoveAll(p => p.Name == name);
    }

    public List<IBook> GetBooksByName(string name)
    {
        return List.Where(p => p.Name.Contains(name)).ToList();
    }

    public List<IBook> GetBooksByAuthor(string author)
    {
        return List.Where(p => p.Author == author).ToList();
    }

    public List<IBook> GetBooksByDate(DateOnly date)
    {
        return List.Where(p => p.CreatedAt == date).ToList();
    }
}