using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from Car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";  // asetetaan uusi arvo (set juttu)
            car.Color = "Red";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperty = 56;   // yhteinen kaikille
            car.PrintData();

            // create another car object
            string model = "Speedster";
            Car nascar = new Car(model);   // nascar on autoluokan edustaja
            nascar.PrintData();
            nascar.Color = "black";  // set
            Console.WriteLine("color is:" + nascar.Color); // vain väri!!!! get
        }
    }
}

// ensin luodaan luokka, sen jälkeen siitä luodaan olio käyttämällä new luokkaa