using System.Collections.Generic;

public interface ILibrary : IEnumerable<Book>
{
    //IReadOnlyList<Book> Books { get; }
    SortedSet<Book> Books { get; }
}