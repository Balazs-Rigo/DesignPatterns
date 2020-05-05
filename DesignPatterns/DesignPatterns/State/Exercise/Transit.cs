using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Exercise
{
    class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction(transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA(transit)");
            return 3;
        }
    }
}
