namespace _11.Tuple
{
    using System;
    using Models;

    class Startup
    {
        static void Main(string[] args)
        {
            MyTuple<string, string> person = ReadPerson();
            MyTuple<string, int> beer = ReadBeerDrink();
            MyTuple<int, double> numbers = ReadNumbers();
            
            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(numbers);

        }

        private static MyTuple<int, double> ReadNumbers()
        {
            string[] numsData = Console.ReadLine().Split();
            int intNum = int.Parse(numsData[0]);
            double doubleNum = double.Parse(numsData[1]);
            return new MyTuple<int, double>(intNum, doubleNum);
        }

        private static MyTuple<string, int> ReadBeerDrink()
        {
            string[] beerData = Console.ReadLine().Split();
            string name = beerData[0];
            int beer = int.Parse(beerData[1]);

            return new MyTuple<string, int>(name, beer);
        }

        private static MyTuple<string, string> ReadPerson()
        {
            string[] personData = Console.ReadLine().Split();
            string name = personData[0] + " " + personData[1];
            string address = personData[2];
            return new MyTuple<string, string>(name, address);
        }
    }
}
