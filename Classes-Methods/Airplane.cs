using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods
{
    class Airplane
    {
        int wings, wheels, engines;

        public void Run()
        {
            this.wheels = 6;
            Console.WriteLine("Running");
        }
        public void Fly()
        {
            this.wings = 2;
            Console.WriteLine("Flying");

        }
        public void Powerplant()
        {
            this.engines = 4;
            Console.WriteLine("Power...");
        }
    }
    class Fighterjet : Airplane
    {

    }
}
