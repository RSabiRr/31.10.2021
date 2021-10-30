using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.name = "Nurlan";
            employee.surname = "Qasimov";
            employee.dailSalary = 5;

            Console.WriteLine(employee.monthlySalary());
        }
    }
}
