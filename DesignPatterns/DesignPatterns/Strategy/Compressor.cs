using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface ICompressor
    {
        void Compress(string fileName);
    }
}
