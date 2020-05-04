﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
