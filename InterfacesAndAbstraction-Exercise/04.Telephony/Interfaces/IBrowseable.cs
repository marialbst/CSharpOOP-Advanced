namespace _04.Telephony.Interfaces
{
    using System.Collections.Generic;

    public interface IBrowseable
    {
        IEnumerable<string> Websites { get; }

        string Browse(string website);
    }
}