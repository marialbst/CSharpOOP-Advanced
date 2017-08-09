namespace _04.Recharge_foreign_lib.Models.Adapters
{
    using Interfaces;

    public class EmployeeAdapter : ISleeper
    {
        private Employee empl;

        public EmployeeAdapter(string id)
        {
            this.empl = new Employee(id);
        }

        public void Sleep()
        {
            this.empl.Sleep();
        }
    }
}
