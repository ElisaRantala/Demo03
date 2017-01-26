using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApplication
{
    class Kiuas
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }

        public void ThrowWater() // ei voi muuttaa = void
        {
            Console.WriteLine("Shiiii.... ");
        }


    }
}
