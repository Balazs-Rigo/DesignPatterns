using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade.Exercise
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string getAccesToken(string requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
