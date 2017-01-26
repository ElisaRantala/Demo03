using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukonepplication
{
    class Pesukone
    {
        // properties
        public double WashTime { get; set; }
        public int Temperature { get; set; }
        public int Sling { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Washing machine is on");
        }

    }
}
