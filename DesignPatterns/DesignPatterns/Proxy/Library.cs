using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void Add(IEbook ebook)
        {
            ebooks.Add(ebook.GetFileName(),ebook);
        }

        public void openEbook(string fileName)
        {
            ebooks[fileName].Show();
        }
    }
}
