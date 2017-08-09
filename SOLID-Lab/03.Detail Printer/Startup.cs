namespace _03.Detail_Printer
{
    using System.Collections.Generic;
    using Core;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            Employee empl = new Employee("Pesho");
            Employee man = new Manager("Gosho", new List<string> {"doc1", "doc2"});
            IList<Employee> employees = new List<Employee>();
            employees.Add(empl);
            employees.Add(man);
            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
