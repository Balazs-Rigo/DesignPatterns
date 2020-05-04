using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon"); ;
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line"); ;
        }
    }
}
