using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");

            return false;
        }
    }
}
