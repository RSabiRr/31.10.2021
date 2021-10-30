using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public int fuelCapacity;
        public int doorCount;
        public string consuption;

        public string about()
        {

            return ($"Brend: {brand}  Model:   {model} ");

        }

        public string way()
        {
            int yol = 8;

            int yol2 = fuelCapacity / yol;

            return ($"100 e 8'l gedr, POLNU BAK=100KM * {yol2} ");

        }



    }
}
