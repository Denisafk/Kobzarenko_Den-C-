using System.Linq;
namespace Bibliotec
{
    internal class Library
    {
        private List<Book> _books = new List<Book>();
        public void AddBook(Book book)
        {
            _books.Add(book);
            
        }
        private List<Reader> _readers = new List<Reader>();
        public void AddReader(Reader reader)
        {
            _readers.Add(reader);
        }
        public void BorrowBook(int readerId, int bookId)
        {
            Reader reader = _readers.FirstOrDefault(r => r.ReaderId == readerId);
            Book book = _books.FirstOrDefault(b => b.BookId == bookId);
            if (reader != null && book != null && book.IsAvailable)
            {
                reader.BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"Книга '{book.BookTitle}' Орендована '{reader.ReaderName}'.");
            }
            else
            {
                Console.WriteLine("Книга недоступна або читач/книга не знайдені.");
            }
        }
        public void info()
        {
            Console.WriteLine("Інформація про бібліотеку:");
            Console.WriteLine("Книги:");
            foreach (var book in _books)
            {
                Console.WriteLine($"- {book.BookTitle} - {book.BookAuthor} (ID: {book.BookId}) - Доступна: {book.IsAvailable}");
            }
            Console.WriteLine("Читачі:");
            foreach (var reader in _readers)
            {
                Console.WriteLine($"- {reader.ReaderName} (ID: {reader.ReaderId}) - Орендовані книги: {string.Join(", ", reader.BorrowedBooks.Select(b => b.BookTitle))}");
            }
        }
        public void AvailableBooks()
        {
            Console.WriteLine("Доступні книги:");
            foreach (var book in _books.Where(b => b.IsAvailable))
            {
                Console.WriteLine($"- {book.BookTitle} - {book.BookAuthor} (ID: {book.BookId})");
            }
        }
        public void ReturnBook(int readerId, int bookId)
        {
            Reader reader = _readers.FirstOrDefault(r => r.ReaderId == readerId);
            Book book = _books.FirstOrDefault(b => b.BookId == bookId);
            if (reader != null && book != null && reader.BorrowedBooks.Contains(book))
            {
                reader.BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"Книга '{book.BookTitle}' повернена читачем '{reader.ReaderName}'.");
            }
            else
            {
                Console.WriteLine("Книга не була орендована цим читачем або читач/книга не знайдені.");
            }
        }
    }
}
