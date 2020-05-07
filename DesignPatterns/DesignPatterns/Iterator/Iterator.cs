using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public interface Iterator
    {
        bool hasNext();
        string current();
        void next();
    }
}
