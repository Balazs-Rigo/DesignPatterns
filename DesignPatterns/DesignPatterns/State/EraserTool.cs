using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon"); ;
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
