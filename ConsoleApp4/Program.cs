using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1,2,3
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
            Console.WriteLine("car about: ");
            Console.WriteLine(" ");
            Car car1 = new Car();

            car1.model = "2106";
            car1.brand = "vaz";
            car1.fuelCapacity = 40;

            Console.WriteLine(car1.about());
            Console.WriteLine(" ");
            Console.WriteLine(car1.way());
            #endregion

            #region task 4
            Console.WriteLine(" ");
            Console.WriteLine("***************************************");
            Console.WriteLine(" ");
            Console.WriteLine("bicyrcle about: ");
            Console.WriteLine(" ");

            Bicyrcle bicyrcle = new Bicyrcle();

            bicyrcle.brand = "BMX";
            bicyrcle.model = "Kink Liberty";

            bicyrcle.about();
            #endregion






        }

    }

    class vehicle
    {
       public string brand;
       public string color;
       public string model;

        public void about()
        {


          Console.WriteLine($"Brand: {brand}  Model: {model}");

        

        }

    }
}
