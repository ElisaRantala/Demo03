using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukonepplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.WashTime = 60;
            pesukone.Temperature = -40;
            pesukone.Sling = 1200;
            pesukone.TurnOn(); 
            Console.WriteLine("Washing time is: " + pesukone.WashTime + "min");
            Console.WriteLine("Washing temperature is: " + pesukone.Temperature + " degrees");
            Console.WriteLine("Washing machine slings " + pesukone.Sling + " rounds");
        }
    }
}
