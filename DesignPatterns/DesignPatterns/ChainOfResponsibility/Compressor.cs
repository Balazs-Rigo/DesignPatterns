using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressor");

            return false;
        }
    }
}
