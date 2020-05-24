using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public abstract class DataReader
    {
        private DataReader next;

        public void SetNext(DataReader next)
        {
            this.next = next;
        }

        public void Read(string fileName)
        {
            if (fileName.EndsWith(this.GetExtension()))
            {
                this.DoRead(fileName);
            }
            else if (this.next != null)
            {
                this.next.Read(fileName);
            }
            else
            {
                throw new InvalidOperationException("file format not supported");
            }
        }

        protected abstract string GetExtension();

        protected abstract void DoRead(string var1);
    }
}
