using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Tv
    {
        //properties
        public int Channel { get; set; }
        public int Volume { get; set; }
        public int Brightness { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Tv is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Tv is off");
        }
    }
}
