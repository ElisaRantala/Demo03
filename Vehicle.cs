using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vehicle properties is: ");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Speed is: " + Speed);
            Console.WriteLine("Tyres : " + Tyres);
            Console.WriteLine(" ");
        }

        public void ToString()
        {
            Console.WriteLine("Name:" + Name + " Speed: " + Speed + " Tyres : " + Tyres);
        }
    }
}
