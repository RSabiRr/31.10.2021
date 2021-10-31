using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Sizes sizes = new Sizes();
            Console.WriteLine("Uzunlugu daxil edin: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enini daxil edin: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hundurluyu  daxil edin: ");
            int height = Convert.ToInt32(Console.ReadLine());

            //sizes.length = 2;
            //sizes.height = 5;
            //sizes.width = 1;

            Console.WriteLine("Hecmi: "+ sizes.result(width,length,height));

        }
    }
}
