using DesignPatterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
