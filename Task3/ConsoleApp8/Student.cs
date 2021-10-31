using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Student
    {
        public string fullname;
        public int course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;

        public void aboutStudent()
        {
                Console.WriteLine($"FullName:  {fullname}, Kurs:  {course}, Universitet: {university}, E-Mail:  {email}, Nomre:  {phoneNumber} " );

        }

    }
}
