using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class RealEbook : IEbook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading the ebook "+fileName);
        }
        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook "+fileName);
        }
    }
}
