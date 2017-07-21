namespace _12.Threeple
{
    using Models;
    using Intefaces;
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            IThreeple<string, string, string> person = ReadPerson();
            IThreeple<string, int, bool> drunkPerson = ReadDrunkPerson();
            IThreeple<string, double, string> bankPerson = ReadBankPerson();

            Console.WriteLine(person);
            Console.WriteLine(drunkPerson);
            Console.WriteLine(bankPerson);
        }

        private static IThreeple<string, double, string> ReadBankPerson()
        {
            var personData = Console.ReadLine().Split();
            var name = $"{personData[0]}";
            var amount = double.Parse(personData[1]);
            var bank = personData[2];

            return new Threeple<string, double, string>(name, amount,bank);
        }

        private static IThreeple<string, int, bool> ReadDrunkPerson()
        {
            var personData = Console.ReadLine().Split();
            var name = $"{personData[0]}";
            var beer = int.Parse(personData[1]);
            var isDrunk = personData[2]=="drunk";

            return new Threeple<string, int, bool>(name, beer, isDrunk);
        }

        private static IThreeple<string, string, string> ReadPerson()
        {
            var personData = Console.ReadLine().Split();
            var name = $"{personData[0]} {personData[1]}";
            var address = personData[2];
            var town = personData[3];

            return new Threeple<string, string, string>(name,address,town);
        }
    }
}
