using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string username;
        private string password;

        public HttpRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
