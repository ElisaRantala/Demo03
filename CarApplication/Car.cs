using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {

        //properties (auton ominaisuudet) luetellaan alussa
        public string Model { get; set; }  // set asentaa, get kysyy
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        // default constructor

        public Car()
        {

        }

        // parametrillinen constructor...
        public Car(string model) // pitää olla eri tyyppinen, esim ei kahta stringiä
        {
            Model = model;
        }
        
        // method to give more speed (lisää nopeutta)
        public void Accelerate()
        {
            Speed += 10;
        }

        // method to slow down (hidastaa)
        public void Brake(int value)
        {
            Speed -= value; // Speed = Speed - value;
        }

        // method to display car data/properties (auton tiedot)
        public void PrintData()
        {
            Console.WriteLine("Car properties:");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
            Console.WriteLine("- some static property : " + SomeProperty);

        }

        // tuhoutuja (destructor)

        ~Car()
        {
            Console.WriteLine("Car object destroyed!");
        }

    } // class
} // namespace
