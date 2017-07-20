namespace _04.Telephony.Interfaces
{
    using System.Collections.Generic;

    public interface ICallable
    {
        IEnumerable<string> Numbers { get; }

        string Call(string number);
    }
}