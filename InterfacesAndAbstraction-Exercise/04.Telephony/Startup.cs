namespace _04.Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class Startup
    {
        public static void Main(string[] args)
        {
            List<string> numbersSeq = Console.ReadLine()
                .Split()
                .ToList();
            List<string> sitesSeq = Console.ReadLine()
                .Split()
                .ToList();

            Smartphone phone = new Smartphone(sitesSeq, numbersSeq);

            Console.WriteLine(phone.ToString());
        }
    }
}