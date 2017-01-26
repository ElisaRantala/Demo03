using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            tv.Channel = 2;
            tv.Volume = 10;
            tv.Brightness = 55;
            tv.TurnOn();
            Console.WriteLine("Tv is on channel: " + tv.Channel);
            Console.WriteLine("Tv volume is: " + tv.Volume);
            Console.WriteLine("Tv brightness is: " + tv.Brightness);
            tv.TurnOff();
        }
    }
}
