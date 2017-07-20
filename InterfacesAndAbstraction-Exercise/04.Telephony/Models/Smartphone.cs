namespace _04.Telephony.Models
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;
    using Utilities;

    public class Smartphone : ICallable, IBrowseable
    {
        public Smartphone(IEnumerable<string> websites, IEnumerable<string> numbers)
        {
            this.Websites = websites;
            this.Numbers = numbers;
        }

        public IEnumerable<string> Websites { get; set; }

        public IEnumerable<string> Numbers { get; set; }


        public string Call(string number)
        {
            return $"Calling... {number}";
        }

        public string Browse(string website)
        {
            return $"Browsing: {website}!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var number in this.Numbers)
            {
                if (!Validator.ValidateNumber(number))
                {
                    sb.AppendLine(this.Call(number));
                }
                else
                {
                    sb.AppendLine("Invalid number!");
                }
            }

            foreach (var site in this.Websites)
            {
                if (!Validator.ValidateWebsite(site))
                {
                    sb.AppendLine(this.Browse(site));
                }
                else
                {
                    sb.AppendLine("Invalid URL!");
                }
            }
            return sb.ToString().Trim();
        }
    }
}