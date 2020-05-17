using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            var IsValid = (request.GetUsername() == "admin" && request.GetPassword() == "1234");

            Console.WriteLine("Authentication");

            return !IsValid;
        }
    }
}
