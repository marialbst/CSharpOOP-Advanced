using System.Collections.Generic;

public class BookComparator : IComparer<Book>
{
    public int Compare(Book book1, Book book2)
    {
        if(book1.Title != book2.Title)
        {
            return book1.Title.CompareTo(book2.Title);
        }

        return book2.Year.CompareTo(book1.Year);
    }
}