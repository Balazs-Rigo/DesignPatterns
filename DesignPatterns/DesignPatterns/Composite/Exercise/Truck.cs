using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Exercise
{
    public class Truck : Resource
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploying a truck");
        }
    }
}
