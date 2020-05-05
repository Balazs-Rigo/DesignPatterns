﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Exercise
{
    class Bicycling : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
