using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main(string[] args)
    {
        List<string> numbersSeq = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        List<string> sitesSeq = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        Smartphone phone = new Smartphone(sitesSeq,numbersSeq);

        Console.WriteLine(phone.ToString());
    }
}