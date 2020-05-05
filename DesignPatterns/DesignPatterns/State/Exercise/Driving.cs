using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Exercise
{
    class Driving : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 1;
        }
    }
}
