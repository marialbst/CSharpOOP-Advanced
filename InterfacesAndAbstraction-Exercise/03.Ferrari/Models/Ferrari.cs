namespace _03.Ferrari.Models
{
    using Interfaces;

    public class Ferrari : Car
    {
        public Ferrari(string driver) :
            base("488-Spider", driver)
        {
        }
    }
}