using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public int dailSalary;

        public string monthlySalary()
        {
            int ayliq;

            ayliq = dailSalary * 30;

            return ($"{name} {surname}    Ayliq geliri: {ayliq}AZN");


        }

    }
}
