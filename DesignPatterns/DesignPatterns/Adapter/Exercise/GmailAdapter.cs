using DesignPatterns.Adapter.Exercise.Gmail;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Exercise
{
    public class GmailAdapter : IEmailProvider
    {
        private GmailClient client = new GmailClient();
        public void DownloadEmails()
        {
            client.Connect();
            client.GetEmails();
            client.Disconnect();
        }
    }
}
