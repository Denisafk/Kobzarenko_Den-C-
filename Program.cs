using System.Text;
namespace Bibliotec
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Library library = new Library();

            
            library.AddBook(new Book("Заповіт", "Тарас Шевченко", 1));
            library.AddBook(new Book("І не лишилось жодного", "Агата Крісті", 2));
            library.AddBook(new Book("1984", "Джордж Орвелл", 3));
            library.AddBook(new Book("451 градусів по Фаренгейту", "Джейн Остін", 4));
            library.AddBook(new Book("Пірати Карибського Моря", "Роберт Лістон", 5));

        
            library.AddReader(new Reader("Джейсон", 1));
            library.AddReader(new Reader("Боб", 2));
            library.AddReader(new Reader("Чарлі", 3));

            Console.WriteLine("=== Вільні книги ===");
            library.AvailableBooks();

            Console.WriteLine();

            Console.WriteLine("=== Орендована книга ===");
            library.BorrowBook(1, 1);

            Console.WriteLine();

            Console.WriteLine("=== Спроба оренди тієї ж книги знову ===");
            library.BorrowBook(2, 1);

            Console.WriteLine();

            Console.WriteLine("=== Інформація про бібліотеку ===");
            library.info();

            Console.WriteLine();

            Console.WriteLine("=== Повернення книги ===");
            library.ReturnBook(1, 1);

            Console.WriteLine();

            Console.WriteLine("=== Доступні книги після повернення ===");
            library.AvailableBooks();

            Console.WriteLine();

            Console.WriteLine("=== Повна інформація про бібліотеку ===");
            library.info();
        }
    }
}
