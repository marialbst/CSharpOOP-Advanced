namespace _01.Stream_Progress
{
    using System;
    using Core;
    using Interfaces;
    using Models;
    using Models.Streams;

    public class Startup
    {
        public static void Main()
        {
            IStreamable file = new File("text.txt", 10, 5);
            StreamProgressInfo streamProgress = new StreamProgressInfo(file);
            Console.WriteLine(streamProgress.CalculateCurrentPercent());

            IStreamable music = new Music("no artist","no album", 10, 6);
            StreamProgressInfo streamProgress1 = new StreamProgressInfo(file);
            Console.WriteLine(streamProgress1.CalculateCurrentPercent());
        }
    }
}
