using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy:IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public LoggingEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (ebook == null)
                ebook = new RealEbook(fileName);

            Console.WriteLine("Logging");
            ebook.Show();
        }
    }
}
