using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Encryptor : Handler
    {

        public Encryptor(Handler next) : base(next)
        {

        }
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Encryptor");

            return false;
        }
    }
}
