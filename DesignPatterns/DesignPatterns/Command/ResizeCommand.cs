using DesignPatterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
