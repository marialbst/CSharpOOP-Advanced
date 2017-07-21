using System;

namespace _09.Tuple
{
    class Startup
    {
        static void Main(string[] args)
        {
            Tuple<string, string> person = ReadPerson();
            Tuple<string, int> beer = ReadBeerDrink();
            Tuple<int, double> numbers = ReadNumbers();

            Console.WriteLine(person.ToString());
            Console.WriteLine(beer.ToString());
            Console.WriteLine(numbers.ToString());

        }

        private static Tuple<int, double> ReadNumbers()
        {
            string[] numsData = Console.ReadLine().Split();
            int intNum = int.Parse(numsData[0]);
            double doubleNum = double.Parse(numsData[1]);
            return new Tuple<int, double>(intNum, doubleNum);
        }

        private static Tuple<string, int> ReadBeerDrink()
        {
            string[] beerData = Console.ReadLine().Split();
            string name = beerData[0];
            int beer = int.Parse(beerData[1]);

            return new Tuple<string, int>(name, beer);
        }

        private static Tuple<string, string> ReadPerson()
        {
            string[] personData = Console.ReadLine().Split();
            string name = personData[0] + " " + personData[1];
            string address = personData[2];
            return new Tuple<string, string>(name, address);
        }
    }
}
