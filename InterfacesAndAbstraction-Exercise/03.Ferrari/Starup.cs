using System;

class Starup
{
    static void Main(string[] args)
    {
        string driver = Console.ReadLine();
        ICar ferrari = new Ferrari(driver);
        Console.WriteLine(ferrari.ToString());

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;
        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}