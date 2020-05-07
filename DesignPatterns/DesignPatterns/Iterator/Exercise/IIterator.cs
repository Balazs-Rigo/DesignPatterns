using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.Exercise
{
    public interface IIterator
    {
        bool HasNext();
        Product Currenct();
        void Next();
    }
}
