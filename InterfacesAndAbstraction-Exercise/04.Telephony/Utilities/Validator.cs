namespace _04.Telephony.Utilities
{
    using System.Text.RegularExpressions;

    public static class Validator
    {
        public static bool ValidateWebsite(string input)
        {
            var regex = new Regex("[0-9]");
            return regex.IsMatch(input);
        }

        public static bool ValidateNumber(string input)
        {
            var regex = new Regex("[^0-9]");
            return regex.IsMatch(input);
        }
    }
}