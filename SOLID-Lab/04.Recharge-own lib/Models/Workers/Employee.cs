namespace _04.Recharge_own_lib.Models.Workers
{
    using Interfaces;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base (id)
        {
        }

        public void Sleep()
        {
            // sleep...
        }
        
    }
}