namespace Bibliotec
{
    internal class Book
    {
        private string _bookTitle;
        private string _bookAuthor;
        private int _bookId;
        private bool _isAvailable;
        public string BookTitle
        {
            get { return _bookTitle; }

        }
        public string BookAuthor
        {
            get { return _bookAuthor; }

        }
        public int BookId
        {
            get { return _bookId; }

        }
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }

        }
        public Book(string bookTitle, string bookAuthor, int bookId)
        {
            _bookTitle = bookTitle;
            _bookAuthor = bookAuthor;
            _bookId = bookId;
            _isAvailable = true;
        }
    }
}
