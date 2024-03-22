using System.Diagnostics;
using ConsoleApp1;

ILibrary lib = new Library();

while (true)
{
    Console.WriteLine("1 Добавить Элемент");
    Console.WriteLine("2 Удалить Элемент");
    Console.WriteLine("3 Поиск по имени");
    Console.WriteLine("4 Поиск автору");
    Console.WriteLine("5 Поиск по дате");
    Console.WriteLine("6 Выйти");
    
    int.TryParse(Console.ReadLine(),out int command);

    switch (command)
    {
        case 1:
        {
            Console.WriteLine("Имя, Автор");
            lib.AddBook(new Book(Console.ReadLine(),Console.ReadLine()));
        }
            break;
        case 2:
        {
            Console.WriteLine("Имя");
            lib.DeleteBook(Console.ReadLine());
        }
            break;
        case 3:
        {
            Console.WriteLine("Имя");
            var list = lib.GetBooksByName(Console.ReadLine());
            list.ForEach(p => Console.WriteLine(p.GetInfo()));
        }
            break;
        case 4:
        {
            Console.WriteLine("Автор");
            var list = lib.GetBooksByAuthor(Console.ReadLine());
            list.ForEach(p => Console.WriteLine(p.GetInfo()));
        }
            break;
        case 5:
        {
            Console.WriteLine("Дата");
            var list = lib.GetBooksByDate(DateOnly.Parse(Console.ReadLine()));
            list.ForEach(p => Console.WriteLine(p.GetInfo()));
        }
            break;
        case 6:
        {
            Process.GetCurrentProcess().Kill();
        }
            break;
        
    }
    
}