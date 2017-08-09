namespace _05.Security_Door.Models
{
    using System;
    using Interfaces;

    public class ScannerUI : ISecurityUi
    {
        public string RequestKeyCard()
        {
            Console.WriteLine("Slide your key card");
            return Console.ReadLine();
        }

        public int RequestPinCode()
        {
            Console.WriteLine("Enter your pin code:");
            return int.Parse(Console.ReadLine());
        }
    }
}