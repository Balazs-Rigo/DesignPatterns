using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Exercise
{
    public class HumanResource : Resource
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploying a human resource!");
        }
    }
}
