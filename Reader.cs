namespace Bibliotec
{
    internal class Reader
    {
       private string _readerName;
       private int _readerId;
       private List<Book> _borrowedBooks = new List<Book>();
        public string ReaderName
        {
            get { return _readerName; }
        }
        public int ReaderId
        {
            get { return _readerId; }
        }
        public List<Book> BorrowedBooks
        {
            get { return _borrowedBooks; }
        }
        public Reader(string readerName, int readerId)
        {
            _readerName = readerName;
            _readerId = readerId;       
        }
    }

}
