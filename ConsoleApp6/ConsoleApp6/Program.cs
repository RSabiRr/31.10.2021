using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Console.WriteLine("Student:  ");
            Console.WriteLine();

            student.name = "Nurlan";
            student.surname = "Qasimov";
            student.age = 21;

            student.Greet();
            student.ShowAge();
            student.Study();
            Console.WriteLine();
            Console.WriteLine("******************************");


            Teacher teacher = new Teacher();
            Console.WriteLine("Teacher:  ");
            Console.WriteLine();
            teacher.name = "Ilkin";
            teacher.surname = "Beydullayev";
            teacher.age = 30;

            
            teacher.Greet();
            teacher.SetAge(teacher.age);
            teacher.Explain();
        }
    }


    class Student : Person
    {
        



        public void Study()
        {
            Console.WriteLine($"I'm studying ");


        }

        public void ShowAge()
        {

            Console.WriteLine($"My age is:  {age} years old");

        }
    }


    class Teacher :Person
    {
        



        public void Explain()
        {

            Console.WriteLine($"I'm explaining  ");

        }



    }

    class Person
    {

        public string name;
        public string surname;
        public int age;

        public void SetAge(int age)
        {

            Console.WriteLine($"Age {age}");

        }



        public void Greet()
        {
            Console.WriteLine($"Name: {name} Surname: {surname}");

        }


    }
}
