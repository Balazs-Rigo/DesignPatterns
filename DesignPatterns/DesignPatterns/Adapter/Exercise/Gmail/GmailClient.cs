using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Exercise.Gmail
{
    public class GmailClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Gmail!");
        }

        public void GetEmails()
        {
            Console.WriteLine("Downloading emails from Gmail.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from Gmail.");
        }

    }
}
