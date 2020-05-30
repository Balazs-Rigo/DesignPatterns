using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Message
    {
        private string content;

        public Message(string content)
        {
            this.content = content;
        }
    }
}
