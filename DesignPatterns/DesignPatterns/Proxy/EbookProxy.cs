using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class EbookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public EbookProxy(string fileName)
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

            ebook.Show();
        }
    }
}
