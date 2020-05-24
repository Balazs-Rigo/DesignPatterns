using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Shape : IComponent
    {
        public void Move()
        {
            Console.WriteLine("Move Shape");
        }

        public void Render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
