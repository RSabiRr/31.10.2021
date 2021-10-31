using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.fullname = "Nurlan Qasimov";
            student.course = 4;
            student.university = "AzTu";
            student.email = "Admin123@code.edu.az";
            student.phoneNumber = "0701234567";

            student.aboutStudent();

        }
    }
}
