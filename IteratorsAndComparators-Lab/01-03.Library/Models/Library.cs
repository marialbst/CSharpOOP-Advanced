using System.Collections;
using System.Collections.Generic;

public class Library : ILibrary
{
    public Library(params Book[] books)
    {
        //this.Books = books;// new List<Book>(books);
        //task 3
        //this.Books = new SortedSet<Book>(books);
        //task 4
        this.Books = new SortedSet<Book>(books, new BookComparator());
    }
    public SortedSet<Book> Books { get; set; }
    //public IReadOnlyList<Book> Books { get; set; }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.Books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current
        {
            get {return this.books [this.currentIndex];}
        }

        object IEnumerator.Current
        {
           get { return this.Current; }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            return ++this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }
    }
}