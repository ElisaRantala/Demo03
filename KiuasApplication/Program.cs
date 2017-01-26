using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.IsOn = true;
            kiuas.Temperature = 90;
            kiuas.Humidity = 50.0;
            kiuas.ThrowWater(); // toiminto, funktio, kutsutaan
            Console.WriteLine("Temperature is: " + kiuas.Temperature);
            Console.WriteLine("Humidity is: " + kiuas.Humidity);

        }
    }
}
